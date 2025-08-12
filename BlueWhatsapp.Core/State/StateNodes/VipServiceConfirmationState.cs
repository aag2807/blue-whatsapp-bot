using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class VipServiceConfirmationState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.VipServiceConfirmation;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        // Check if user accepted VIP service
        bool acceptedVip = userMessage.Equals("1", StringComparison.OrdinalIgnoreCase) ||
                          userMessage.ToLower().Contains("si") ||
                          userMessage.ToLower().Contains("yes") ||
                          userMessage.ToLower().Contains("oui") ||
                          userMessage.ToLower().Contains("да") ||
                          userMessage.ToLower().Contains("sim") ||
                          userMessage.ToLower().Contains("是");

        if (!acceptedVip)
        {
            // User declined or wants to think about it
            context.IsComplete = true;
            context.CurrentStep = ConversationStep.WillTextLater;
            return messageCreator.CreateWillTextLaterMessage(context.UserNumber, languageId);
        }

        return await ExecuteRepositoryAsync(async serviceProvider =>
        {
            IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            IScheduleRepository scheduleRepository = serviceProvider.GetRequiredService<IScheduleRepository>();

            CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(context.HotelId)).ConfigureAwait(true)!;

            // Check if hotel is in Bayahibe (requires group size selection)
            if (hotel.RouteNavigation?.Name.Contains("Bayahibe", StringComparison.OrdinalIgnoreCase) == true)
            {
                context.CurrentStep = ConversationStep.GroupSizeSelection;
                return messageCreator.CreateGroupSizeSelectionMessage(context.UserNumber, languageId);
            }

            // Standard VIP service - proceed to schedule selection
            context.CurrentStep = ConversationStep.ScheduleSelection;
            var schedules = await scheduleRepository.GetSchedulesByHotelId(hotel.Id).ConfigureAwait(true);
            return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel, schedules, languageId);
        });
    }
}