using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.State;

public class ConversationStateMachine
{
    private readonly Dictionary<ConversationStep, IConversationState> _states = new();
    private readonly IAppLogger _logger;

    public ConversationStateMachine(IAppLogger logger, params IConversationState[] states)
    {
        this._logger = logger;

        foreach (IConversationState state in states)
        {
            this._states[state.StateId] = state;
        }
    }

    public async Task<CoreBaseMessage?> ProcessMessage(CoreConversationState context, string userMessage)
    {
        try
        {
            if (!_states.TryGetValue(context.CurrentStep, out var currentState))
            {
                _logger.LogError($"No handler found for state: {context.CurrentStep}. Defaulting to Welcome.");
                context.CurrentStep = ConversationStep.Welcome;
                currentState = _states[ConversationStep.Welcome];
            }

            _logger.LogInfo($"Processing message in state: {context.CurrentStep}");

            CoreBaseMessage? message = await currentState.Process(context, userMessage);

            _logger.LogInfo($"Transitioned to state: {context.CurrentStep}");

            return message;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error processing message: {ex.Message}");
            _logger.LogError(ex);

            return null;
        }
    }
}