
namespace BlueWhatsapp.Core.Models.Route;

public sealed class CoreRoute : BaseEntity
{
    public int Id { get; set; } 
    
    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public CoreRoute(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
