using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Users;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Services;

public sealed class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IAppLogger _logger;

    public UserService(IUserRepository userRepository, IAppLogger logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    async Task<CoreUser?> IUserService.Login(string email, string password)
    {
        try
        {
            CoreUser? user = await _userRepository.GetUserByEmailAsync(email).ConfigureAwait(true);
            _logger.LogRoutes(email);
            _logger.LogRoutes(user);
            if (user == null)
            {
                return null;
            }
        
            bool isValid = PasswordUtils.VerifyPassword(password, user.Password);
            _logger.LogRoutes(isValid);
            _logger.LogRoutes(password);
            if (!isValid)
            {
                return null;
            }

            return user;
        }
        catch (Exception e)
        {
            return null;
        }
    }
}

