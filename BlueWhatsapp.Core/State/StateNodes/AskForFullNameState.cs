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
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        // Validate full name (should not be empty or too short)
        if (!string.IsNullOrWhiteSpace(userMessage) && userMessage.Trim().Length >= 2)
        {
            context.FullName = userMessage.Trim();
            context.CurrentStep = ConversationStep.AskForRoomNumber;
            return messageCreator.CreateAskForRoomNumberMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid name or first call, ask for name - stay in AskForFullName state
            context.CurrentStep = ConversationStep.AskForFullName;
            return messageCreator.CreateAskingForNameMessage(context.UserNumber, languageId);
        }
    }
}