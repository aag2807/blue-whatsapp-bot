using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Users;

namespace BlueWhatsapp.Core.Services;

public interface IUserService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    Task<CoreUser?> Login(string email, string password);

    /// <summary>
    /// Creates a new user in the system
    /// </summary>
    /// <param name="user">The user to create</param>
    /// <returns>The created user</returns>
    Task<CoreUser> CreateUserAsync(CoreUser user);

    /// <summary>
    /// Deletes a user from the system
    /// </summary>
    /// <param name="id">The ID of the user to delete</param>
    /// <returns>True if the user was deleted successfully</returns>
    Task<bool> DeleteUserAsync(int id);
}

