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

    public async Task SaveReservation(CoreReservation reservation)
    {
        _logger.LogInformation("SaveReservation called by client {ConnectionId}", Context.ConnectionId);
        
        // Check if trip has capacity
        var trip = await _tripRepository.GetTripByIdAsync(reservation.TripId).ConfigureAwait(true);
        if (trip == null)
        {
            throw new InvalidOperationException("Trip not found");
        }

        var currentReservations = await _reservationRepository.GetReservationsByTripId(trip.Id).ConfigureAwait(true);
        if (currentReservations.Count() >= trip.MaxCapacity)
        {
            throw new InvalidOperationException("Trip is at full capacity");
        }

        await _reservationRepository.SaveReservation(reservation).ConfigureAwait(true);
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
}
