using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ReservationCompleteState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ReservationComplete;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        context.IsComplete = true;
        context.Email = userMessage;

        return await ExecuteRepositoryAsync(async serviceLocator =>
        {
            IHotelRepository hotelRepository = serviceLocator.GetRequiredService<IHotelRepository>();
            IScheduleRepository scheduleRepository = serviceLocator.GetRequiredService<IScheduleRepository>();

            int hotelId = int.Parse(context.HotelId);
            int scheduleId = int.Parse(context.ScheduleId);
            CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true)!;
            CoreSchedule schedule = await scheduleRepository.GetScheduleByIdAsync(scheduleId).ConfigureAwait(true)!;
            string scheduleDate = context.PickUpDate;
            
            return messageCreator.CreateReservationConfirmationMessage(context.UserNumber, hotel, schedule, scheduleDate);
        });
    }
}