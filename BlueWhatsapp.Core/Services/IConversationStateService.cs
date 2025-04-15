using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Services;

/// <summary>
/// Defines the contract for managing the state of a conversation.
/// </summary>
public interface IConversationStateService
{
    /// <summary>
    /// Retrieves the conversation state associated with the provided phone number.
    /// </summary>
    /// <param name="number">The phone number of the user whose conversation state is to be fetched.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the <see cref="CoreConversationState"/> if found, or <c>null</c> if no state exists for the provided number.</returns>
    Task<CoreConversationState?> GetConversationStateByNumber(string number);

    /// <summary>
    /// Creates a new conversation state for the provided phone number.
    /// </summary>
    /// <param name="number">The phone number of the user for whom the new conversation state is to be created.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the newly created <see cref="CoreConversationState"/>.</returns>
    Task<CoreConversationState> CreateNewConversationState(string number);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    Task UpdateConversationState(CoreConversationState state);
}