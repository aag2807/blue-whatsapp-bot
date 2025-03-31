namespace BlueWhatsapp.Core.Models.Messages;

/// <summary>
/// 
/// </summary>
public sealed class CoreMessage
{
    /// <summary>
    /// 
    /// </summary>
    public string messaging_product { get; set; } = "whatsapp";
    
    /// <summary>
    /// 
    /// </summary>
    public string to { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    public string type { get; set; } = "text";
    
    /// <summary>
    /// 
    /// </summary>
    public CoreText text { get; set; } = new();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="number"></param>
    public CoreMessage(string message, string number)
    {
        text.body = message;
        to = number;
    }
}