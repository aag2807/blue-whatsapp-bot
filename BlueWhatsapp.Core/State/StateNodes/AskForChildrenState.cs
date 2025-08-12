using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForChildrenState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForChildren;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);
        
        // Validate adults count (should be a positive number, max reasonable limit)
        if (int.TryParse(userMessage, out int adults) && adults > 0 && adults <= 50)
        {
            context.Adults = adults;
            context.CurrentStep = ConversationStep.AskForPhone;
            return messageCreator.CreateAskForChildrenCountMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid adults count, ask again - stay in AskForChildren state
            context.CurrentStep = ConversationStep.AskForChildren;
            return messageCreator.CreateAskForAdultsCountMessage(context.UserNumber, languageId);
        }
    }
}