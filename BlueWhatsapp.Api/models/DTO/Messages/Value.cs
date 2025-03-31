namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Value
{
    /// <summary>
    /// 
    /// </summary>
    public string? Messaging_Product { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public List<Message>? Messages { get; set; } = Enumerable.Empty<Message>().ToList();
}