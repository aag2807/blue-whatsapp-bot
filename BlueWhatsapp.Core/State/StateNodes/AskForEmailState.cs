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

        // Validate email
        if (IsValidEmail(userMessage))
        {
            context.Email = userMessage.Trim();
            context.CurrentStep = ConversationStep.ReservationComplete;
            // Return null to trigger transition to ReservationComplete state
            // which will handle the reservation creation and confirmation message
            return null;
        }
        else
        {
            // Invalid email, ask again - stay in AskForEmail state
            context.CurrentStep = ConversationStep.AskForEmail;
            return messageCreator.CreateAskingEmailMessage(context.UserNumber, languageId);
        }
    }

    /// <summary>
    /// Validates if the email is in a reasonable format
    /// </summary>
    private static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        // Basic email validation using regex
        return System.Text.RegularExpressions.Regex.IsMatch(email.Trim(), 
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
    }


}