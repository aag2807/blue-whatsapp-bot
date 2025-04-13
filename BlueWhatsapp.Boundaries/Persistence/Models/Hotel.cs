using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Models;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// Represents a hotel entity in the system
/// </summary>
[Table("Hotels")]
public sealed class Hotel : BaseEntity
{
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
    
    /// <summary>
    /// Navigation property to the related Route
    /// </summary>
    [ForeignKey("RouteId")]
    public Route? RouteNavigation { get; set; }
    
    /// <summary>
    /// Collection of schedules associated with this hotel through the junction table
    /// </summary>
    public ICollection<HotelSchedule> HotelSchedules { get; set; } = new List<HotelSchedule>();
    
    /// <summary>
    /// Collection of schedules associated with this hotel
    /// </summary>
    [NotMapped]
    public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    /// <summary>
    /// Converts a CoreHotel to a Hotel
    /// </summary>
    /// <param name="coreHotel"></param>
    /// <returns></returns>
    public static Hotel FromCoreHotel(CoreHotel coreHotel)
    {
        Arguments.NotNull(coreHotel, nameof(coreHotel));

        Hotel persistenceModel = new Hotel
        {
            Name = coreHotel.Name,
            Price = coreHotel.Price,
            TravelType = coreHotel.TravelType,
            MeetingPoint = coreHotel.MeetingPoint,
            Currency = coreHotel.Currency,
            Route = coreHotel.Route,
            RouteId = coreHotel.RouteId
        };

        return persistenceModel;
    }

    /// <summary>
    /// Converts a Hotel to a CoreHotel
    /// </summary>
    /// <returns></returns>
    public CoreHotel ToCoreHotel()
    {
        var hotel = new CoreHotel
        {
            Id = Id,
            Name = Name,
            Price = Price,
            TravelType = TravelType,
            MeetingPoint = MeetingPoint,
            Currency = Currency,
            Route = Route,
            RouteId = RouteId
        };

        if (RouteNavigation != null)
        {
            hotel.RouteNavigation = RouteNavigation.ToCoreRoute();
        }

        if (HotelSchedules != null && HotelSchedules.Any())
        {
            hotel.Schedules = HotelSchedules.Select(hs => hs.Schedule.ToCoreSchedule()).ToList();
        }

        return hotel;
    }
}