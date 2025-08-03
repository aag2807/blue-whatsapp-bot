using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class VipServiceOfferState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.VipServiceOffer;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        // Store the hotel selection from previous step
        context.HotelId = userMessage;
        context.CurrentStep = ConversationStep.VipServiceConfirmation;

        return await ExecuteRepositoryAsync(async serviceProvider =>
        {
            IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            var hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(userMessage)).ConfigureAwait(true);

            if (hotel == null || hotel.Price == 0)
            {
                // This shouldn't happen if flow is correct, but handle gracefully
                context.CurrentStep = ConversationStep.ScheduleSelection;
                return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel!,
                    new List<CoreSchedule>(), languageId);
            }

            return messageCreator.CreateVipServiceOfferMessage(context.UserNumber, hotel, languageId);
        });
    }
}