namespace BlueWhatsapp.Core.Services;

public interface IWhatsappCloudService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public Task<bool> SendMessage<T>(T model);
}