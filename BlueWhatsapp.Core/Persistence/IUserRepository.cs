using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Users;

namespace BlueWhatsapp.Core.Persistence;

public interface IUserRepository
{
    Task<CoreUser?> GetUserByEmailAsync(string email);
}
