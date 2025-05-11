using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.State.StateNodes;

public class HotelConfirmationState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.HotelConfirmation;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        return null;
    }
}