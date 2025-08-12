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

        // This state asks for the full name, so we expect the previous state to have set the schedule
        // The userMessage here should be empty (first call) or contain validation from previous state
        context.CurrentStep = ConversationStep.AskForRoomNumber;

        return messageCreator.CreateAskingForNameMessage(context.UserNumber, languageId);
    }
}