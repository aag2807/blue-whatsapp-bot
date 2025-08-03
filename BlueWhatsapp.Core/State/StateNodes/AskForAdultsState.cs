using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForAdultsState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForAdults;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);
        
        context.RoomNumber = userMessage;
        context.CurrentStep = ConversationStep.AskForChildren;
        
        return messageCreator.CreateAskForAdultsCountMessage(context.UserNumber, languageId);
    }
}