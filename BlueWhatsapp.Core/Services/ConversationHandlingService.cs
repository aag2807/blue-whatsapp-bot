using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.State;
using BlueWhatsapp.Core.State.StateNodes;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.Services;

public sealed class ConversationHandlingService : IConversationHandlingService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppLogger _logger;
    private readonly Dictionary<ConversationStep, Type> _stateTypes;

    public ConversationHandlingService(IServiceProvider serviceProvider, IAppLogger logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
        _stateTypes = CreateStateTransitionDictionary();
    }
    
    async Task<CoreBaseMessage?> IConversationHandlingService.HandleState(CoreConversationState state, string userMessage)
    {
        return await HandleDirectClientFreeRoute(state, userMessage).ConfigureAwait(true);
    }

    private async Task<CoreBaseMessage?> HandleDirectClientFreeRoute(CoreConversationState state, string userMessage)
    {
        try
        {
            _logger.LogInfo($"HandleState: CurrentStep={state.CurrentStep}, UserMessage={userMessage}");

            // Reset to welcome state if state is None
            if (state.CurrentStep == ConversationStep.None)
            {
                state.CurrentStep = ConversationStep.Welcome;
            }

            // Process the current state
            return await ProcessState(state, userMessage);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex);
            _logger.LogError(ex.Data);
            _logger.LogError(state);

            return null;
        }
    }

    private async Task<CoreBaseMessage?> ProcessState(CoreConversationState state, string userMessage)
    {
        ConversationStep initialStep = state.CurrentStep;

        IConversationState? stateHandler = GetStateHandler(state.CurrentStep);
        if (stateHandler == null)
        {
            _logger.LogError($"No state handler found for state: {state.CurrentStep}");
            return null;

        }
        CoreBaseMessage? message = await stateHandler.Process(state, userMessage);

        if (state.CurrentStep != initialStep && message == null)
        {
            _logger.LogInfo($"State transitioned from {initialStep} to {state.CurrentStep}, continuing processing");
            return await ProcessState(state, "");
        }

        return message;
    }

    /// <summary>
    /// Creates an instance of the appropriate state handler.
    /// </summary>
    private IConversationState GetStateHandler(ConversationStep step)
    {
        try
        {
            if (!_stateTypes.TryGetValue(step, out var stateType))
            {
                _logger.LogInfo($"No state type registered for step: {step}");
                stateType = _stateTypes[ConversationStep.Welcome];
            }

            return (IConversationState)ActivatorUtilities.CreateInstance(_serviceProvider, stateType);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error creating state handler for step {step}: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Static method for create state transition dictionary.
    /// </summary>
    private static Dictionary<ConversationStep, Type> CreateStateTransitionDictionary()
    {
        return new Dictionary<ConversationStep, Type>
        {
            // initial states
            { ConversationStep.None, typeof(WelcomeState) },
            { ConversationStep.Welcome, typeof(WelcomeState) },
            { ConversationStep.LanguageSelection, typeof(LanguageSelectionState) },

            //date selection
            { ConversationStep.DateSelection, typeof(DateSelectionState) },

            // Location/hotel selection
            { ConversationStep.ZoneSelection, typeof(ZoneSelectionState) },
            { ConversationStep.ZoneSelectionResponse, typeof(ZoneSelectionResponseState) },
            { ConversationStep.ZoneUnknown, typeof(ZoneUnknownState) },
            { ConversationStep.HotelSelection, typeof(HotelSelectionState) },
            { ConversationStep.HotelUnknown, typeof(HotelUnknownState) },
            { ConversationStep.HotelConfirmation, typeof(HotelConfirmationState) },
            
            // Hotel matching states
            { ConversationStep.MoreThanOneMatchingHotel, typeof(MoreThanOneMatchingHotelState) },
            { ConversationStep.IsThisMatchingHotel, typeof(MoreThanOneMatchingHotelState) }, // Reuse for now
            { ConversationStep.NoMatchingHotel, typeof(ManualHandlingState) }, // Redirect to manual handling

            // Schedule and service type 
            { ConversationStep.ScheduleSelection, typeof(ScheduleSelectionState) },
            { ConversationStep.WillTextLater, typeof(WillTextLaterState) },
            { ConversationStep.VipServiceOffer, typeof(VipServiceOfferState) },
            { ConversationStep.VipServiceConfirmation, typeof(VipServiceConfirmationState) },
            { ConversationStep.VipGroupSizeSelection, typeof(VipGroupSizeSelectionState) },
            { ConversationStep.GroupSizeSelection, typeof(VipGroupSizeSelectionState) }, // For Bayahibe

            // User information collection
            { ConversationStep.AskForFullName, typeof(AskForFullNameState) },
            { ConversationStep.AskForRoomNumber, typeof(AskForRoomNumberState) },
            { ConversationStep.AskForAdults, typeof(AskForAdultsState) },
            { ConversationStep.AskForChildren, typeof(AskForChildrenState) },
            { ConversationStep.AskForPhone, typeof(AskForPhoneState) },
            { ConversationStep.AskForEmail, typeof(AskForEmailState) },

            // Conversation ending states
            { ConversationStep.ReservationComplete, typeof(ReservationCompleteState) },
            { ConversationStep.PendingDecision, typeof(PendingDecisionState) },

            // admin override state
            { ConversationStep.ManualHandling, typeof(ManualHandlingState) },
        };
    }
}