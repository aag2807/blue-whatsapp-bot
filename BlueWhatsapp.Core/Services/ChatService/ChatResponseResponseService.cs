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
}