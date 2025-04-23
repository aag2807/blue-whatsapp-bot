using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Services;

public interface IConversationHandlingService
{
    public Task<CoreBaseMessage?> HandleState(CoreConversationState state, string userMessage = "");
}