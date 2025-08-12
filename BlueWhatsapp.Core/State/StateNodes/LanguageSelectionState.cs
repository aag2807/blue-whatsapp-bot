using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class LanguageSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.LanguageSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        
        // Validate language selection and set appropriate language ID
        if (IsValidLanguageSelection(userMessage))
        {
            context.LanguageId = userMessage;
        }
        else
        {
            // Default to Spanish (1) if invalid selection
            context.LanguageId = "1";
        }

        context.CurrentStep = ConversationStep.DateSelection;
        
        // Get the validated language ID for message creation
        int languageId = GetLanguageId(context);
        return messageCreator.CreateDatePromptMessage(context.UserNumber, languageId);
    }
}