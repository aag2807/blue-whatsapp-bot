using System.Runtime.CompilerServices;
using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Utils;
using Microsoft.EntityFrameworkCore;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class ScheduleRepository : BaseRepository<Schedule>, IScheduleRepository
{
    public ScheduleRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreSchedule>> IScheduleRepository.GetAllSchedulesAsync()
    {
        IReadOnlyList<Schedule> schedules = await GetAllActiveAsync(false).ConfigureAwait(true);
        List<HotelSchedule> hotelSchedules = await _dbContext.HotelSchedules.ToListAsync().ConfigureAwait(true);
        
        Dictionary<int, int> hotelCountByScheduleId = hotelSchedules
            .GroupBy(h => h.ScheduleId)
            .ToDictionary(g => g.Key, g => g.Count());

        return schedules
            .OrderBy(x => x.Time, new TimeStringComparer())
            .Select(s => new CoreSchedule(s.Id, s.Name, s.Time)
            {
                HotelCount = hotelCountByScheduleId.TryGetValue(s.Id, out int count) ? count : 0
            });
    }

    /// <inheritdoc/>
    async Task<CoreSchedule?> IScheduleRepository.GetScheduleByIdAsync(int id)
    {
        Schedule? schedule = await GetByIdAsync(id, false).ConfigureAwait(true);
        return schedule != null ? new CoreSchedule(schedule.Id, schedule.Name, schedule.Time) : null;
    }

    /// <inheritdoc/>
    async Task IScheduleRepository.PersistAsync(CoreSchedule schedule)
    {
        Schedule newSchedule = new Schedule
        {
            Name = schedule.Name,
            Time = schedule.Time
        };

        await AddAsync(newSchedule).ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task IScheduleRepository.UpdateAsync(CoreSchedule schedule)
    {
        Schedule? existingSchedule = await GetByIdAsync(schedule.Id, false).ConfigureAwait(true);
        if (existingSchedule == null)
        {
            throw new Exception("Schedule not found");
        }

        existingSchedule.Name = schedule.Name;
        existingSchedule.Time = schedule.Time;

        await UpdateAsync(existingSchedule).ConfigureAwait(true);
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task IScheduleRepository.DeleteAsync(int id)
    {
        Schedule? schedule = await GetByIdAsync(id, false).ConfigureAwait(true);
        if (schedule == null)
        {
            throw new Exception("Schedule not found");
        }

        await SoftDeleteAsync(schedule.Id).ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreSchedule>> IScheduleRepository.GetSchedulesPaginated(int page, int pageSize = 20)
    {
        Arguments.GreaterThan(page, 0, nameof(page));
        Arguments.GreaterThan(pageSize, 0, nameof(pageSize));

        IReadOnlyList<Schedule> schedules = await _dbContext
            .Schedules
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync()
            .ConfigureAwait(true);

        return schedules.Select(s => new CoreSchedule(s.Id, s.Name, s.Time));
    }

    /// <inheritdoc/>
    async Task<int> IScheduleRepository.GetTotalSchedulesAsync()
    {
        return await CountAsync(null, false, false).ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreSchedule>> IScheduleRepository.GetSchedulesByHotelId(int id)
    {
        List<Schedule> results = await _dbContext.HotelSchedules
            .Where( hs => hs.HotelId == id)
            .Include( hs => hs.Schedule)
            .Select( hs => hs.Schedule)
            .ToListAsync()
            .ConfigureAwait(true);
        
        return results.Select(schedule => new CoreSchedule(schedule.Id, schedule.Name, schedule.Time));
    }
}