using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Boundaries.Persistence.Migrations;
using BlueWhatsapp.Core.Models.Users;

namespace BlueWhatsapp.Boundaries.Persistence.Models;

/// <summary>
/// 
/// </summary>
[Table("Users")]

public sealed class User : BaseEntity
{
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

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static User FromCoreUser(CoreUser coreUser)
    {
        return new User
        {
            Name = coreUser.Name,
            Email = coreUser.Email,
            Password = coreUser.Password
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public CoreUser ToCoreUser()
    {
        return CoreUser.FromRaw(Name, Email, Email, Password);
    }
}
    