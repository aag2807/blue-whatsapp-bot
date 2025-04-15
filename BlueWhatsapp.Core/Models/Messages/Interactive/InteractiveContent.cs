namespace BlueWhatsapp.Core.Models.Messages.Interactive;

public class InteractiveContent
{
    public string type { get; set; } = "text";
    
    public string text { get; set; } = string.Empty;
}