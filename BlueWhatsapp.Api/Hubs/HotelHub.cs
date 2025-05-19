using BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;
using Triplex.Validations;

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

    public async Task CreateHotel(CoreHotel hotel)
    {
        Arguments.NotNull(hotel, nameof(hotel));
        await _hotelRepository.CreateHotelAsync(hotel).ConfigureAwait(true);
                    
        await GetHotels().ConfigureAwait(true);
    }

    public async Task DeleteHotel(int hotelId)
    {
        Arguments.GreaterThan(hotelId, 0, nameof(hotelId));

        await _hotelRepository.DeleteHotelAsync(hotelId).ConfigureAwait(true);

        await GetHotels().ConfigureAwait(true);
    }
}
