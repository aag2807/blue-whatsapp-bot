using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Persistence;
using Newtonsoft.Json.Linq;

namespace BlueWhatsapp.Core.Services;

public sealed class ConversationService : IConversationService
{
    private readonly IConversationFlowService _flowService;
    private readonly IConversationStateRepository _stateRepository;
    private readonly Dictionary<string, Dictionary<string, string>> _userDataStore = new();

    /// <summary>
    /// Provides services for managing user conversation flows and state persistence.
    /// </summary>
    public ConversationService(IConversationFlowService flowService, IConversationStateRepository stateRepository)
    {
        _flowService = flowService;
        _stateRepository = stateRepository;
    }

    /// <inheritdoc />
    async Task<string> IConversationService.ProcessMessageAsync(string userInput, string userNumber)
    {
        // Get or create conversation state
        var state = await _stateRepository.GetConversationStateByNumber(userNumber);

        if (state == null)
        {
            // New conversation
            state = new CoreConversationState()
            {
                UserNumber = userNumber,
                CurrentStep = ConversationStep.Welcome,
                IsAdminOverridden = false,
                IsComplete = false
            };

            await _stateRepository.PersistAsync(state);

            // Initialize user data store
            _userDataStore[userNumber] = new Dictionary<string, string>();

            // Return welcome message
            return _flowService.GetResponseForStep(ConversationStep.Welcome);
        }

        // Check if this conversation is manually handled by admin
        if (state.IsAdminOverridden)
        {
            // Skip processing for admin-handled conversations
            return null; // Return null to indicate no auto-response should be sent
        }

        // Ensure user data dictionary exists
        if (!_userDataStore.ContainsKey(userNumber))
        {
            _userDataStore[userNumber] = new Dictionary<string, string>();
        }

        // Store user input for current step
        StoreUserInput(userNumber, state.CurrentStep, userInput);

        // Validate input if needed
        if (!_flowService.ValidateInput(state.CurrentStep, userInput, out string errorMessage))
        {
            return errorMessage;
        }

        // Determine next step based on current step and user input
        ConversationStep nextStep = _flowService.GetNextStep(state.CurrentStep, userInput);

        // Update state with new step
        state.CurrentStep = nextStep;
        await _stateRepository.UpdateAsync(state);

        // Special processing for certain steps that need dynamic content
        switch (nextStep)
        {
            case ConversationStep.FreeRouteInfo:
            case ConversationStep.VipServiceOffer:
                // Get hotel name from user data
                string hotelName = GetUserData(userNumber, "hotel") ?? "su hotel";
                string zone = GetUserData(userNumber, "zone") ?? "la zona";

                // Set parameters for template
                var parameters = new Dictionary<string, string>
                {
                    { "hotel", hotelName },
                    { "baseCost", zone == "bavaro" ? "20" : zone == "uvero_alto" ? "40" : "15" },
                    { "minPeople", "4" }
                };

                return _flowService.GetResponseForStep(nextStep, parameters);

            case ConversationStep.ReservationComplete:
                // Prepare reservation confirmation with all collected data
                var confirmParams = new Dictionary<string, string>
                {
                    { "date", GetUserData(userNumber, "date") ?? "la fecha seleccionada" },
                    { "time", GetUserData(userNumber, "time") ?? "la hora seleccionada" }
                };

                return _flowService.GetResponseForStep(nextStep, confirmParams);

            default:
                // Standard response for this step
                return _flowService.GetResponseForStep(nextStep);
        }
    }

    /// <inheritdoc />
    async Task IConversationService.SetManualHandlingAsync(string userNumber, bool enabled)
    {
        CoreConversationState? state = await _stateRepository.GetConversationStateByNumber(userNumber);

        if (state == null)
        {
            state = new CoreConversationState
            {
                UserNumber = userNumber,
                CurrentStep = ConversationStep.ManualHandling,
                IsAdminOverridden = enabled,
                IsComplete = false
            };
            await _stateRepository.PersistAsync(state);
        }
        else
        {
            state.IsAdminOverridden = enabled;

            if (enabled)
            {
                state.CurrentStep = ConversationStep.ManualHandling;
            }

            await _stateRepository.UpdateAsync(state);
        }
    }

    private void StoreUserInput(string userNumber, ConversationStep step, string input)
    {
        // Map specific steps to data fields
        switch (step)
        {
            case ConversationStep.ZoneSelection:
                _userDataStore[userNumber]["zone"] = input.ToLower();
                break;
            case ConversationStep.HotelSelection:
                _userDataStore[userNumber]["hotel"] = input;
                break;
            case ConversationStep.DateSelection:
                _userDataStore[userNumber]["date"] = input;
                break;
            case ConversationStep.TimeSelection:
                _userDataStore[userNumber]["time"] = input;
                break;
            case ConversationStep.CollectFullName:
                _userDataStore[userNumber]["fullName"] = input;
                break;
            case ConversationStep.CollectRoomNumber:
                _userDataStore[userNumber]["roomNumber"] = input;
                break;
            case ConversationStep.CollectAdultsCount:
                _userDataStore[userNumber]["adultsCount"] = input;
                break;
            case ConversationStep.CollectChildrenCount:
                _userDataStore[userNumber]["childrenCount"] = input;
                break;
            case ConversationStep.CollectPhoneNumber:
                _userDataStore[userNumber]["phoneNumber"] = input;
                break;
            case ConversationStep.CollectEmail:
                _userDataStore[userNumber]["email"] = input;
                break;
        }
    }

    private string GetUserData(string userNumber, string key)
    {
        if (_userDataStore.TryGetValue(userNumber, out var userData) && userData.TryGetValue(key, out var value))
        {
            return value;
        }

        return null;
    }
}