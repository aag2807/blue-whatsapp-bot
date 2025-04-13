using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// Represents a schedule entity used to define specific time slots and related information.
/// </summary>
[Table("Schedules")]
public sealed class Schedule : BaseEntity
{
    /// <summary>
    /// The name associated with this schedule
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Represents the specific time associated with the schedule.
    /// </summary>
    public string Time { get; set; } = "0:00";
    
    /// <summary>
    /// Collection of hotel schedules associated with this schedule
    /// </summary>
    public ICollection<HotelSchedule> HotelSchedules { get; set; } = new List<HotelSchedule>();

    /// <summary>
    /// Converts a Schedule to a CoreSchedule
    /// </summary>
    /// <returns></returns>
    public CoreSchedule ToCoreSchedule()
    {
        return new CoreSchedule(Id, Name, Time);
    }
}