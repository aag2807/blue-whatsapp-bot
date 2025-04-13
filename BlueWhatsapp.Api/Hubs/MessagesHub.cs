using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using Microsoft.AspNetCore.SignalR;

namespace BlueWhatsapp.Api.Hubs;

public class MessagesHub : Hub
{
    private readonly IMessageRepository _messageRepository;
    private readonly IConversationStateRepository _conversationStateRepository;


    /// <summary>
    /// Hub class facilitating real-time communication between clients and the server for managing and retrieving messages.
    /// </summary>
    public MessagesHub(IMessageRepository messageRepository, IConversationStateRepository conversationStateRepository)
    {
        _messageRepository = messageRepository;
        _conversationStateRepository = conversationStateRepository;
    }

    /// <summary>
    /// Method that can be called from the client to get recent messages
    /// </summary>
    public async Task GetRecentMessages(int count = 20)
    {
        IEnumerable<CoreMessage> messages = await _messageRepository.GetRecentMessagesAsync(count).ConfigureAwait(true);
        
        // Send the messages to the requesting client only
        await Clients.Caller.SendAsync("ReceiveRecentMessages", messages).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Method called by the repository when a new message is added
    /// </summary>
    public async Task NewWhatsAppMessage(string from, string body, string timestamp)
    {
        await Clients.All.SendAsync("ReceiveWhatsAppMessage", from, body, timestamp).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Method that can be called by clients to get messages from a specific sender
    /// </summary>
    public async Task GetMessagesByFrom(string from)
    {
        IEnumerable<CoreMessage> messages = await _messageRepository.GetMessagesByFromAsync(from).ConfigureAwait(true);
        
        await Clients.Caller.SendAsync("ReceiveMessageHistory", from, messages).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Method that can be called by clients to get messages from a specific sender
    /// </summary>
    public async Task GetPendingMessages()
    {
        IEnumerable<CoreMessage> openChats = await _messageRepository.GetMessagesByTypeAsync(MessageStatus.Pending).ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveOpenChats", openChats).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Method that can be called by clients to get messages from a specific sender
    /// </summary>
    public async Task GetClosedMessages()
    {
        IEnumerable<CoreMessage> completedChats = await _messageRepository.GetMessagesByTypeAsync(MessageStatus.Completed).ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveClosedMessages", completedChats).ConfigureAwait(true);
    }

    public async Task GetAllConversations()
    {
        IEnumerable<Core.Models.CoreConversationState> allConversations = await _conversationStateRepository.GetAllConversationsAsync().ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveAllConversations", allConversations).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Override of OnConnectedAsync to send initial data when a client connects
    /// </summary>
    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync().ConfigureAwait(true);
    }
}