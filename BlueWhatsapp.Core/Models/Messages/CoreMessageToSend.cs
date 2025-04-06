namespace BlueWhatsapp.Core.Models.Messages;

public class CoreMessageToSend
{
    /// <summary>
    /// Specifies the messaging platform product used for communication.
    /// Typically set to "whatsapp" to designate the WhatsApp messaging product.
    /// </summary>
    public string messaging_product { get; set; } = "whatsapp";

    /// <summary>
    /// Specifies the recipient's phone number to which the message will be sent.
    /// </summary>
    public string to { get; set; } = string.Empty;

    /// <summary>
    /// Indicates the type of message being sent (e.g., text, image, etc.).
    /// This property specifies the message format for the WhatsApp messaging platform.
    /// </summary>
    public string type { get; set; } = "text";

    /// <summary>
    /// Represents the text content of a message to be sent.
    /// </summary>
    public CoreText text { get; set; } = new();

    /// <summary>
    /// Represents a message to be sent via the WhatsApp messaging platform.
    /// </summary>
    public CoreMessageToSend(string message, string number)
    {
        text.body = message;
        to = number;
    }
}