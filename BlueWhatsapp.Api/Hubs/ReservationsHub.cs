using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace BlueWhatsapp.Api.Hubs;

public class ReservationsHub : Hub
{
    private readonly IReservationRepository _reservationRepository;
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IHotelRepository _hotelRepository;
    private readonly ITripRepository _tripRepository;
    private readonly ILogger<ReservationsHub> _logger;
    private const int DAILY_CAPACITY_LIMIT = 30;

    public ReservationsHub(
        IReservationRepository reservationRepository, 
        IScheduleRepository scheduleRepository,
        IHotelRepository hotelRepository,
        ITripRepository tripRepository,
        ILogger<ReservationsHub> logger)
    {
        _reservationRepository = reservationRepository;
        _scheduleRepository = scheduleRepository;
        _hotelRepository = hotelRepository;
        _tripRepository = tripRepository;
        _logger = logger;
    }
    
    public async Task GetReservations()
    {
        _logger.LogInformation("GetReservations called by client {ConnectionId}", Context.ConnectionId);
        IEnumerable<CoreReservation> reservations = await _reservationRepository.GetAllWeeklyReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Retrieved {Count} weekly reservations", reservations.Count());
        await Clients.Caller.SendAsync("ReceiveReservations", reservations).ConfigureAwait(true);
    }

    public async Task GetReservationsForToday()
    {
        _logger.LogInformation("GetReservationsForToday called by client {ConnectionId}", Context.ConnectionId);
        IEnumerable<CoreReservation> reservations = await _reservationRepository.GetAllDailyReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Retrieved {Count} daily reservations", reservations.Count());
        await Clients.Caller.SendAsync("ReceiveReservations", reservations).ConfigureAwait(true);
    }

    public async Task GetUpcomingReservations()
    {
        _logger.LogInformation("GetUpcomingReservations called by client {ConnectionId}", Context.ConnectionId);
        IEnumerable<CoreReservation> reservations = await _reservationRepository.GetAllUpcomingReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Retrieved {Count} upcoming reservations", reservations.Count());
        await Clients.Caller.SendAsync("ReceiveReservations", reservations).ConfigureAwait(true);
    }

    public async Task GetSchedules()
    {
        _logger.LogInformation("GetSchedules called by client {ConnectionId}", Context.ConnectionId);
        IEnumerable<CoreSchedule> schedules = await _scheduleRepository.GetAllSchedulesAsync().ConfigureAwait(true);
        _logger.LogInformation("Retrieved {Count} schedules", schedules.Count());
        await Clients.Caller.SendAsync("ReceiveSchedules", schedules).ConfigureAwait(true);
    }

    public async Task GetHotels()
    {
        _logger.LogInformation("GetHotels called by client {ConnectionId}", Context.ConnectionId);
        IEnumerable<CoreHotel> hotels = await _hotelRepository.GetAllHotelsAsync().ConfigureAwait(true);
        _logger.LogInformation("Retrieved {Count} hotels", hotels.Count());
        await Clients.Caller.SendAsync("ReceiveHotels", hotels).ConfigureAwait(true);
    }

    public async Task GetTrips()
    {
        _logger.LogInformation("GetTrips called by client {ConnectionId}", Context.ConnectionId);
        var trips = await _tripRepository.GetAllTripsAsync().ConfigureAwait(true);
        
        // Calculate current reservations for each trip
        foreach (var trip in trips)
        {
            var reservations = await _reservationRepository.GetReservationsByTripId(trip.Id).ConfigureAwait(true);
            trip.CurrentReservations = reservations.Count();
        }
        
        _logger.LogInformation("Retrieved {Count} trips with reservation counts", trips.Count());
        await Clients.Caller.SendAsync("ReceiveTrips", trips).ConfigureAwait(true);
    }

    /// <summary>
    /// Checks if a trip has available daily capacity for a specific date
    /// </summary>
    /// <param name="tripId">The trip ID to check</param>
    /// <param name="reservationDate">The date to check capacity for</param>
    /// <param name="excludeReservationId">Optional reservation ID to exclude from the count (for updates)</param>
    /// <returns>True if capacity is available, false otherwise</returns>
    private async Task<bool> HasDailyCapacity(int tripId, string reservationDate, int? excludeReservationId = null)
    {
        var allReservations = await _reservationRepository.GetReservationsByTripId(tripId).ConfigureAwait(true);
        var dailyReservations = allReservations.Where(r => 
            r.Status == "Active" && 
            r.ReservationDate == reservationDate);
        
        // Exclude specific reservation if provided (used for updates)
        if (excludeReservationId.HasValue)
        {
            dailyReservations = dailyReservations.Where(r => r.Id != excludeReservationId.Value);
        }
        
        return dailyReservations.Count() < DAILY_CAPACITY_LIMIT;
    }

    /// <summary>
    /// Gets the current daily reservation count for a trip on a specific date
    /// </summary>
    /// <param name="tripId">The trip ID</param>
    /// <param name="reservationDate">The date to check</param>
    /// <returns>The number of active reservations for the trip on the given date</returns>
    private async Task<int> GetDailyReservationCount(int tripId, string reservationDate)
    {
        var allReservations = await _reservationRepository.GetReservationsByTripId(tripId).ConfigureAwait(true);
        return allReservations.Count(r => 
            r.Status == "Active" && 
            r.ReservationDate == reservationDate);
    }

