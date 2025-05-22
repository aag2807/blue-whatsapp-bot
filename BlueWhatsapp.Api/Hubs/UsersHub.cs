using BlueWhatsapp.Core.Models.Users;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Services;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace BlueWhatsapp.Api.Hubs;

public sealed class UsersHub : Hub
{
    private readonly IUserService _userService;
    private readonly IUserRepository _userRepository;

    public UsersHub(IUserService userService, IUserRepository userRepository)
    {
        _userService = userService;
        _userRepository = userRepository;
    }

    public async Task GetAllUsers()
    {
        IEnumerable<CoreUser> users = await _userRepository.GetNonAdminUsers().ConfigureAwait(true);

        await Clients.All.SendAsync("ReceiveUsers", users).ConfigureAwait(true);
    }

    public async Task UpdateUser(CoreUser user)
    {
        await _userRepository.UpdateUserAsync(user).ConfigureAwait(true);

        IEnumerable<CoreUser> users = await _userRepository.GetNonAdminUsers().ConfigureAwait(true);

        await Clients.All.SendAsync("ReceiveUsers", users).ConfigureAwait(true);
    }

    public async Task CreateUser(CoreUser user)
    {
        try
        {
            await _userService.CreateUserAsync(user).ConfigureAwait(true);
            
            IEnumerable<CoreUser> users = await _userRepository.GetNonAdminUsers().ConfigureAwait(true);
            await Clients.All.SendAsync("ReceiveUsers", users).ConfigureAwait(true);
        }
        catch (Exception ex)
        {
            await Clients.Caller.SendAsync("Error", ex.Message).ConfigureAwait(true);
        }
    }

    public async Task DeleteUser(int id)
    {
        try
        {
            bool success = await _userService.DeleteUserAsync(id).ConfigureAwait(true);
            
            if (success)
            {
                IEnumerable<CoreUser> users = await _userRepository.GetNonAdminUsers().ConfigureAwait(true);
                await Clients.All.SendAsync("ReceiveUsers", users).ConfigureAwait(true);
            }
            else
            {
                await Clients.Caller.SendAsync("Error", "Failed to delete user").ConfigureAwait(true);
            }
        }
        catch (Exception ex)
        {
            await Clients.Caller.SendAsync("Error", ex.Message).ConfigureAwait(true);
        }
    }

    public async Task UpdatePassword(string newPassword, int userId)
    {
        try
        {
            bool success = await _userRepository.UpdatePasswordAsync(userId, newPassword).ConfigureAwait(true);
            if (success)
            {
                await Clients.Caller.SendAsync("Success", "Password updated successfully").ConfigureAwait(true);
            }
            else
            {
                await Clients.Caller.SendAsync("Error", "Failed to update password").ConfigureAwait(true);
            }
        }
        catch (Exception ex)
        {
            await Clients.Caller.SendAsync("Error", ex.Message).ConfigureAwait(true);
        }
    }
}