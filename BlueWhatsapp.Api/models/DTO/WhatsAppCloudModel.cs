using BlueWhatsapp.Api.models.DTO.Messages;

namespace BlueWhatsapp.Api.models.DTO;

/// <summary>
/// 
/// </summary>
public sealed class WhatsAppCloudModel
{
    /// <summary>
    /// 
    /// </summary>
    public List<Entry> Entry { get; set; } = Enumerable.Empty<Entry>().ToList();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Message? GetMessage()
    {
        return Entry[0]?.Changes[0]?.Value?.Messages[0];
    }

    public string GetFrom()
    {
        return Entry[0]?.Changes[0]?.Value?.Messages[0]?.From;
    }

    public string? GetMetadataPhoneNumberDisplay()
    {
        return Entry[0]?.Changes[0]?.Value?.Metadata.Display_Phone_Number;
    }
}