using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Models.Trip;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace BlueWhatsapp.Api.Hubs;

public class TripHub : Hub
{
    private readonly ITripRepository _tripRepository;
    private readonly IRouteRepository _routeRepository;
    private readonly IScheduleRepository _scheduleRepository;
    private readonly IReservationRepository _reservationRepository;
    private readonly ILogger<TripHub> _logger;

    public TripHub(
        ITripRepository tripRepository, 
        IRouteRepository routeRepository,
        IScheduleRepository scheduleRepository,
        IReservationRepository reservationRepository,
        ILogger<TripHub> logger)
    {
        _tripRepository = tripRepository;
        _routeRepository = routeRepository;
        _scheduleRepository = scheduleRepository;
        _reservationRepository = reservationRepository;
        _logger = logger;
    }

    public async Task GetTrips()
    {
        try
        {
            IEnumerable<CoreTrip> trips = await _tripRepository.GetAllTripsAsync().ConfigureAwait(true);
            
            // Calculate today's reservations for each trip (using local time to match frontend)
            string today = DateTime.Now.Date.ToString("yyyy-MM-dd");
            _logger.LogInformation("Calculating reservations for date: {Today}", today);
            
            foreach (var trip in trips)
            {
                var allReservations = await _reservationRepository.GetReservationsByTripId(trip.Id).ConfigureAwait(true);
                var todayReservations = allReservations.Where(r => 
                    (string.IsNullOrEmpty(r.Status) || r.Status == "Active") && 
                    r.ReservationDate == today).ToList();
                
                trip.CurrentReservations = todayReservations.Count;
                
                _logger.LogInformation("Trip {TripId} ({TripName}): {TotalReservations} total reservations, {TodayReservations} for today ({Today})", 
                    trip.Id, trip.TripName, allReservations.Count(), todayReservations.Count, today);
                    
                // Log first few reservations for debugging
                foreach (var reservation in allReservations.Take(3))
                {
                    _logger.LogInformation("  - Reservation {Id}: Date={Date}, Status={Status}", 
                        reservation.Id, reservation.ReservationDate, reservation.Status ?? "NULL");
                }
            }
            
            _logger.LogInformation("Sending {TripsCount} trips to clients", trips.Count());
            await Clients.All.SendAsync("ReceiveTrips", trips).ConfigureAwait(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting trips");
            throw;
        }
    }

    public async Task GetRoutes()
    {
        var routes = await _routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveRoutes", routes).ConfigureAwait(true);
    }

    public async Task GetSchedules()
    {
        var schedules = await _scheduleRepository.GetAllSchedulesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveSchedules", schedules).ConfigureAwait(true);
    }

    public async Task SearchTrips(string value)
    {
        var trips = await _tripRepository.SearchTripsAsync(value).ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveTrips", trips).ConfigureAwait(true);
    }
    
    public async Task SaveTrip(CoreTrip trip)
    {
        if (trip.Id == 0)
        {
            await _tripRepository.CreateTripAsync(trip).ConfigureAwait(true);
        }
        else
        {
            await _tripRepository.UpdateTripAsync(trip).ConfigureAwait(true);
        }
        await GetTrips().ConfigureAwait(true);
    }

    public async Task UpdateTripStatus(CoreTrip trip)
    {
        await _tripRepository.UpdateTripStatusAsync(trip.Id, trip.IsActiveForToday).ConfigureAwait(true);
        await GetTrips().ConfigureAwait(true);
    }    

    public async Task DeleteTrip(int tripId)
    {
        await _tripRepository.DeleteTripAsync(tripId).ConfigureAwait(true);
        await GetTrips().ConfigureAwait(true);
    }
}
