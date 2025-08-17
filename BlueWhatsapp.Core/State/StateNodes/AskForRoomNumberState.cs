using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForRoomNumberState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForRoomNumber;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);
        
        // Validate room number (should not be empty)
        if (!string.IsNullOrWhiteSpace(userMessage))
        {
            context.RoomNumber = userMessage.Trim();
            context.CurrentStep = ConversationStep.AskForAdults;
            return messageCreator.CreateAskForAdultsCountMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid room number, ask again - stay in AskForRoomNumber state
            context.CurrentStep = ConversationStep.AskForRoomNumber;
            return messageCreator.CreateAskForRoomNumberMessage(context.UserNumber, languageId);
        }
    }
}