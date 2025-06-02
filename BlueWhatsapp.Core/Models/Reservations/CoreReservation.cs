using BlueWhatsapp.Core.Models.Trip;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Core.Models.Reservations;

public sealed class CoreReservation : BaseEntity
{
    /// <summary>
    /// The unique identifier for the reservation
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The number of the user
    /// </summary>
    public string UserNumber { get; set; } = string.Empty;

    /// <summary>
    /// The name of the user
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// The room number of the customer
    /// </summary>
    public string RoomNumber { get; set; } = string.Empty;

    /// <summary>
    /// The number of adults in the reservation
    /// </summary>
    public int AdultsCount { get; set; } = 1;

    /// <summary>
    /// The number of children in the reservation
    /// </summary>
    public int ChildrenCount { get; set; } = 0;

    /// <summary>
    /// The email of the customer
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// The status of the reservation (Active, Cancelled, Rescheduled)
    /// </summary>
    public string Status { get; set; } = "Active";

    /// <summary>
    /// Reference to the original reservation if this is a rescheduled one
    /// </summary>
    public int? OriginalReservationId { get; set; }

    /// <summary>
    /// Reason for cancellation or rescheduling
    /// </summary>
    public string StatusReason { get; set; } = string.Empty;

    /// <summary>
    /// Additional details or notes for the reservation
    /// </summary>
    public string Details { get; set; } = string.Empty;
    
    /// <summary>
    /// The date of the reservation
    /// </summary>
    public string ReservationDate { get; set; } = string.Empty;

    /// <summary>
    /// The time for the reservation
    /// </summary>
    public string ReserveTime { get; set; }  = string.Empty;

    /// <summary>
    /// The name of the hotel
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
    /// The schedule for the reservation
    /// </summary>
    public CoreSchedule? Schedule { get; set; }
    
    /// <summary>
    /// The hotel for the reservation
    /// </summary>
    public CoreHotel? Hotel { get; set; }
}