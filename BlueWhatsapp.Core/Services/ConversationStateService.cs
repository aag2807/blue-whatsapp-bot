using System.Formats.Tar;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Persistence;

namespace BlueWhatsapp.Core.Services;

/// <inheritdoc />
public sealed class ConversationStateService : IConversationStateService
{
    private readonly IConversationStateRepository _conversationStateRepository;

    /// <summary>
    /// Represents the state of a conversation, encapsulating the current step, collected data, last interaction timestamp,
    /// and various flags indicating the state of the conversation.
    /// </summary>
    public ConversationStateService(IConversationStateRepository conversationStateRepository)
    {
        _conversationStateRepository = conversationStateRepository;
    }

    /// <inheritdoc />
    async Task<CoreConversationState?> IConversationStateService.GetConversationStateByNumber(string number)
    {
        return await _conversationStateRepository.GetConversationStateByNumber(number).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task<CoreConversationState> IConversationStateService.CreateNewConversationState(string number)
    {
        CoreConversationState state = new CoreConversationState();
        state.UserNumber = number.Trim();
        state.CurrentStep = ConversationStep.Welcome;
        state.IsAdminOverridden = false;
        state.IsComplete = false;
        state.Flow = ConversationFlowEnum.DIRECT_CLIENT_FREE_ROUTE;

        return state;
    }

    /// <inheritdoc />
    async Task IConversationStateService.UpdateConversationState(CoreConversationState state)
    {
         await _conversationStateRepository.UpdateAsync(state).ConfigureAwait(true);
    }

    /// <inheritdoc />
    async Task IConversationStateService.AddAsync(CoreConversationState state)
    {
         await _conversationStateRepository.PersistAsync(state).ConfigureAwait(true);
    }
}