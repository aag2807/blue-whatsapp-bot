using System.Data.SqlTypes;
using System.Text;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Services;

public sealed class ConversationHandlingService : IConversationHandlingService
{
    private readonly IMessageCreator _messageCreator;
    private readonly IHotelMatcher _hotelMatcher;
    
    public ConversationHandlingService(IMessageCreator messageCreator, IHotelMatcher hotelMatcher)
    {
        _messageCreator = messageCreator;
        _hotelMatcher = hotelMatcher;
    }
    
    CoreBaseMessage? IConversationHandlingService.HandleState(CoreConversationState state, string userMessage = "")
    {
        if (state.Flow == ConversationFlowEnum.None)
        {
            return null;
        }

        if (state.Flow == ConversationFlowEnum.DIRECT_CLIENT_FREE_ROUTE)
        {
            return HandleDirectClientFreeRoute(state, userMessage);
        }

        return null;
    }

    private CoreBaseMessage HandleDirectClientFreeRoute(CoreConversationState state, string userMessage)
    {
        if (state.CurrentStep == ConversationStep.Welcome || state.CurrentStep == ConversationStep.None)
        {
            return _messageCreator.CreateWelcomeMessage(state.UserNumber);
        }

        if (state.CurrentStep == ConversationStep.LanguageSelection)
        {
            return _messageCreator.CreateLanguagePromptMessage(state.UserNumber);
        }

        if (state.CurrentStep == ConversationStep.DateSelection)
        {
            return _messageCreator.CreateDatePromptMessage(state.UserNumber);
        }

        if (state.CurrentStep == ConversationStep.ZoneSelection)
        {
            return _messageCreator.CreateSelectHotelZoneLocationMessage(state.UserNumber);
        }
    
        if (state.CurrentStep == ConversationStep.HotelSelection)
        {
            return _messageCreator.CreateHotelSelectionMessage(state.UserNumber, new List<CoreHotel>());
        };

        if (state.CurrentStep == ConversationStep.HotelConfirmation)
        {
            
        }
        
        return null;
    }
}