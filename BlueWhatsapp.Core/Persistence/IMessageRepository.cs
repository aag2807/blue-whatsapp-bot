using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.Persistence;

public interface IMessageRepository
{
    /// <summary>
    /// Asynchronously retrieves messages from the repository that match the specified sender.
    /// </summary>
    /// <param name="from">The sender's identifier to filter messages by.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a collection of messages from the specified sender.</returns>
    Task<IEnumerable<CoreMessage>> GetMessagesByFromAsync(string from);

    /// <summary>
    /// Retrieves messages filtered by their status.
    /// </summary>
    /// <param name="status">The status of the messages to retrieve.</param>
    /// <returns>Returns a collection of messages that match the specified status.</returns>
    Task<IEnumerable<CoreMessage>> GetMessagesByTypeAsync(MessageStatus status);

    /// <summary>
    /// Asynchronously retrieves the most recent messages from the repository.
    /// </summary>
    /// <param name="count">The maximum number of recent messages to retrieve.</param>
    /// <returns>Returns a task that represents the asynchronous operation, containing a collection of recent messages.</returns>
    Task<IEnumerable<CoreMessage>> GetRecentMessagesAsync(int count);

    /// <summary>
    /// Retrieves all messages from the repository.
    /// </summary>
    /// <returns>Returns a collection of all messages as a task result.</returns>
    Task<IEnumerable<CoreMessage>> GetAllMessages();

    /// <summary>
    /// Asynchronously persists a message into the repository.
    /// </summary>
    /// <param name="message">The message to be persisted.</param>
    /// <returns>Returns a task representing the asynchronous operation.</returns>
    Task Persist(CoreMessage message);

    /// <summary>
    /// Asynchronously counts the total number of messages in the repository.
    /// </summary>
    /// <returns>Returns the total count of messages as a task result.</returns>
    Task<int> CountAsync();
}