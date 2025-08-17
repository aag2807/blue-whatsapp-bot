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
        
        // Validate children count (should be 0 or positive, max reasonable limit)
        if (int.TryParse(userMessage, out int children) && children >= 0 && children <= 20)
        {
            context.Children = children;
            context.CurrentStep = ConversationStep.AskForPhone;
            return messageCreator.CreateAskForPhoneMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid children count, ask again - stay in AskForChildren state
            context.CurrentStep = ConversationStep.AskForChildren;
            return messageCreator.CreateAskForChildrenCountMessage(context.UserNumber, languageId);
        }
    }
}