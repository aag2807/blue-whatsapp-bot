using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;

namespace BlueWhatsapp.Api.Hubs;

public class ReservationsHub : Hub
{
    private readonly IReservationRepository _reservationRepository;

    public ReservationsHub(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }
    
    public async Task GetReservations()
    {
        IEnumerable<CoreReservation> reservations = await _reservationRepository.GetAllWeeklyReservationsOrderedByCreationDate().ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveReservations", reservations).ConfigureAwait(true);
    }
}
