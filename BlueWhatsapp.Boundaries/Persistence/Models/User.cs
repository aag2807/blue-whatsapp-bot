using System.ComponentModel.DataAnnotations.Schema;
using BlueWhatsapp.Boundaries.Persistence.Migrations;
using BlueWhatsapp.Core.Models.Users;
using BlueWhatsapp.Core.Utils;

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
        CoreUser user = CoreUser.FromRaw(Name, Email, Email, Password);
        user.Id = Id;
        
        return user;
    }

    public void UpdateFromCore(CoreUser coreUser)
    {
        Name = coreUser.Name;
        Email = coreUser.Email;
        if (!PasswordUtils.VerifyPassword(coreUser.Password, Password))
        {
            Password = PasswordUtils.HashPassword(Password);
        }
    }
}
    