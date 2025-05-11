using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Services.ChatService;

public sealed class ChatResponseResponseService(
    IConversationStateService conversationStateService,
    IMessageService messageService,
    IAppLogger logger,
    IWhatsappCloudService whatsappCloudService,
    IConversationHandlingService conversationHandling
) : IChatResponseService
{
    private readonly DateParser _dateParser = new();  
    
    async Task IChatResponseService.Execute(string userNumber, string fromName, string userText)
    {
        CoreConversationState? state = await conversationStateService.GetConversationStateByNumber(userNumber).ConfigureAwait(true);
        if (state == null)
        {
            logger.LogSteps("No state found, being created.");
            state = await conversationStateService.CreateNewConversationState(userNumber).ConfigureAwait(true);
            state.PersonName = fromName;
        }

        if (state.IsAdminOverridden)
        {
            await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
            return;
        }

        if (state.CurrentStep == ConversationStep.Welcome) // is a special case since 2 messages/states are covered
        {
            await HandleConversationIntro(userNumber, fromName, userText, state);
            return;
        }

        CoreBaseMessage? newMessage = await conversationHandling.HandleState(state, userText).ConfigureAwait(true);
        if (newMessage == null)
        {
            return;
        }
        await whatsappCloudService.SendMessage(newMessage).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
        await conversationStateService.UpdateConversationState(state).ConfigureAwait(true);
    }

    private async Task HandleConversationIntro(string userNumber, string fromName, string userText, CoreConversationState state)
    {
        CoreBaseMessage welcomeMessage = await conversationHandling.HandleState(state, userText).ConfigureAwait(true)!;
            
        CoreMessageToSend typedMessage = (CoreMessageToSend)welcomeMessage;
        await whatsappCloudService.SendMessage(welcomeMessage).ConfigureAwait(true);
        await messageService.SaveAsync(fromName, userText, userNumber).ConfigureAwait(true);
        await messageService.SaveAsync("SYSTEM", typedMessage.text.body, userNumber).ConfigureAwait(true);
            
        CoreBaseMessage? languageSelectionService = await conversationHandling.HandleState(state, userText).ConfigureAwait(true);
        await whatsappCloudService.SendMessage(languageSelectionService).ConfigureAwait(true);
        await messageService.SaveAsync("SYSTEM", "Listado de lenguajes", userNumber).ConfigureAwait(true);

        await conversationStateService.AddAsync(state).ConfigureAwait(true);
    }

    private void UpdateConversationContextBasedOnCurrentStep(string userText, CoreConversationState state, string fromName)
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
            state.PickUpDate = _dateParser.TryParseDate(userText);
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
                state.CurrentStep = ConversationStep.AskForFullName;
                logger.LogSteps("selected schedule");
            }
        }

        else if (state.CurrentStep == ConversationStep.AskForRoomNumber)
        {
            state.RoomNumber = userText;
            state.CurrentStep = ConversationStep.AskForAdults;
            logger.LogSteps("provided room number");
        }
        else if (state.CurrentStep == ConversationStep.AskForAdults)
        {
            int.TryParse(userText, out var parsedValue);
            state.Adults = parsedValue;
            state.CurrentStep = ConversationStep.AskForChildren;
            logger.LogSteps("provided adults");
        }
        else if (state.CurrentStep == ConversationStep.AskForChildren)
        {
            int.TryParse(userText, out var parsedValue);
            state.Children = parsedValue;
            state.CurrentStep = ConversationStep.AskForEmail;
            logger.LogSteps("provided children");
        }
        else if (state.CurrentStep == ConversationStep.AskForEmail)
        {
            state.Email = userText;
            state.CurrentStep = ConversationStep.ReservationComplete;
            state.IsComplete = true;
            logger.LogSteps("provided email");
            logger.LogSteps("reservation complete");
        }

        logger.LogSteps(state);
    }

    private async Task HandleLanguageSelectionMessage(CoreConversationState state, CoreBaseMessage? languageSelectionService, string fromName, string userText, string userNumber)
    {
    }

    private async Task HandleWelcomingMessage(CoreBaseMessage message, string fromName, string userText, string userNumber)
    {
    }
}