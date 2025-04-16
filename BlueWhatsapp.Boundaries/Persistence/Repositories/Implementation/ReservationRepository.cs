using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
{
    public ReservationRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }
    
    /// <inheritdoc />
    async Task IReservationRepository.SaveReservation(CoreReservation reservation)
    {
        Reservation model = Reservation.FromCoreEntity(reservation);
        await AddAsync(model).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetAllWeeklyReservationsOrderedByCreationDate()
    {
        DateTime today = DateTime.UtcNow.Date;
        int currentDayOfWeek = (int)today.DayOfWeek;
        DateTime startOfWeek = today.AddDays(-currentDayOfWeek);
        DateTime endOfWeek = startOfWeek.AddDays(7); 

        List<Reservation> response = await GetAllActiveQuery(false)
            .Where(r => r.CreatedTime.Date >= startOfWeek && r.CreatedTime.Date < endOfWeek)
            .OrderByDescending(r => r.CreatedTime)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(Reservation.ToCoreEntity);
    }
}