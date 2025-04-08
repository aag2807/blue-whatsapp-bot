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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
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
}