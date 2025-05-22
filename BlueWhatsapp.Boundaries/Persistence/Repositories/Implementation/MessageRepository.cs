using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

/// <summary>
/// Provides an implementation for handling persistence operations related to the `Message` entity.
/// </summary>
/// <remarks>
/// The `MessageRepository` class extends the base functionality provided by `BaseRepository`
/// to include methods for retrieving messages filtered by sender, type, or time.
/// It interacts with the database context to provide CRUD operations specific to the `Message` entity.
/// </remarks>
public sealed class MessageRepository : BaseRepository<Message>, IMessageRepository
{
    /// <summary>
    /// Provides data access methods specific to Message entities.
    /// </summary>
    /// <remarks>
    /// This repository extends the functionality of the BaseRepository class
    /// to include methods for retrieving messages by sender, type, or recent messages.
    /// </remarks>
    public MessageRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }
    
    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageRepository.GetMessagesByFromAsync(string from)
    {
        IEnumerable<Message> results = await FindAsync(m => m.From == from).ConfigureAwait(true);

        return results.Select(CoreMessage.Create<Message>);
    }
    
    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageRepository.GetMessagesByTypeAsync(MessageStatus status)
    {
        IEnumerable<Message> results = await FindAsync(m => m.Status == status);

        return results.Select(CoreMessage.Create<Message>);
    }
    
    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageRepository.GetRecentMessagesAsync(int count)
    {
        IEnumerable<Message> results =  await _dbSet
            .Where(m => m.IsActive)
            .OrderByDescending(m => m.CreatedTime)
            .Take(count)
            .ToListAsync();
        
        return results.Select(CoreMessage.Create<Message>);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageRepository.GetAllMessages()
    {
        IEnumerable<Message> results = await GetAllActiveAsync().ConfigureAwait(true) ;

        return results.Select(CoreMessage.Create<Message>);
    }

    /// <inheritdoc />
    async Task IMessageRepository.Persist(CoreMessage message)
    {
        Message persistenceMessage = Message.FromCore(message);
        
        await AddAsync(persistenceMessage).ConfigureAwait(true);
        
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<int> IMessageRepository.CountAsync()
    {
        return await _dbSet.CountAsync().ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageRepository.GetMessagesByPhoneNumber(string phoneNumber)
    {
        IEnumerable<Message> results = await _dbSet
            .Where(message => message.Number == phoneNumber)
            .ToListAsync()
            .ConfigureAwait(true);

        return results.Select(CoreMessage.Create<Message>);
    }
}