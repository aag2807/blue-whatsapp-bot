namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Entry
{
    /// <summary>
    /// 
    /// </summary>
    public string Id { get; set; } = string.Empty;
    
    /// <summary>
    /// 
    /// </summary>
    public List<Change>? Changes { get; set; }  = Enumerable.Empty<Change>().ToList();
}