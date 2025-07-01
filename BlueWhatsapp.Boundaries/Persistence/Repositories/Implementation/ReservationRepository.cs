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
    async Task IReservationRepository.UpdateReservation(CoreReservation reservation)
    {
        var existingReservation = await GetByIdAsync(reservation.Id).ConfigureAwait(true);
        if (existingReservation == null)
        {
            throw new InvalidOperationException($"Reservation with ID {reservation.Id} not found");
        }

        // Update the existing reservation with new values
        existingReservation.UserNumber = reservation.UserNumber;
        existingReservation.UserName = reservation.Username;
        existingReservation.RoomNumber = reservation.RoomNumber;
        existingReservation.AdultsCount = reservation.AdultsCount;
        existingReservation.ChildrenCount = reservation.ChildrenCount;
        existingReservation.Email = reservation.Email;
        existingReservation.Details = reservation.Details;
        existingReservation.ReservationDate = reservation.ReservationDate;
        existingReservation.HotelName = reservation.HotelName;
        existingReservation.ReserveTime = reservation.ReserveTime;
        existingReservation.TripId = reservation.TripId > 0 ? reservation.TripId : existingReservation.TripId;
        existingReservation.ModifiedTime = DateTime.UtcNow;

        await UpdateAsync(existingReservation).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetAllWeeklyReservationsOrderedByCreationDate()
    {
        DateTime today = DateTime.Now.Date; // Use local time to match frontend
        int currentDayOfWeek = (int)today.DayOfWeek;
        DateTime startOfWeek = today.AddDays(-currentDayOfWeek);
        DateTime endOfWeek = startOfWeek.AddDays(7); 

        List<Reservation> response = await GetAllActiveQuery(false)
            .Include(r => r.Trip)
                .ThenInclude(t => t!.Route)
                    .ThenInclude(r => r!.Hotels)
            .Where(r => r.CreatedTime.Date >= startOfWeek && r.CreatedTime.Date < endOfWeek)
            .OrderByDescending(r => r.CreatedTime)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(MapToCore);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetAllDailyReservationsOrderedByCreationDate()
    {
        DateTime today = DateTime.Now.Date; // Use local time to match frontend
        string todayString = today.ToString("yyyy-MM-dd");
        
        List<Reservation> response = await GetAllActiveQuery(false)
            .Include(r => r.Trip)
                .ThenInclude(t => t!.Route)
                    .ThenInclude(r => r!.Hotels)
            .Where(r => r.ReservationDate == todayString)
            .OrderByDescending(r => r.CreatedTime)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(MapToCore);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetAllUpcomingReservationsOrderedByCreationDate()
    {
        DateTime today = DateTime.Now.Date; // Use local time to match frontend
        
        List<Reservation> response = await GetAllActiveQuery(false)
            .Include(r => r.Trip)
                .ThenInclude(t => t!.Route)
                    .ThenInclude(r => r!.Hotels)
            .ToListAsync()
            .ConfigureAwait(true);

        // Filter on client side to handle DateTime parsing
        var filteredResponse = response
            .Where(r => !string.IsNullOrEmpty(r.ReservationDate) && 
                       DateTime.TryParse(r.ReservationDate, out DateTime reservationDate) && 
                       reservationDate.Date >= today)
            .OrderByDescending(r => r.CreatedTime)
            .ToList();

        return filteredResponse.Select(MapToCore);
    }

    /// <inheritdoc />
    async Task IReservationRepository.DeleteReservation(int reservationId)
    {
        await SoftDeleteAsync(reservationId).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task IReservationRepository.CancelReservation(int reservationId, string reason)
    {
        var reservation = await GetByIdAsync(reservationId).ConfigureAwait(true);
        if (reservation != null)
        {
            reservation.Status = "Cancelled";
            reservation.StatusReason = reason;
            reservation.ModifiedTime = DateTime.UtcNow;
            await UpdateAsync(reservation).ConfigureAwait(true);
        }
    }

    /// <inheritdoc />
    async Task IReservationRepository.RescheduleReservation(int originalReservationId, CoreReservation newReservation, string reason)
    {
        // Mark the original reservation as rescheduled
        var originalReservation = await GetByIdAsync(originalReservationId).ConfigureAwait(true);
        if (originalReservation != null)
        {
            originalReservation.Status = "Rescheduled";
            originalReservation.StatusReason = reason;
            originalReservation.ModifiedTime = DateTime.UtcNow;
            await UpdateAsync(originalReservation).ConfigureAwait(true);
        }

        // Create the new reservation with reference to the original
        newReservation.Status = "Active";
        newReservation.OriginalReservationId = originalReservationId;
        newReservation.StatusReason = reason;
        await ((IReservationRepository)this).SaveReservation(newReservation).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreReservation>> IReservationRepository.GetReservationsByTripId(int tripId)
    {
        List<Reservation> response = await GetAllActiveQuery(false)
            .Include(r => r.Trip)
                .ThenInclude(t => t!.Route)
                    .ThenInclude(r => r!.Hotels)
            .Where(r => r.TripId == tripId)
            .ToListAsync()
            .ConfigureAwait(true);

        return response.Select(MapToCore);
    }

    /// <summary>
    /// Maps a Reservation entity to CoreReservation with related data
    /// </summary>
    private static CoreReservation MapToCore(Reservation entity)
    {
        var core = Reservation.ToCoreEntity(entity);
        
        // Map Trip information if available
        if (entity.Trip != null)
        {
            core.Trip = entity.Trip.ToCoreTrip();
            
            // Find the hotel that matches the reservation's hotel name
            var matchingHotel = entity.Trip.Route?.Hotels?.FirstOrDefault(h => h.Name == entity.HotelName);
            if (matchingHotel != null)
            {
                core.Hotel = matchingHotel.ToCoreHotel();
            }
        }
        
        return core;
    }
}