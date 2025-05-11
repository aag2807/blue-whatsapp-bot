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
        
        context.Adults = int.Parse(userMessage);
        context.CurrentStep = ConversationStep.AskForEmail;
        
        return messageCreator.CreateAskForChildrenCountMessage(context.UserNumber);
    }
}