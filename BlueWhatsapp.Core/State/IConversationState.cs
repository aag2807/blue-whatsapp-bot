using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;

namespace BlueWhatsapp.Core.State;

public interface IConversationState
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <param name="userMessage"></param>
    /// <returns></returns>
    Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage);
    
    /// <summary>
    /// 
    /// </summary>
    ConversationStep StateId { get; }
}