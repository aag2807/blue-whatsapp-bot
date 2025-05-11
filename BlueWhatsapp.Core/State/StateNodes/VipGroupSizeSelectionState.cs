using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.State.StateNodes;

public class VipGroupSizeSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.VipGroupSizeSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        return null;
    }
}