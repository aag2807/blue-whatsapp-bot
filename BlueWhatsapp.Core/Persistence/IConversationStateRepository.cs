using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Persistence;

public interface IConversationStateRepository
{
    /// <summary>
    /// Retrieves the conversation state associated with a specific phone number.
    /// </summary>
    /// <param name="number">The phone number for which the conversation state needs to be retrieved.</param>
    /// <returns>A task representing the asynchronous operation, containing the conversation state corresponding to the specified phone number.</returns>
    public Task<CoreConversationState?> GetConversationStateByNumber(string number);

    /// <summary>
    /// Persists a conversation state asynchronously to a storage medium.
    /// </summary>
    /// <param name="state">The conversation state object to be persisted.</param>
    /// <returns>A task that represents the asynchronous operation of saving the conversation state.</returns>
    public Task PersistAsync(CoreConversationState state);

    /// <summary>
    /// Updates the conversation state with the provided state object.
    /// </summary>
    /// <param name="state">The conversation state object to be updated.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task UpdateAsync(CoreConversationState state);

    /// <summary>
    /// Retrieves all conversation states asynchronously.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of all conversation states.</returns>
    public Task<IEnumerable<CoreConversationState>> GetAllConversationsAsync();

    /// <summary>
    /// Retrieves the most recent conversation states asynchronously.
    /// </summary>  
    /// <param name="count">The number of recent conversations to retrieve.</param>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of the most recent conversation states.</returns>
    public Task<IEnumerable<CoreConversationState>> GetRecentConversationsAsync(int count = 20);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<CoreConversationState>> GetPendingConversationsFromTodayAsync();
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<CoreConversationState>> GetCompletedConversationsFromTodayAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Task<IEnumerable<CoreConversationState>> GetAllConversationsThisWeekAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Task MarkConversationAsManuallyOverridenAsync(int conversationId);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="conversationId"></param>
    /// <returns></returns>
    public Task<CoreConversationState> GetConversationStateById(int conversationId);
}