using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Models.Route;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// Represents a route entity in the system
/// </summary>
[Table("Routes")]
public sealed class Route : BaseEntity
{
    /// <summary>
    /// Name of the route
    /// </summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Description of the route
    /// </summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>
    /// Collection of hotels associated with this route
    /// </summary>
    public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    /// <summary>
    /// Converts the current entity to a CoreRoute
    /// </summary>
    /// <returns></returns>
    public CoreRoute ToCoreRoute()
    {
        return new CoreRoute(Id, Name, Description);
    }
}