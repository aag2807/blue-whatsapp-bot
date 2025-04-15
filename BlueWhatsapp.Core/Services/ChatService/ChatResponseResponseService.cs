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
            logger.LogSteps("No state found, being created.");
            state = await conversationStateService.CreateNewConversationState(userNumber).ConfigureAwait(true);
        }

        if (state.IsAdminOverridden)
        {
            await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
            return;
        }

        if (state.CurrentStep == ConversationStep.Welcome) // is a special case since 2 messages/states are covered
        {
            var welcomeMessage = await conversationHandling.HandleState(state, userText).ConfigureAwait(true);
            if (welcomeMessage == null)
            {
                logger.LogSteps("No welcome message created.");
                logger.LogSteps(state);
                return;
            }

            await HandleWelcomingMessage(welcomeMessage, fromName, userText, userNumber);
            state.CurrentStep = ConversationStep.LanguageSelection;
            CoreBaseMessage? languageSelectionService = await conversationHandling.HandleState(state, userText).ConfigureAwait(true);
            await HandleLanguageSelectionMessage(state, languageSelectionService, fromName, userText, userNumber).ConfigureAwait(true);
            return;
        }

        UpdateConversationContextBasedOnCurrentStep(userText, state);
        CoreBaseMessage? newMessage = await conversationHandling.HandleState(state, userText).ConfigureAwait(true);
        await conversationStateService.UpdateConversationState(state).ConfigureAwait(true);
        await whatsappCloudService.SendMessage(newMessage).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
    }

    private void UpdateConversationContextBasedOnCurrentStep(string userText, CoreConversationState state)
    {
        if (state.CurrentStep == ConversationStep.HotelSelection)
        {
            logger.LogSteps("hotel selection");
            const string I_DONT_KNOW_WHAT_HOTEL_ID = "0";
            if (userText == I_DONT_KNOW_WHAT_HOTEL_ID)
            {
                logger.LogSteps("dont know what hotel id to know");
                state.CurrentStep = ConversationStep.HotelUnknown;
            }
            else
            {
                state.HotelId = userText;
                state.CurrentStep = ConversationStep.ScheduleSelection;
                logger.LogSteps("selected hotel");
            }
        }
        else if (state.CurrentStep == ConversationStep.LanguageSelection)
        {
            state.LanguageId = userText;
            state.CurrentStep = ConversationStep.DateSelection;
            logger.LogSteps("selected date");
        }
        else if (state.CurrentStep == ConversationStep.DateSelection)
        {
            state.PickUpDate = userText;
            state.CurrentStep = ConversationStep.ZoneSelection;
            logger.LogSteps("selected pick up date");
        }
        else if (state.CurrentStep == ConversationStep.ZoneSelection)
        {
            const string I_DONT_KNOW_WHAT_ZONE_ID = "0";
            if (userText == I_DONT_KNOW_WHAT_ZONE_ID)
            {
                logger.LogSteps("dont know what zone id to know");
                state.CurrentStep = ConversationStep.ZoneUnknown;
            }
            else
            {
                state.ZoneId = userText;
                state.CurrentStep = ConversationStep.HotelSelection;
                logger.LogSteps("selected zone");
            }
        }
        else if (state.CurrentStep == ConversationStep.ScheduleSelection)
        {
            const string I_WILL_TEXT_AT_LATER_DATE_ID = "0";
            if (userText == I_WILL_TEXT_AT_LATER_DATE_ID)
            {
                logger.LogSteps("will text later");
                state.CurrentStep = ConversationStep.WillTextLater;
            }
            else
            {
                state.ScheduleId = userText;
                state.CurrentStep = ConversationStep.AskForReservationDetails;
                logger.LogSteps("selected schedule");
            }
        }
        else if (state.CurrentStep == ConversationStep.AskForReservationDetails)
        {
            state.ReservationDetails = userText;
            state.CurrentStep = ConversationStep.ReservationComplete;
            logger.LogSteps("completed reseration details");

            //TODO: create reservation entity.
            logger.LogSteps("Reservation created");
        }

        logger.LogSteps(state);
    }

    private async Task HandleLanguageSelectionMessage(CoreConversationState state, CoreBaseMessage? languageSelectionService, string fromName, string userText, string userNumber)
    {
        await conversationStateService.UpdateConversationState(state).ConfigureAwait(true);
        await whatsappCloudService.SendMessage(languageSelectionService).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
        await messageService.SaveAsync("SYSTEM", "Listado de lenguajes", userNumber).ConfigureAwait(true);
        logger.LogSteps("Language selection Message");
    }

    private async Task HandleWelcomingMessage(CoreBaseMessage message, string fromName, string userText, string userNumber)
    {
        CoreMessageToSend typedMessage = (CoreMessageToSend)message;
        await whatsappCloudService.SendMessage(message).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
        await messageService.SaveAsync("SYSTEM", typedMessage.text.body, userNumber).ConfigureAwait(true);
        logger.LogSteps("Sent Welcome Message");
    }
}