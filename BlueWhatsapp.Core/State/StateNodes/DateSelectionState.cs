using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class DateSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.DateSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        CoreBaseMessage? promptForScheduleDate =  messageCreator.CreateDatePromptMessage(context.UserNumber);

        context.CurrentStep = ConversationStep.ZoneSelection;
        context.LanguageId = userMessage;
        
        return promptForScheduleDate;
    }
}