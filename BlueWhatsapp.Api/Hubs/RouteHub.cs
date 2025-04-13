using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;

namespace BlueWhatsapp.Api.Hubs;

public class RouteHub : Hub 
{
    private readonly IRouteRepository _routeRepository;

    public RouteHub(IRouteRepository routeRepository)
    {
        _routeRepository = routeRepository;
    }

    public async Task GetRoutes()
    {
        var routes = await _routeRepository.GetAllRoutesAsync();
        await Clients.All.SendAsync("ReceiveRoutes", routes);
    }

    public async Task CreateRoute(CoreRoute route)
    {
        CoreRoute createdRoute = await _routeRepository.CreateRouteAsync(route).ConfigureAwait(true);
        IEnumerable<CoreRoute> routes = await _routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveRoutes", routes).ConfigureAwait(true);
    }

    public async Task UpdateRoute(CoreRoute route)
    {
        await _routeRepository.UpdateRouteAsync(route).ConfigureAwait(true);
        IEnumerable<CoreRoute> routes = await _routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveRoutes", routes).ConfigureAwait(true);
    }

    public async Task DeleteRoute(int id)
    {
        await _routeRepository.DeleteRouteAsync(id).ConfigureAwait(true);
        IEnumerable<CoreRoute> routes = await _routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
        await Clients.All.SendAsync("ReceiveRoutes", routes).ConfigureAwait(true);
    }
    
}