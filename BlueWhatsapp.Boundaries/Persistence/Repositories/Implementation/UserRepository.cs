using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Users;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }

    private static List<int> AdminIds => [1, 2];

    /// <inheritdoc />
    async Task<CoreUser?> IUserRepository.GetUserByEmailAsync(string email)
    {
        try 
        {
            Arguments.NotEmptyOrWhiteSpaceOnly(email, nameof(email));

            User? result = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email).ConfigureAwait(true);

            return result?.ToCoreUser();
        }
        catch (Exception ex)
        {
            _logger.LogError("Error al obtener el usuario por email");
            _logger.LogError(ex);
            throw;
        }
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreUser>> IUserRepository.GetNonAdminUsers()
    {
        List<User> result = await _dbSet.Where(user => !AdminIds.Contains(user.Id))
            .ToListAsync()
            .ConfigureAwait(true);

        return result.Select(x => x.ToCoreUser());
    }

    /// <inheritdoc />
    async Task IUserRepository.UpdateUserAsync(CoreUser user)
    {
        Arguments.NotNull(user, nameof(user));

        User model = await _dbSet.FirstOrDefaultAsync(model => model.Id == user.Id).ConfigureAwait(true)!;

        model.UpdateFromCore(user);

        await UpdateAsync(model, false).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<CoreUser> IUserRepository.CreateUserAsync(CoreUser user)
    {
        try
        {
            Arguments.NotNull(user, nameof(user));
            Arguments.NotEmptyOrWhiteSpaceOnly(user.Email, nameof(user.Email));
            Arguments.NotEmptyOrWhiteSpaceOnly(user.Password, nameof(user.Password));
            Arguments.NotEmptyOrWhiteSpaceOnly(user.Name, nameof(user.Name));

            // Check if user with same email already exists
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email).ConfigureAwait(true);
            if (existingUser != null)
            {
                throw new InvalidOperationException("A user with this email already exists");
            }

            // Convert CoreUser to User model
            User newUser = User.FromCoreUser(user);

            // Add the user using base repository method
            User createdUser = await AddAsync(newUser).ConfigureAwait(true);

            return createdUser.ToCoreUser();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error creating user: {ex.Message}");
            _logger.LogError(ex);
            throw;
        }
    }

    /// <inheritdoc />
    async Task<bool> IUserRepository.DeleteUserAsync(int id)
    {
        try
        {
            Arguments.GreaterThan(id, 0, nameof(id));

            if (AdminIds.Contains(id))
            {
                throw new InvalidOperationException("Cannot delete admin users");
            }

            return await HardDeleteAsync(id, false).ConfigureAwait(true);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error deleting user: {ex.Message}");
            _logger.LogError(ex);
            throw;
        }
    }
}