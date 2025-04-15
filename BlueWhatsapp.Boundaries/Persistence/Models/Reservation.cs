
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
    /// 
    /// </summary>
    [MaxLength(250)]
    public string Details { get; set; } = string.Empty;

    /// <summary>
    /// The date of the reservation
    /// </summary>
    [MaxLength(50)]
    public string ReservationDate { get; set; } = string.Empty;
    
    /// <summary>
    /// The date of the reservation
    /// </summary>
    [MaxLength(50)]
    public string HotelName { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    [MaxLength(50)]
    public string ReserveTime { get; set; }  = string.Empty;

    /// <summary>
    /// The id of the trip associated with the reservation
    /// </summary>
    [ForeignKey("Trip")]
    [NotMapped]
    public int TripId { get; set; }

    /// <summary>
    /// The trip associated with the reservation
    /// </summary>
    public Trip? Trip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static Reservation FromCoreEntity(CoreReservation entity)
    {
        var model = new Reservation();
        model.UserNumber = entity.UserNumber;
        model.UserName = entity.Username;
        model.Details = entity.Details;
        model.ReservationDate = entity.ReservationDate;
        model.HotelName = entity.HotelName;
        model.ReserveTime = entity.ReserveTime;
        model.TripId = 1;

        return model;
    }
}
