namespace BlueWhatsapp.Core.Services;

public interface IConversationService
{
    /// <summary>
    /// Processes a user's message within the current conversation state and determines the appropriate response or action.
    /// </summary>
    /// <param name="userInput">The input message provided by the user.</param>
    /// <param name="userNumber">The unique identifier (e.g., phone number) associated with the user.</param>
    /// <returns>A task representing the asynchronous operation. The task's result contains the response message to be sent to the user.</returns>
    public Task<string> ProcessMessageAsync(string userInput, string userNumber);

    /// <summary>
    /// Enables or disables manual handling for a conversation associated with a specified user number.
    /// </summary>
    /// <param name="userNumber">The phone number of the user whose conversation will have its manual handling state updated.</param>
    /// <param name="enabled">Specifies whether manual handling is enabled or disabled for the conversation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task SetManualHandlingAsync(string userNumber, bool enabled);
}