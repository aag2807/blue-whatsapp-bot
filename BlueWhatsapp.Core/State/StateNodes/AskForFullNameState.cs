using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForFullNameState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForFullName;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        bool isValidSchedule = userMessage != I_DONT_KNOW_OPTION;
        IMessageCreator messageCreator = GetMessageCreator();

        if (!isValidSchedule)
        {
            context.IsComplete = true;
            context.CurrentStep = ConversationStep.WillTextLater;

            return messageCreator.CreateWillTextLaterMessage(context.UserNumber);
        }

        context.ScheduleId = userMessage;
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        return messageCreator.CreateAskingForNameMessage(context.UserNumber);
    }
}