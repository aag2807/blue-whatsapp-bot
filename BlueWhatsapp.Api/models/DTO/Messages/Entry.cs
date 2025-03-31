namespace BlueWhatsapp.Api.models.DTO.Messages;

public class Entry
{
    /// <summary>
    /// 
    /// </summary>
    public List<Change>? Changes { get; set; }  = Enumerable.Empty<Change>().ToList();
}