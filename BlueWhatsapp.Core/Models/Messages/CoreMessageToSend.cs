namespace BlueWhatsapp.Core.Models.Messages;

public class CoreMessageToSend : CoreBaseMessage
{
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
        type = "text";
    }
}