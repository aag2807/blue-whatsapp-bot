
using System.ComponentModel.DataAnnotations.Schema;

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
    /// The id of the trip associated with the reservation
    /// </summary>
    [ForeignKey("Trip")]
    public int TripId { get; set; }

    /// <summary>
    /// The trip associated with the reservation
    /// </summary>
    public Trip Trip { get; set; } = new Trip();
}
