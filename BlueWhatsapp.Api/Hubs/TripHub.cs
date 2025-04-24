using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Trip;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;

namespace BlueWhatsapp.Api.Hubs;

public class TripHub : Hub
{
    private readonly ITripRepository _tripRepository;
    private readonly IRouteRepository _routeRepository;

    public TripHub(ITripRepository tripRepository, IRouteRepository routeRepository)
    {
        _tripRepository = tripRepository;
        _routeRepository = routeRepository;
    }

    public async Task GetTrips()
    {
        IEnumerable<CoreTrip> trips = await _tripRepository.GetAllTripsAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveTrips", trips).ConfigureAwait(true);
    }

    public async Task GetRoutes()
    {
        var routes = await _routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveRoutes", routes).ConfigureAwait(true);
    }

    public async Task SearchTrips(string value)
    {
        var trips = await _tripRepository.SearchTripsAsync(value).ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveTrips", trips).ConfigureAwait(true);
    }
    
    public async Task SaveTrip(CoreTrip trip)
    {
        await _tripRepository.CreateTripAsync(trip).ConfigureAwait(true);
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
