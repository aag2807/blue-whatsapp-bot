using BlueWhatsapp.Core.Models.Trip;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;

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
    /// 
    /// </summary>
    public string Details { get; set; } = string.Empty;
    
    /// <summary>
    /// The date of the reservation
    /// </summary>
    public string ReservationDate { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string ReserveTime { get; set; }  = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string HotelName { get; set; } = string.Empty;

    /// <summary>
    /// The trip of the reservation
    /// </summary>  
    public CoreTrip Trip { get; set; } = new CoreTrip();
    
    /// <summary>
    /// The id of the trip
    /// </summary>
    public int TripId { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public CoreSchedule? Schedule { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public CoreHotel? Hotel { get; set; }
}