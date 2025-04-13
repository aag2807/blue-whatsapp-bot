using BlueWhatsapp.Api.Hubs;

namespace BlueWhatsapp.Api.Extensions;

internal static class HubExtensions
{
    internal static void MapHubs(this WebApplication app)
    {
        app.MapHub<MessagesHub>("/messages");
        app.MapHub<RouteHub>("/routes");
        app.MapHub<ScheduleHub>("/schedules");
        app.MapHub<TripHub>("/trips");
        app.MapHub<HotelHub>("/hotels");
        app.MapHub<ReservationsHub>("/reservations");
    }
}

