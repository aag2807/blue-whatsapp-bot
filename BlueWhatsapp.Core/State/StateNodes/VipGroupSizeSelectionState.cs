using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class VipGroupSizeSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.VipGroupSizeSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        context.HotelId = userMessage;
        context.CurrentStep = ConversationStep.VipServiceConfirmation;

        return await ExecuteRepositoryAsync<CoreBaseMessage>(async serviceProvider =>
        {
            IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            CoreHotel? hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(userMessage)).ConfigureAwait(true);

            if (hotel == null)
            {
                return messageCreator.CreateUnknownHotelMessage(context.UserNumber, languageId);
            }

            if (hotel.RouteNavigation?.Name.Contains("Bayahibe", StringComparison.OrdinalIgnoreCase) == true)
            {
                return messageCreator.CreateGroupSizeSelectionMessage(context.UserNumber, languageId);
            }

            context.CurrentStep = ConversationStep.VipServiceConfirmation;
            return messageCreator.CreateVipServiceOfferMessage(context.UserNumber, hotel, languageId);
        });
    }
}