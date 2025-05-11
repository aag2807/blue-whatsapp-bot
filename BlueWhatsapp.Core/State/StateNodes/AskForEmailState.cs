using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForEmailState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForEmail;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();

        context.Children = int.Parse(userMessage);
        context.CurrentStep = ConversationStep.ReservationComplete;

        return messageCreator.CreateAskingEmailMessage(context.UserNumber);
    }
}