using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ZoneSelectionResponseState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ZoneSelectionResponse;

    public override Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {


        return null;
    }
}