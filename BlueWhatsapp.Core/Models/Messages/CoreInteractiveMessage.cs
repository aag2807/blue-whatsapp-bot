using BlueWhatsapp.Core.Models.Messages.Interactive;

namespace BlueWhatsapp.Core.Models.Messages;

public sealed class CoreInteractiveMessage : CoreBaseMessage
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public string recipient_type { get; set; } = "individual";

    public CoreInteractive interactive { get; set; } = new();

    public CoreInteractiveMessage(string number)
    {
        to = number;
        type = "InteractiveMessage";
    }
}