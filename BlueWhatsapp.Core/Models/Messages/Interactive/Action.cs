namespace BlueWhatsapp.Core.Models.Messages.Interactive;

public sealed class Action
{
    public string button { get; set; } = string.Empty;
    
    public List<Section> sections { get; set; } = new();
}