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
        int languageId = GetLanguageId(context);

        // Validate phone number
        if (IsValidPhoneNumber(userMessage))
        {
            context.ExtraInformation = userMessage.Trim(); // Store phone in ExtraInformation as per test
            context.CurrentStep = ConversationStep.ReservationComplete;
            return messageCreator.CreateAskingEmailMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid phone number, ask again - stay in AskForEmail state
            context.CurrentStep = ConversationStep.AskForEmail;
            return messageCreator.CreateAskingEmailMessage(context.UserNumber, languageId);
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
        string cleanPhone = System.Text.RegularExpressions.Regex.Replace(phone, @"[\s\-\(\)\+\.]", "");
        
        // Check if it's all digits and has reasonable length (7-15 digits)
        return System.Text.RegularExpressions.Regex.IsMatch(cleanPhone, @"^\d{7,15}$");
    }


}