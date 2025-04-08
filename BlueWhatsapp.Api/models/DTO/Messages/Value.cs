namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Value
{
    /// <summary>
    /// The messaging product being used, typically "whatsapp"
    /// </summary>
    public string? Messaging_Product { get; set; }

    /// <summary>
    /// Metadata about the message
    /// </summary>
    public Metadata? Metadata { get; set; }

    /// <summary>
    /// The contacts in the conversation
    /// </summary>
    public List<Contact> Contacts {get; set;} = Enumerable.Empty<Contact>().ToList();
    
    /// <summary>
    /// The messages in the conversation
    /// </summary>
    public List<Message>? Messages { get; set; } = Enumerable.Empty<Message>().ToList();
}