using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Models.Users;

public sealed class CoreUser : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public int? Id { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 
    /// </summary>
    public string Password { get; set; } = string.Empty;

    public static CoreUser FromRaw(string name, string number, string email, string password)
    {
        CoreUser user = new();
        user.Name = name;
        user.Email = email;
        user.Password = password;

        return user;
    }
}