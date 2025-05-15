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
[Table("ConversationState")]
public sealed class ConversationState : BaseEntity
{
    /// <summary>
    /// Gets or sets the conversation flow type that determines the path of interaction.
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
    /// Gets or sets the identifier for the zone or area related to the conversation.
    /// </summary>
    [MaxLength(120)]
    public string ZoneId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the identifier for the hotel associated with the conversation.
    /// </summary>
    [MaxLength(120)]
    public string HotelId { get; set; }  = string.Empty;
        
    /// <summary>
    /// Gets or sets the identifier for the language preference of the user.
    /// </summary>
    [MaxLength(120)]
    public string LanguageId { get; set; } = string.Empty;
        
    /// <summary>
    /// Gets or sets the selected date for pick-up or service.
    /// </summary>
    [MaxLength(120)]
    public string PickUpDate { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the full name of the user or customer.
    /// </summary>
    [MaxLength(60)]
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the room number where the user is staying.
    /// </summary>
    [MaxLength(60)]
    public string RoomNumber { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the email address of the user for communication purposes.
    /// </summary>
    [MaxLength(60)]
    public string Email { get; set; } = string.Empty;
    
    /// <summary> 
    /// extra information
    /// </summary>
    [MaxLength(500)]
    public string ExtraInformation { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the number of adults included in the reservation or service.
    /// </summary>
    [Column("Adults")]
    public int Adults { get; set; } = 0;
    
    /// <summary>
    /// Gets or sets the number of children included in the reservation or service.
    /// </summary>
    [Column("Children")]

    public int Children { get; set; } = 0;

    /// <summary>
    /// Gets or sets the identifier for the selected schedule or time slot.
    /// </summary>
    [MaxLength(120)]
    public string ScheduleId { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the name of the contact person if different from the user.
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