using BlueWhatsapp.Core.Enums;

namespace BlueWhatsapp.Core.Utils;

public sealed class ConversationState
{
    public ConversationFlowEnum Flow { get; set; } = ConversationFlowEnum.None;
    public ConversationStep CurrentStep { get; set; } = ConversationStep.None;
}