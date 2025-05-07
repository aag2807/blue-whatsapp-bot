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

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetAllDailyReservationsOrderedByCreationDate()
    {
        DateTime today = DateTime.UtcNow.Date;
        List<Reservation> response = await GetAllActiveQuery(false)
            .Where(r => r.CreatedTime.Date == today)
            .OrderByDescending(r => r.CreatedTime)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(Reservation.ToCoreEntity);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetAllUpcomingReservationsOrderedByCreationDate()
    {
        DateTime today = DateTime.UtcNow.Date;
        List<Reservation> response = await GetAllActiveQuery(false)
            .Where(r => r.CreatedTime.Date > today)
            .OrderByDescending(r => r.CreatedTime)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(Reservation.ToCoreEntity);
    }

    /// <inheritdoc />
    async Task IReservationRepository.DeleteReservation(int reservationId)
    {
        await SoftDeleteAsync(reservationId).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetReservationsByTripId(int tripId)
    {
        List<Reservation> response = await GetAllActiveQuery(false)
            .Where(r => r.TripId == tripId)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(Reservation.ToCoreEntity);
    }
}