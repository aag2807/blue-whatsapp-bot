using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Route;
using System;
using System.Collections.Generic;

namespace BlueWhatsapp.Core.Models.Schedule;

public sealed class CoreSchedule : BaseEntity
{
    /// <summary>
    /// The unique identifier for the schedule
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The name associated with this schedule
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Represents the specific time associated with the schedule.
    /// </summary>
    public string Time { get; set; } = "0:00";

    /// <summary>
    ///  The amount of related hotels to a given schedule.
    /// </summary>
    public int HotelCount { get; set;  } = 0 ;

    public CoreSchedule(int id, string name, string time, int hotelCount = 0)
    {
        Id = id;
        Name = name;
        Time = time;
        HotelCount = hotelCount;
    }
}
