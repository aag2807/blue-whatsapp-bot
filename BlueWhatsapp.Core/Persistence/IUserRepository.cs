using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Users;

namespace BlueWhatsapp.Core.Persistence;

/// <summary>
/// 
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    Task<CoreUser?> GetUserByEmailAsync(string email);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<CoreUser>> GetNonAdminUsers();
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    Task UpdateUserAsync(CoreUser user);

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

    /// <summary>
    /// Updates a user's password
    /// </summary>
    /// <param name="userId">The ID of the user</param>
    /// <param name="newPassword">The new password to set</param>
    /// <returns>True if the password was updated successfully</returns>
    Task<bool> UpdatePasswordAsync(int userId, string newPassword);
}
