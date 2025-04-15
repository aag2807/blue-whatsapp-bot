using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;

namespace BlueWhatsapp.Core.Services;

public interface IWhatsappCloudService
{
    /// <summary>
    /// Sends a message using the WhatsApp Cloud API.
    /// </summary>
    /// <typeparam name="T">The type of the model being sent in the message request payload.</typeparam>
    /// <param name="model">The model containing the message data to be sent.</param>
    /// <returns>A task that represents the asynchronous operation, containing a boolean value indicating whether the message was sent successfully.</returns>
    public Task<bool> SendMessage<T>(T model);
}