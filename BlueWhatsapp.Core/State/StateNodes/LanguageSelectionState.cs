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
        
        CoreBaseMessage? languagePrompt =  messageCreator.CreateLanguagePromptMessage(context.UserNumber);

        context.LanguageId = userMessage;
        context.CurrentStep = ConversationStep.DateSelection;

        return languagePrompt;
    }
}