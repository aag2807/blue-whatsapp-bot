using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Users;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Triplex.Validations;

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
        catch (Exception)
        {
            return null;
        }
    }

    async Task<CoreUser> IUserService.CreateUserAsync(CoreUser user)
    {
        try
        {
            Arguments.NotNull(user, nameof(user));
            Arguments.NotEmptyOrWhiteSpaceOnly(user.Email, nameof(user.Email));
            Arguments.NotEmptyOrWhiteSpaceOnly(user.Password, nameof(user.Password));
            Arguments.NotEmptyOrWhiteSpaceOnly(user.Name, nameof(user.Name));

            // Check if user with same email already exists
            var existingUser = await _userRepository.GetUserByEmailAsync(user.Email).ConfigureAwait(true);
            if (existingUser != null)
            {
                throw new InvalidOperationException("A user with this email already exists");
            }

            // Hash the password before saving
            user.Password = PasswordUtils.HashPassword(user.Password);

            // Create the user
            return await _userRepository.CreateUserAsync(user).ConfigureAwait(true);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error creating user: {ex.Message}");
            throw;
        }
    }

    async Task<bool> IUserService.DeleteUserAsync(int id)
    {
        try
        {
            Arguments.GreaterThan(id, 0, nameof(id));

            // Check if user exists
            var users = await _userRepository.GetNonAdminUsers().ConfigureAwait(true);
            if (!users.Any(u => u.Id == id))
            {
                throw new InvalidOperationException("User not found");
            }

            return await _userRepository.DeleteUserAsync(id).ConfigureAwait(true);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error deleting user: {ex.Message}");
            throw;
        }
    }
}

