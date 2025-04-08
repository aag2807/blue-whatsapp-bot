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
}

