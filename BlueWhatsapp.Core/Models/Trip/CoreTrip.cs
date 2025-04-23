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
    /// The schedule of the trip
    /// </summary>
    public CoreSchedule? Schedule { get; set; }

    /// <summary>
    /// Indicates whether the trip is active for a specific day
    /// </summary>
    public bool IsActiveForToday { get; set; } = true;
    
    /// <summary>
    /// The reservations for the trip
    /// </summary>
    public ICollection<CoreReservation> Reservations { get; set; } = new List<CoreReservation>();
}
