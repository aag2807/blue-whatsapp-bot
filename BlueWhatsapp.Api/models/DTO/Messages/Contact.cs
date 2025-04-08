namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Contact 
{
    /// <summary>
    /// The profile of the contact
    /// </summary>
    public Profile? Profile { get; set; }

    /// <summary>
    /// The WhatsApp ID of the contact
    /// </summary>
    public string? Wa_Id { get; set; }
}