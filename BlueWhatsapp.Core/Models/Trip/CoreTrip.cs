using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Route;
using System;
using System.Collections.Generic;

namespace BlueWhatsapp.Core.Models.Trip;

public sealed class CoreTrip : BaseEntity
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
    /// The route of the trip   
    /// </summary>
    public CoreRoute? Route { get; set; }
    
    /// <summary>
    /// Time of day when the trip occurs (same time every day)
    /// </summary>
    public TimeSpan TripTime { get; set; } = TimeSpan.Zero;

    /// <summary>
    /// Indicates whether the trip is active for a specific day
    /// </summary>
    public bool IsActiveForToday { get; set; } = true;

    /// <summary>
    /// The reservations for the trip
    /// </summary>
    public ICollection<CoreReservation> Reservations { get; set; } = new List<CoreReservation>();
}
