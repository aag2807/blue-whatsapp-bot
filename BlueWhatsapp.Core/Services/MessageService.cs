using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using Triplex.Validations;

namespace BlueWhatsapp.Core.Services;

/// <inheritdoc />
public sealed class MessageService : IMessageService
{
    private readonly IMessageRepository _messageRepository;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="messageRepository"></param>
    public MessageService(IMessageRepository messageRepository)
    {
        _messageRepository = messageRepository;
    }
    
    /// <inheritdoc />
    async Task IMessageService.SaveAsync(CoreMessage message)
    {
        Arguments.NotNull(message, nameof(message));

        await _messageRepository.Persist(message).ConfigureAwait(true);
    }
    
    async Task IMessageService.SaveAsync(string from,string message, string number, MessageStatus status)
    {
        Arguments.NotEmptyOrWhiteSpaceOnly(message, nameof(message));
        Arguments.NotEmptyOrWhiteSpaceOnly(number, nameof(number));

        CoreMessage messageToSave = new()
        {
            Number = number,
            From = from,
            Body = message,
            Status = status
        };
        
        await _messageRepository.Persist(messageToSave).ConfigureAwait(true);
    }

    /// <summary>
    /// Convenience method with default status
    /// </summary>
    public async Task SaveAsync(string from, string message, string number)
    {
        await ((IMessageService)this).SaveAsync(from, message, number, MessageStatus.Pending).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageService.GetAllAsync()
    {
        return await _messageRepository.GetAllMessages().ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageService.GetAllByStatus(MessageStatus status)
    {
        return await _messageRepository.GetMessagesByTypeAsync(status).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageService.GetAllByPhoneNumber(string phoneNumber)
    {
        Arguments.NotEmptyOrWhiteSpaceOnly(phoneNumber, nameof(phoneNumber));
        return await _messageRepository.GetMessagesByPhoneNumber(phoneNumber).ConfigureAwait(true);
    }
}