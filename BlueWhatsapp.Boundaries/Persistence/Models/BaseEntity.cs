using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// 
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Primary key with auto-incrementing behavior in SQLite
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
        
    /// <summary>
    /// Timestamp when the entity was created
    /// </summary>
    [Required]
    public DateTime CreatedTime { get; set; }
        
    /// <summary>
    /// Timestamp when the entity was last modified
    /// </summary>
    public DateTime? ModifiedTime { get; set; }
        
    /// <summary>
    /// Flag to indicate if the entity is active or soft-deleted
    /// </summary>
    public bool IsActive { get; set; } = true;
}