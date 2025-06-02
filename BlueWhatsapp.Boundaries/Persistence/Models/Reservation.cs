using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Models.Reservations;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

[Table("Reservations")]
public sealed class Reservation : BaseEntity
{
    /// <summary>
    /// The number of the user
    /// </summary>
    public string UserNumber { get; set; } = string.Empty;
    
    /// <summary>
    /// The name of the user
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    
    /// <summary>
    /// The room number of the customer
    /// </summary>
    [MaxLength(50)]
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
    [MaxLength(150)]
    public string Email { get; set; } = string.Empty;
    
    /// <summary>
    /// The status of the reservation (Active, Cancelled, Rescheduled)
    /// </summary>
    [MaxLength(50)]
    public string Status { get; set; } = "Active";

    /// <summary>
    /// Reference to the original reservation if this is a rescheduled one
    /// </summary>
    public int? OriginalReservationId { get; set; }

    /// <summary>
    /// Reason for cancellation or rescheduling
    /// </summary>
    [MaxLength(500)]
    public string StatusReason { get; set; } = string.Empty;
    
    /// <summary>
    /// Additional details or notes for the reservation
    /// </summary>
    [MaxLength(250)]
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// The date of the reservation
    /// </summary>
    [MaxLength(50)]
    public string ReservationDate { get; set; } = string.Empty;
    
    /// <summary>
    /// The name of the hotel
    /// </summary>
    [MaxLength(50)]
    public string HotelName { get; set; } = string.Empty;
    
    /// <summary>
    /// The time for the reservation
    /// </summary>
    [MaxLength(50)]
    public string ReserveTime { get; set; }  = string.Empty;

    /// <summary>
    /// The id of the trip associated with the reservation
    /// </summary>
    [ForeignKey("Trip")]
    public int TripId { get; set; }

    /// <summary>
    /// The trip associated with the reservation
    /// </summary>
    public Trip? Trip { get; set; }

    /// <summary>
    /// Converts a CoreReservation entity to a Reservation database model
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Reservation FromCoreEntity(CoreReservation entity)
    {
        var model = new Reservation();
        model.UserNumber = entity.UserNumber;
        model.UserName = entity.Username;
        model.RoomNumber = entity.RoomNumber;
        model.AdultsCount = entity.AdultsCount;
        model.ChildrenCount = entity.ChildrenCount;
        model.Email = entity.Email;
        model.Status = entity.Status;
        model.OriginalReservationId = entity.OriginalReservationId;
        model.StatusReason = entity.StatusReason;
        model.Details = entity.Details;
        model.ReservationDate = entity.ReservationDate;
        model.HotelName = entity.HotelName;
        model.ReserveTime = entity.ReserveTime;
        model.TripId = entity.TripId > 0 ? entity.TripId : 1;

        return model;
    }

    /// <summary>
    /// Converts a Reservation database model to a CoreReservation entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static CoreReservation ToCoreEntity(Reservation entity)
    {
        var core = new CoreReservation();
        core.Id = entity.Id;
        core.UserNumber = entity.UserNumber;
        core.Username = entity.UserName;
        core.RoomNumber = entity.RoomNumber;
        core.AdultsCount = entity.AdultsCount;
        core.ChildrenCount = entity.ChildrenCount;
        core.Email = entity.Email;
        core.Status = entity.Status;
        core.OriginalReservationId = entity.OriginalReservationId;
        core.StatusReason = entity.StatusReason;
        core.Details = entity.Details;
        core.ReservationDate = entity.ReservationDate;
        core.HotelName = entity.HotelName;
        core.ReserveTime = entity.ReserveTime;
        core.TripId = entity.TripId;

        return core;
    }
}
