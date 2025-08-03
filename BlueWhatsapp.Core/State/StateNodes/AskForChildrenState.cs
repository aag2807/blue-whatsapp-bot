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
        
        if (int.TryParse(userMessage, out int adults))
        {
            context.Adults = adults;
        }
        else
        {
            context.Adults = 1;
        }
        
        context.CurrentStep = ConversationStep.AskForEmail;
        
        return messageCreator.CreateAskForChildrenCountMessage(context.UserNumber, languageId);
    }
}