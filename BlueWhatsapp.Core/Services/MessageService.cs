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
    
    async Task IMessageService.SaveAsync(string message, string number, MessageStatus status = MessageStatus.Pending)
    {
        Arguments.NotEmptyOrWhiteSpaceOnly(message, nameof(message));
        Arguments.NotEmptyOrWhiteSpaceOnly(number, nameof(number));

        CoreMessage messageToSave = new CoreMessage()
        {
            From = number,
            Body = message,
            Status = status
        };
        
        await _messageRepository.Persist(messageToSave).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageService.GetAllAsync()
    {
        return await _messageRepository.GetAllMessages().ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageService.GetAllByStatus(MessageStatus status)
    {
        State.IsFalse(status == MessageStatus.None, nameof(status));
        
        return await _messageRepository.GetMessagesByTypeAsync(status).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<IEnumerable<CoreMessage>> IMessageService.GetAllByPhoneNumber(string phoneNumber)
    {
        Arguments.NotEmptyOrWhiteSpaceOnly(phoneNumber, nameof(phoneNumber));
        return await _messageRepository.GetMessagesByPhoneNumber(phoneNumber).ConfigureAwait(true);
    }
}