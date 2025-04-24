using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Models.Trip;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

[Table("Trips")]
public sealed class Trip : BaseEntity
{
    /// <summary>
    /// The name of the user    
    /// </summary>
    public string TripName { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether the trip is active for today  
    /// </summary>
    public bool IsActiveForToday { get; set; } = true;

    /// <summary>
    /// The id of the route associated with the trip
    /// </summary>
    [ForeignKey("Route")]
    public int RouteId { get; set; }

    /// <summary>
    /// The route of the trip
    /// </summary>
    [NotMapped]
    public Route? Route { get; set; }

    /// <summary>
    /// The schedules of the trip
    /// </summary>
    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
    
    /// <summary>
    /// The schedules of the trip
    /// </summary>
    public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
    
    /// <summary>
    /// The reservations for the trip
    /// </summary>
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    /// <summary>
    /// Converts the current entity to a CoreTrip
    /// </summary>
    /// <returns></returns>
    public CoreTrip ToCoreTrip()
    {
        var coreEntity = new CoreTrip
        {
            Id = Id,
            TripName = TripName,
            IsActiveForToday = IsActiveForToday,
        };

        if (Route != null)
        {
            coreEntity.Route = Route.ToCoreRoute();
        }

        return coreEntity;
    }
}
