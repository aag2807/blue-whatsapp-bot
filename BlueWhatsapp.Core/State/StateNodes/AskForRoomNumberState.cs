using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForRoomNumberState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForRoomNumber;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);
        
        context.FullName = userMessage;
        context.CurrentStep = ConversationStep.AskForAdults;

        return messageCreator.CreateAskForRoomNumberMessage(context.UserNumber, languageId);
    }
}