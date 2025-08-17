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
        
        // Validate adults count (should be a positive number, max reasonable limit)
        if (int.TryParse(userMessage, out int adults) && adults > 0 && adults <= 50)
        {
            context.Adults = adults;
            context.CurrentStep = ConversationStep.AskForChildren;
            return messageCreator.CreateAskForChildrenCountMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid adults count, ask again - stay in AskForAdults state
            context.CurrentStep = ConversationStep.AskForAdults;
            return messageCreator.CreateAskForAdultsCountMessage(context.UserNumber, languageId);
        }
    }
}