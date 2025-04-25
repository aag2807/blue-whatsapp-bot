using System.ComponentModel.DataAnnotations.Schema;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

[Table("TripSchedules")]
public class TripSchedule : BaseEntity
{
    /// <summary>
    /// The ID of the trip
    /// </summary>
    public int TripId { get; set; }

    /// <summary>
    /// The ID of the schedule
    /// </summary>
    public int ScheduleId { get; set; }

    /// <summary>
    /// Navigation property to the Trip
    /// </summary>
    public Trip Trip { get; set; } = null!;

    /// <summary>
    /// Navigation property to the Schedule
    /// </summary>
    public Schedule Schedule { get; set; } = null!;
} 