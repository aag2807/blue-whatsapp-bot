namespace BlueWhatsapp.Core.Models.Messages.Interactive;

public sealed class Section
{
    public string title { get; set; } = string.Empty;

    public List<Row> rows = new();
}