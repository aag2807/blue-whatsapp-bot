using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// Represents the state of an ongoing conversation, including its current step,
/// associated user, collected data, and other pertinent attributes.
/// </summary>
[Table("ConversationStates")]
public sealed class ConversationState : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public ConversationFlowEnum Flow { get; set; } = ConversationFlowEnum.None;
    
    /// <summary>
    /// Gets or sets the user's phone number associated with the conversation.
    /// </summary>
    [MaxLength(30)]
    public string UserNumber { get; set; } = string.Empty; 

    /// <summary>
    /// Gets or sets the current step of the conversation process.
    /// </summary>
    public ConversationStep CurrentStep { get; set; } = ConversationStep.None;

    /// <summary>
    /// Gets or sets a value indicating whether the admin override functionality has been applied to the conversation state.
    /// </summary>
    public bool IsAdminOverridden { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the conversation process has been completed.
    /// </summary>
    public bool IsComplete { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    [MaxLength(120)]
    public string ZoneId { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    [MaxLength(120)]
    public string HotelId { get; set; }  = string.Empty;
        
    /// <summary>
    /// 
    /// </summary>
    [MaxLength(120)]
    public string LanguageId { get; set; } = string.Empty;
        
    /// <summary>
    /// 
    /// </summary>
    [MaxLength(120)]
    public string PickUpDate { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    [MaxLength(520)]
    public string ReservationDetails { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    [MaxLength(120)]
    public string ScheduleId { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    [MaxLength(120)]
    public string PersonName { get; set; } = string.Empty;

    /// <summary>
    /// Converts an instance of <see cref="CoreConversationState"/> to an instance of <see cref="ConversationState"/>.
    /// </summary>
    /// <param name="state">The source <see cref="CoreConversationState"/> instance to be converted.</param>
    /// <returns>A new <see cref="ConversationState"/> instance with properties mapped from the provided <see cref="CoreConversationState"/>.</returns>
    public static ConversationState FromCore(CoreConversationState state)
    {
        return PropertyMapper.MapTo<CoreConversationState, ConversationState>(state);
    }
}