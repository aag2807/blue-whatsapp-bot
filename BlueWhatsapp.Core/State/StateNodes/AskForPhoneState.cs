using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;
using System.Text.RegularExpressions;

namespace BlueWhatsapp.Core.State.StateNodes;

public class AskForPhoneState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.AskForPhone;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);
        
        // Validate children count (should be 0 or positive, max reasonable limit)
        if (int.TryParse(userMessage, out int children) && children >= 0 && children <= 20)
        {
            context.Children = children;
            context.CurrentStep = ConversationStep.AskForEmail;
            return messageCreator.CreateAskingEmailMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid children count, ask again
            return messageCreator.CreateAskForChildrenCountMessage(context.UserNumber, languageId);
        }
    }

    /// <summary>
    /// Validates if the phone number is in a reasonable format
    /// </summary>
    private static bool IsValidPhoneNumber(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
            return false;

        // Remove common separators and spaces
        string cleanPhone = Regex.Replace(phone, @"[\s\-\(\)\+]", "");
        
        // Check if it's all digits and has reasonable length (7-15 digits)
        return Regex.IsMatch(cleanPhone, @"^\d{7,15}$");
    }
}