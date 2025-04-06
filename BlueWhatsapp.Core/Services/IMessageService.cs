using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.Services;

public interface IMessageService
{
    /// <summary>
    /// Asynchronously saves the specified message to the data store.
    /// </summary>
    /// <param name="message">The message object to be saved. Cannot be null.</param>
    /// <returns>A task representing the asynchronous save operation.</returns>
    Task SaveAsync(CoreMessage message);

    /// <summary>
    /// Asynchronously saves the specified message text and recipient's number to the data store.
    /// </summary>
    /// <param name="message">The text of the message to be saved. Cannot be null or empty.</param>
    /// <param name="number">The recipient's phone number associated with the message. Cannot be null or empty.</param>
    /// <returns>A task representing the asynchronous save operation.</returns>
    Task SaveAsync(string message, string number);

    /// <summary>
    /// Retrieves all messages asynchronously.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation. The task result contains a collection of CoreMessage objects.
    /// </returns>
    Task<IEnumerable<CoreMessage>> GetAllAsync();

    /// <summary>
    /// Retrieves all messages with the specified status asynchronously.
    /// </summary>
    /// <param name="status">The status of the messages to retrieve. Must not be <c>MessageStatus.None</c>.</param>
    /// <returns>A task representing the asynchronous operation. The task result contains a collection of CoreMessage objects that match the specified status.</returns>
    Task<IEnumerable<CoreMessage>> GetAllByStatus(MessageStatus status);
}