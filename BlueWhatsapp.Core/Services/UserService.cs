using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Users;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Services;

public sealed class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    async Task<CoreUser?> IUserService.Login(string email, string password)
    {
        CoreUser? user = await _userRepository.GetUserByEmailAsync(email).ConfigureAwait(true);
        if (user == null)
        {
            return null;
        }
        
        bool isValid = PasswordUtils.VerifyPassword(password, user.Password);
        if (!isValid)
        {
            return null;
        }

        return user;
    }
   
}

