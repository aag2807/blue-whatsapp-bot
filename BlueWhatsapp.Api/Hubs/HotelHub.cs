using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;

namespace BlueWhatsapp.Api.Hubs;

public class HotelHub : Hub
{
    private readonly IHotelRepository _hotelRepository;
    private readonly IRouteRepository _routeRepository;
    private readonly IScheduleRepository _scheduleRepository;

    public HotelHub(IHotelRepository hotelRepository, IRouteRepository routeRepository, IScheduleRepository scheduleRepository)
    {
        _hotelRepository = hotelRepository;
        _routeRepository = routeRepository;
        _scheduleRepository = scheduleRepository;
    }

    public async Task GetHotels()
    {
        var hotels = await _hotelRepository.GetAllHotelsAsync();
        await Clients.All.SendAsync("ReceiveHotels", hotels);
    }

    public async Task GetRoutes()
    {
        var routes = await _routeRepository.GetAllRoutesAsync();
        await Clients.All.SendAsync("ReceiveRoutes", routes);
    }
        
    public async Task GetSchedules()
    {
        var schedules = await _scheduleRepository.GetAllSchedulesAsync();
        await Clients.All.SendAsync("ReceiveSchedules", schedules);
    }
    
    
    
    
    
    
}
