using System.ComponentModel.DataAnnotations.Schema;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// 
/// </summary>
[Table("Schedules")]
public sealed class Schedule : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Time { get; set; } = "0:00";
    
    /// <summary>
    /// Collection of hotel schedules associated with this schedule
    /// </summary>
    public ICollection<HotelSchedule> HotelSchedules { get; set; } = new List<HotelSchedule>();
}