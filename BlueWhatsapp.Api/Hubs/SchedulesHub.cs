using BlueWhatsapp.Api.models.DTO;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;

namespace BlueWhatsapp.Api.Hubs;

public class ScheduleHub : Hub
{
    private readonly IScheduleRepository _scheduleRepository;

    public ScheduleHub(IScheduleRepository scheduleRepository)
    {
        _scheduleRepository = scheduleRepository;
    }

    public async Task GetSchedules()
    {
        IEnumerable<CoreSchedule> schedules = await _scheduleRepository.GetAllSchedulesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveSchedules", schedules).ConfigureAwait(true);
    }

    public async Task CreateSchedule(CoreSchedule schedule)
    {
        await _scheduleRepository.PersistAsync(schedule).ConfigureAwait(true);
        IEnumerable<CoreSchedule> schedules = await _scheduleRepository.GetAllSchedulesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveSchedules", schedules).ConfigureAwait(true);
    }
    
    public async Task UpdateSchedule(CoreSchedule schedule)
    {
        await _scheduleRepository.UpdateAsync(schedule).ConfigureAwait(true);
        IEnumerable<CoreSchedule> schedules = await _scheduleRepository.GetAllSchedulesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveSchedules", schedules).ConfigureAwait(true);
    }
    
    public async Task DeleteSchedule(int id)
    {
        await _scheduleRepository.DeleteAsync(id).ConfigureAwait(true);
        IEnumerable<CoreSchedule> schedules = await _scheduleRepository.GetAllSchedulesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveSchedules", schedules).ConfigureAwait(true);
    }

    public async Task GetSchedulesPaginated(int page, int pageSize = 20)
    {
        IEnumerable<CoreSchedule> schedules = await _scheduleRepository.GetSchedulesPaginated(page, pageSize).ConfigureAwait(true);
        int totalSchedules = await _scheduleRepository.GetTotalSchedulesAsync().ConfigureAwait(true);

        PaginatedResponse<CoreSchedule> paginatedResponse = new PaginatedResponse<CoreSchedule>
        {
            Data = schedules.ToList(),
            Total = totalSchedules,
            Page = page,
            PageSize = pageSize
        };

        await Clients.All.SendAsync("ReceiveSchedules", paginatedResponse).ConfigureAwait(true);
    }

}