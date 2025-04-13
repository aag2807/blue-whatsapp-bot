using BlueWhatsapp.Core.Models.Trip;

namespace BlueWhatsapp.Core.Models.Reservations;

public sealed class CoreReservation : BaseEntity
{
    /// <summary>
    /// The number of the user
    /// </summary>
    public string UserNumber { get; set; } = string.Empty;

    /// <summary>
    /// The name of the user
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// The trip of the reservation
    /// </summary>  
    public CoreTrip Trip { get; set; } = new CoreTrip();
}