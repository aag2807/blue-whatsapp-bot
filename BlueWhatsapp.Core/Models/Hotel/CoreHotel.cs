namespace BlueWhatsapp.Core.Models;

public sealed class CoreHotel
{
    /// <summary>
    /// 
    /// </summary>
    public int Id { get; set; }
 
    /// <summary>
    /// Name of the hotel
    /// </summary>
    public string Name { get; set; } = string.Empty;
    
    /// <summary>
    /// Price for services related to this hotel
    /// </summary>
    public float Price { get; set; }
    
    /// <summary>
    /// Type of travel service provided to this hotel
    /// </summary>
    public string TravelType { get; set; } = string.Empty;
    
    /// <summary>
    /// Designated meeting point for pickups
    /// </summary>
    public string MeetingPoint { get; set; } = string.Empty;
    
    /// <summary>
    /// Currency used for pricing
    /// </summary>
    public string Currency { get; set; } = "USD";
    
    /// <summary>
    /// Route name/code associated with this hotel
    /// </summary>
    public string Route { get; set; } = string.Empty;
    
    /// <summary>
    /// Foreign key to the Route entity
    /// </summary>
    public int RouteId { get; set; }
    
    // /// <summary>
    // /// Navigation property to the related Route
    // /// </summary>
    // public Route RouteNavigation { get; set; }
    //
    // /// <summary>
    // /// Collection of schedules associated with this hotel through the junction table
    // /// </summary>
    // public ICollection<HotelSchedule> HotelSchedules { get; set; } = new List<HotelSchedule>();
    //
    // /// <summary>
    // /// Collection of schedules associated with this hotel
    // /// </summary>
    // public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>(); 
    
}