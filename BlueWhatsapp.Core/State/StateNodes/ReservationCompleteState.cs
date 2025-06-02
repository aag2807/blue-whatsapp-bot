using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
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
            IReservationRepository reservationRepository = serviceLocator.GetRequiredService<IReservationRepository>();
            
            int hotelId = int.Parse(context.HotelId);
            int scheduleId = int.Parse(context.ScheduleId);
            CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true)!;
            CoreSchedule schedule = await scheduleRepository.GetScheduleByIdAsync(scheduleId).ConfigureAwait(true)!;
            string scheduleDate = context.PickUpDate;

            CoreReservation reservation = new();
            reservation.TripId = int.Parse(context.ZoneId);
            reservation.UserNumber = context.UserNumber;
            reservation.Username = context.FullName;
            reservation.RoomNumber = context.RoomNumber;
            reservation.AdultsCount = context.Adults;
            reservation.ChildrenCount = context.Children;
            reservation.Email = context.Email;
            reservation.Schedule = schedule;
            reservation.ReservationDate = context.PickUpDate;
            reservation.ReserveTime = schedule.Time;
            reservation.Hotel = hotel;
            reservation.HotelName = hotel.Name;
                
            await reservationRepository.SaveReservation(reservation).ConfigureAwait(true);
            
            return messageCreator.CreateReservationConfirmationMessage(context.UserNumber, hotel, schedule, scheduleDate);
        });
    }
}