using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
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
    public async Task GetRecentConversations(int count = 20)
    {
        IEnumerable<CoreConversationState> conversations = await _conversationStateRepository.GetAllConversationsAsync().ConfigureAwait(true);
        
        // Send the messages to the requesting client only
        await Clients.Caller.SendAsync("ReceiveRecentConversations", conversations).ConfigureAwait(true);
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
        IEnumerable<CoreConversationState> openChats = await _conversationStateRepository.GetPendingConversationsFromTodayAsync().ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveOpenChats", openChats).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Method that can be called by clients to get messages from a specific sender
    /// </summary>
    public async Task GetClosedMessages()
    {
        IEnumerable<CoreConversationState> closedChats = await _conversationStateRepository.GetCompletedConversationsFromTodayAsync().ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveClosedMessages", closedChats).ConfigureAwait(true);
    }

    public async Task GetAllConversations()
    {
        IEnumerable<Core.Models.CoreConversationState> allConversations = await _conversationStateRepository.GetAllConversationsAsync().ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveAllConversations", allConversations).ConfigureAwait(true);
    }

    public async Task GetWeeklyConversations()
    {
        IEnumerable<CoreConversationState> weeklyConversations = await _conversationStateRepository.GetAllConversationsThisWeekAsync().ConfigureAwait(true);
        await Clients.Caller.SendAsync("ReceiveWeeklyConversations", weeklyConversations).ConfigureAwait(true);
    }
    
    /// <summary>
    /// Override of OnConnectedAsync to send initial data when a client connects
    /// </summary>
    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync().ConfigureAwait(true);
    }
}