    public async Task SaveReservation(CoreReservation reservation)
    {
        _logger.LogInformation("SaveReservation called by client {ConnectionId}", Context.ConnectionId);
        
        // Check if trip exists
        var trip = await _tripRepository.GetTripByIdAsync(reservation.TripId).ConfigureAwait(true);
        if (trip == null)
        {
            throw new InvalidOperationException("Trip not found");
        }

        // Check daily capacity (30 reservations per trip per day)
        bool hasCapacity = await HasDailyCapacity(
            reservation.TripId, 
            reservation.ReservationDate, 
            reservation.Id > 0 ? reservation.Id : null
        ).ConfigureAwait(true);

        if (!hasCapacity)
        {
            var currentCount = await GetDailyReservationCount(reservation.TripId, reservation.ReservationDate).ConfigureAwait(true);
            throw new InvalidOperationException($"Trip is at full daily capacity ({currentCount}/{DAILY_CAPACITY_LIMIT} reservations) for {reservation.ReservationDate}");
        }

        // Determine if this is a create or update operation
        if (reservation.Id > 0)
        {
            await _reservationRepository.UpdateReservation(reservation).ConfigureAwait(true);
            _logger.LogInformation("Updated reservation {ReservationId}", reservation.Id);
        }
        else
        {
            await _reservationRepository.SaveReservation(reservation).ConfigureAwait(true);
            _logger.LogInformation("Created new reservation for user {UserNumber}", reservation.UserNumber);
        }

        IEnumerable<CoreReservation> updatedReservations = await _reservationRepository.GetAllWeeklyReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Broadcasting {Count} updated reservations to all clients", updatedReservations.Count());
        await Clients.All.SendAsync("ReceiveReservations", updatedReservations).ConfigureAwait(true);
    }

    public async Task DeleteReservation(int reservationId)
    {
        _logger.LogInformation("DeleteReservation called by client {ConnectionId} for reservation {ReservationId}", Context.ConnectionId, reservationId);
        await _reservationRepository.DeleteReservation(reservationId).ConfigureAwait(true);
        IEnumerable<CoreReservation> updatedReservations = await _reservationRepository.GetAllWeeklyReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Broadcasting {Count} updated reservations to all clients", updatedReservations.Count());
        await Clients.All.SendAsync("ReceiveReservations", updatedReservations).ConfigureAwait(true);
    }

    public async Task CancelReservation(int reservationId, string reason)
    {
        _logger.LogInformation("CancelReservation called by client {ConnectionId} for reservation {ReservationId}", Context.ConnectionId, reservationId);
        
        // Update the reservation status to cancelled
        await _reservationRepository.CancelReservation(reservationId, reason).ConfigureAwait(true);
        
        // Since the repository queries filter out cancelled reservations, we need to 
        // send a direct status update to clients so they can update their local data
        await Clients.All.SendAsync("ReservationStatusChanged", new { 
            reservationId = reservationId, 
            status = "Cancelled", 
            statusReason = reason 
        }).ConfigureAwait(true);
        
        _logger.LogInformation("Broadcast status change for reservation {ReservationId} to Cancelled", reservationId);
        
        // Also get and broadcast current reservations (which won't include the cancelled one from repository)
        IEnumerable<CoreReservation> updatedReservations = await _reservationRepository.GetAllWeeklyReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Broadcasting {Count} updated reservations to all clients", updatedReservations.Count());
        await Clients.All.SendAsync("ReceiveReservations", updatedReservations).ConfigureAwait(true);
    }

    public async Task RescheduleReservation(int originalReservationId, CoreReservation newReservation, string reason)
    {
        _logger.LogInformation("RescheduleReservation called by client {ConnectionId} for reservation {ReservationId}", Context.ConnectionId, originalReservationId);
        
        // Check if trip exists
        var trip = await _tripRepository.GetTripByIdAsync(newReservation.TripId).ConfigureAwait(true);
        if (trip == null)
        {
            throw new InvalidOperationException("Trip not found");
        }

        // Check daily capacity for the new reservation date
        bool hasCapacity = await HasDailyCapacity(
            newReservation.TripId, 
            newReservation.ReservationDate, 
            originalReservationId
        ).ConfigureAwait(true);

        if (!hasCapacity)
        {
            var currentCount = await GetDailyReservationCount(newReservation.TripId, newReservation.ReservationDate).ConfigureAwait(true);
            throw new InvalidOperationException($"Trip is at full daily capacity ({currentCount}/{DAILY_CAPACITY_LIMIT} reservations) for {newReservation.ReservationDate}");
        }

        await _reservationRepository.RescheduleReservation(originalReservationId, newReservation, reason).ConfigureAwait(true);
        
        // Send status update for the original reservation
        await Clients.All.SendAsync("ReservationStatusChanged", new { 
            reservationId = originalReservationId, 
            status = "Rescheduled", 
            statusReason = reason 
        }).ConfigureAwait(true);
        
        _logger.LogInformation("Broadcast status change for reservation {ReservationId} to Rescheduled", originalReservationId);
        
        // Broadcast updated reservations list
        IEnumerable<CoreReservation> updatedReservations = await _reservationRepository.GetAllWeeklyReservationsOrderedByCreationDate().ConfigureAwait(true);
        _logger.LogInformation("Broadcasting {Count} updated reservations to all clients", updatedReservations.Count());
        await Clients.All.SendAsync("ReceiveReservations", updatedReservations).ConfigureAwait(true);
    }
}
