using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.Services.ChatService;

public sealed class ChatResponseResponseService(
        IConversationStateService conversationStateService,
        IMessageService messageService,
        IAppLogger logger,
        IWhatsappCloudService whatsappCloudService, 
        IConversationHandlingService conversationHandling
    ) : IChatResponseService
{
    async Task IChatResponseService.Execute(string userNumber, string fromName, string userText)
    {
        CoreConversationState? state = await conversationStateService.GetConversationStateByNumber(userNumber).ConfigureAwait(true);
        if (state == null)
        {
            state = await conversationStateService.CreateNewConversationState(userNumber).ConfigureAwait(true);
        }
        
        if (state.IsAdminOverridden)
        {
            await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
            return;
        }
        
        if (state.CurrentStep == ConversationStep.Welcome)
        {
            var welcomeMessage = conversationHandling.HandleState(state);
            if (welcomeMessage == null)
            {
                logger.LogInfo("No welcome message found");
                logger.LogInfo(state);
                return;
            }

            await HandleWelcomingMessage(welcomeMessage, fromName, userText, userNumber);
            state.CurrentStep = ConversationStep.LanguageSelection;
            CoreBaseMessage? languageSelectionService = conversationHandling.HandleState(state);
            await HandleLanguageSelectionMessage(state, languageSelectionService, fromName, userText, userNumber).ConfigureAwait(true);
        }
        
        UpdateConversationContextBasedOnCurrentStep(userText, state);
        CoreBaseMessage? newMessage = conversationHandling.HandleState(state);
    }

    private static void UpdateConversationContextBasedOnCurrentStep(string userText, CoreConversationState state)
    {
        if (state.CurrentStep == ConversationStep.HotelSelection)
        {
            const string I_DONT_KNOW_WHAT_HOTEL_ID = "0";
            if (userText == I_DONT_KNOW_WHAT_HOTEL_ID)
            {
                state.CurrentStep = ConversationStep.HotelUnknown;
            }
            else
            {
                state.HotelId = userText;
                state.CurrentStep = ConversationStep.ScheduleSelection;
            }
        }
        else if (state.CurrentStep == ConversationStep.LanguageSelection)
        {
            state.LanguageId = userText;
            state.CurrentStep = ConversationStep.DateSelection;
        } 
        else if (state.CurrentStep == ConversationStep.DateSelection)
        {
            state.PickUpDate = userText;
            state.CurrentStep = ConversationStep.ZoneSelection;
        }
        else if (state.CurrentStep == ConversationStep.ZoneSelection)
        {
            const string I_DONT_KNOW_WHAT_ZONE_ID = "0";
            if (userText == I_DONT_KNOW_WHAT_ZONE_ID)
            {
                state.CurrentStep = ConversationStep.ZoneUnknown;
            }
            else
            {
                state.ZoneId = userText;
                state.CurrentStep = ConversationStep.HotelSelection;
            }
        }else if (state.CurrentStep == ConversationStep.ScheduleSelection)
        {
            const string I_WILL_TEXT_AT_LATER_DATE_ID = "0";
            if (userText == I_WILL_TEXT_AT_LATER_DATE_ID)
            {
                state.CurrentStep = ConversationStep.WillTextLater;
            }
            else
            {
                state.ScheduleId = userText;
                state.CurrentStep = ConversationStep.AskForReservationDetails;
            } 
        }
        else if (state.CurrentStep == ConversationStep.AskForReservationDetails)
        {
            state.ReservationDetails = userText;
            state.CurrentStep = ConversationStep.ReservationComplete;
        }
    }

    private async Task HandleLanguageSelectionMessage(CoreConversationState state, CoreBaseMessage? languageSelectionService, string fromName, string userText, string userNumber)
    {
        await conversationStateService.UpdateConversationState(state).ConfigureAwait(true);
        await whatsappCloudService.SendMessage(languageSelectionService).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
        await messageService.SaveAsync("SYSTEM", "Listado de lenguajes", userNumber).ConfigureAwait(true);
    }

    private async Task HandleWelcomingMessage(CoreBaseMessage message, string fromName, string userText, string userNumber)
    {
        CoreMessageToSend typedMessage = (CoreMessageToSend)message;
        await whatsappCloudService.SendMessage(message).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
        await messageService.SaveAsync("SYSTEM", typedMessage.text.body, userNumber).ConfigureAwait(true);
    }
}