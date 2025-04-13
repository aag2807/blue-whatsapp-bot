using System.ComponentModel.DataAnnotations.Schema;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

[Table("Trips")]
public sealed class Trip : BaseEntity
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
    /// The time of the trip
    /// </summary>
    public TimeSpan TripTime { get; set; } = TimeSpan.Zero;

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
    public Route Route { get; set; } = new Route();
}
