using BlueWhatsapp.Core.Enums;

namespace BlueWhatsapp.Core.Models.Messages;

/// <summary>
/// 
/// </summary>
public sealed class CoreMessage : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public string From { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Body { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    public MessageStatus Status { get; set; } = MessageStatus.None;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <param name="number"></param>
    public CoreMessage FromRaw(string message, string number)
    {
        CoreMessage coreMessage = new();
        coreMessage.From = From;
        coreMessage.Body = message;

        return coreMessage;
    }
    
    public static CoreMessage Create<T>(T data) where T: class
    {
        return BaseEntity.Create<CoreMessage, T>(data);
    }
}