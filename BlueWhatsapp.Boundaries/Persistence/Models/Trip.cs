using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Models.Trip;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

[Table("Trips")]
public sealed class Trip : BaseEntity
{
    /// <summary>
    /// The name of the trip    
    /// </summary>
    public string TripName { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether the trip is active for today  
    /// </summary>
    public bool IsActiveForToday { get; set; } = true;

    /// <summary>
    /// The maximum capacity of the trip
    /// </summary>
    public int MaxCapacity { get; set; } = 30;

    /// <summary>
    /// The current number of reservations for the trip
    /// </summary>
    [NotMapped]
    public int CurrentReservations { get; set; }

    /// <summary>
    /// The remaining capacity of the trip
    /// </summary>
    [NotMapped]
    public int RemainingCapacity => MaxCapacity - CurrentReservations;

    /// <summary>
    /// The id of the route associated with the trip
    /// </summary>
    [ForeignKey("Route")]
    public int RouteId { get; set; }

    /// <summary>
    /// The route of the trip
    /// </summary>
    public Route? Route { get; set; }
    
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
            MaxCapacity = MaxCapacity,
            CurrentReservations = CurrentReservations
        };

        if (Route != null)
        {
            coreEntity.Route = Route.ToCoreRoute();
        }

        // Map schedules from hotels through route
        if (Route?.Hotels != null)
        {
            coreEntity.Schedules = Route.Hotels
                .SelectMany(h => h.HotelSchedules)
                .Select(hs => hs.Schedule.ToCoreSchedule())
                .Distinct()
                .ToList();
        }

        return coreEntity;
    }
}
