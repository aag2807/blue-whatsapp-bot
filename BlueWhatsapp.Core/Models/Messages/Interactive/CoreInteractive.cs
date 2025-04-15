namespace BlueWhatsapp.Core.Models.Messages.Interactive;

public sealed class CoreInteractive
{
    public string type { get; set; } = "list";

    public InteractiveContent header { get; set; } = new();

    public InteractiveContent body { get; set; } = new();
    
    public Action action { get; set; } = new();
}