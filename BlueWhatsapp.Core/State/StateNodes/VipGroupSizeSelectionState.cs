using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
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

        // Validate group size selection for Bayahibe
        // Option 1: Less than 15 people (13-15 capacity bus)
        // Option 2: More than 15 people (22-30 capacity bus)
        if (userMessage.Equals("1", StringComparison.OrdinalIgnoreCase))
        {
            // Small bus (13-15 people)
            context.ExtraInformation = "small_bus"; 
            context.CurrentStep = ConversationStep.ScheduleSelection;
        }
        else if (userMessage.Equals("2", StringComparison.OrdinalIgnoreCase))
        {
            // Large bus (22-30 people)
            context.ExtraInformation = "large_bus";
            context.CurrentStep = ConversationStep.ScheduleSelection;
        }
        else
        {
            // Invalid selection, ask again
            return messageCreator.CreateGroupSizeSelectionMessage(context.UserNumber, languageId);
        }

        // Proceed to schedule selection
        return await ExecuteRepositoryAsync(async serviceProvider =>
        {
            IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            IScheduleRepository scheduleRepository = serviceProvider.GetRequiredService<IScheduleRepository>();

            CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(context.HotelId)).ConfigureAwait(true)!;
            var schedules = await scheduleRepository.GetSchedulesByHotelId(hotel.Id).ConfigureAwait(true);

            return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel, schedules, languageId);
        });
    }
}