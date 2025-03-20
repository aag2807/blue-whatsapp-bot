using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueWhatsapp.Api.models;

/// <summary>
/// 
/// </summary>
public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    /// <summary>
    /// Leaves a trace of when the entity was created
    /// </summary>
    public DateTime CreateAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Leaves a trace of when the entity was last modified
    /// </summary>
    public DateTime ModifiedAt { get; set; } = DateTime.Now;
}