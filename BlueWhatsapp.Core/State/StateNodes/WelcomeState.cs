using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class WelcomeState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.Welcome;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        
        CoreBaseMessage? welcomeMessage =  messageCreator.CreateWelcomeMessage(context.UserNumber);

        context.CurrentStep = ConversationStep.LanguageSelection;

        return welcomeMessage;
    }
}