using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ScheduleSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ScheduleSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        bool isValidHotelSelected = !IsIDontKnowOption(userMessage);
        int languageId = GetLanguageId(context);
        
        context.HotelId = userMessage;

        if (isValidHotelSelected)
        {
            context.CurrentStep = ConversationStep.AskForFullName;
            return await ExecuteRepositoryAsync(async serviceLocator =>
            {
                IHotelRepository hotelRepository = serviceLocator.GetRequiredService<IHotelRepository>();
                IScheduleRepository scheduleRepository = serviceLocator.GetRequiredService<IScheduleRepository>();

                CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(userMessage)).ConfigureAwait(true)!;
                IEnumerable<CoreSchedule>? schedules = await scheduleRepository.GetSchedulesByHotelId(hotel.Id).ConfigureAwait(true)!;

                return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel, schedules, languageId);
            });
        }

        return messageCreator.CreateUnknownHotelMessage(context.UserNumber, languageId);
    }
}