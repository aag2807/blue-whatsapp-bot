namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Interactive
{
    /// <summary>
    /// 
    /// </summary>
    public string? Type { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public ListReply? List_Reply { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public ButtonReply? Button_Reply { get; set; }  
}