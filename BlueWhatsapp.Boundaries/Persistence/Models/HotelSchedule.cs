using System.ComponentModel.DataAnnotations.Schema;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// Junction entity to link Hotels with their Schedules
/// </summary>
[Table("HotelSchedules")]
public sealed class HotelSchedule : BaseEntity
{
    /// <summary>
    /// Foreign key to the Hotel entity
    /// </summary>
    public int HotelId { get; set; }
    
    /// <summary>
    /// Foreign key to the Schedule entity
    /// </summary>
    public int ScheduleId { get; set; }
    
    /// <summary>
    /// Pickup number (1-5) this schedule represents for this hotel
    /// </summary>
    public int RecogidaNumber { get; set; }
    
    /// <summary>
    /// Navigation property to the related Hotel
    /// </summary>
    [ForeignKey("HotelId")]
    public Hotel Hotel { get; set; }
    
    /// <summary>
    /// Navigation property to the related Schedule
    /// </summary>
    [ForeignKey("ScheduleId")]
    public Schedule Schedule { get; set; }
}