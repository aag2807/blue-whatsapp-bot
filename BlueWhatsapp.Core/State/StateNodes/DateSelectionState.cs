using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State.StateNodes;

public class DateSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.DateSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        if (IsValidLanguageSelection(userMessage))
        {
            context.LanguageId = userMessage;
        }
        else
        {
            context.LanguageId = "1";
        }

        context.CurrentStep = ConversationStep.ZoneSelection;

        int languageId = GetLanguageId(context);
        return GetMessageCreator().CreateDatePromptMessage(context.UserNumber, languageId);
    }
}