using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using System;
using System.Collections.Generic;

namespace BlueWhatsapp.Core.Models.Trip;

public sealed class CoreTrip : BaseEntity
{
    /// <summary>
    /// The id of the trip
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The name of the user
    /// </summary>
    public string TripName { get; set; } = string.Empty;

    /// <summary>
    /// The route of the trip   
    /// </summary>
    public CoreRoute? Route { get; set; }
    
    /// <summary>
    /// The schedules associated with this trip
    /// </summary>
    public ICollection<CoreSchedule> Schedules { get; set; } = new List<CoreSchedule>();

    /// <summary>
    /// Indicates whether the trip is active for a specific day
    /// </summary>
    public bool IsActiveForToday { get; set; } = true;
    
    /// <summary>
    /// The reservations for the trip
    /// </summary>
    public ICollection<CoreReservation> Reservations { get; set; } = new List<CoreReservation>();

    /// <summary>
    /// The maximum capacity of the trip
    /// </summary>
    public int MaxCapacity { get; set; } = 30;

    /// <summary>
    /// The current number of reservations for the trip
    /// </summary>
    public int CurrentReservations { get; set; }

    /// <summary>
    /// The remaining capacity for the trip
    /// </summary>
    public int RemainingCapacity => MaxCapacity - CurrentReservations;

    /// <summary>
    /// The hotels associated with the trip
    /// </summary>
    public ICollection<CoreHotel> Hotels { get; set; } = new List<CoreHotel>();
}
