using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;
using System.Text.RegularExpressions;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ReservationCompleteState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ReservationComplete;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        // Check if email is already set in context (from AskForEmailState)
        if (!string.IsNullOrWhiteSpace(context.Email) && IsValidEmail(context.Email))
        {
            // Email is already validated and set, process the reservation
            context.IsComplete = true;

            return await ExecuteRepositoryAsync(async serviceLocator =>
            {
                IHotelRepository hotelRepository = serviceLocator.GetRequiredService<IHotelRepository>();
                IScheduleRepository scheduleRepository = serviceLocator.GetRequiredService<IScheduleRepository>();
                IReservationRepository reservationRepository = serviceLocator.GetRequiredService<IReservationRepository>();

                int hotelId = int.Parse(context.HotelId);
                int scheduleId = int.Parse(context.ScheduleId);
                CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true)!;
                CoreSchedule schedule = await scheduleRepository.GetScheduleByIdAsync(scheduleId).ConfigureAwait(true)!;

                // Create and save reservation
                CoreReservation reservation = new()
                {
                    TripId = int.Parse(context.ZoneId),
                    UserNumber = context.UserNumber,
                    Username = context.FullName,
                    RoomNumber = context.RoomNumber,
                    AdultsCount = context.Adults,
                    ChildrenCount = context.Children,
                    Email = context.Email,
                    Schedule = schedule,
                    ReservationDate = context.PickUpDate,
                    ReserveTime = schedule.Time,
                    Hotel = hotel,
                    HotelName = hotel.Name
                };

                await reservationRepository.SaveReservation(reservation).ConfigureAwait(true);

                return messageCreator.CreateReservationConfirmationMessage(context.UserNumber, hotel, schedule, context.PickUpDate, languageId);
            });
        }
        else if (IsValidEmail(userMessage))
        {
            // Fallback: validate email from userMessage (for backward compatibility)
            context.Email = userMessage.Trim().ToLower();
            context.IsComplete = true;

            return await ExecuteRepositoryAsync(async serviceLocator =>
            {
                IHotelRepository hotelRepository = serviceLocator.GetRequiredService<IHotelRepository>();
                IScheduleRepository scheduleRepository = serviceLocator.GetRequiredService<IScheduleRepository>();
                IReservationRepository reservationRepository = serviceLocator.GetRequiredService<IReservationRepository>();

                int hotelId = int.Parse(context.HotelId);
                int scheduleId = int.Parse(context.ScheduleId);
                CoreHotel hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true)!;
                CoreSchedule schedule = await scheduleRepository.GetScheduleByIdAsync(scheduleId).ConfigureAwait(true)!;

                // Create and save reservation
                CoreReservation reservation = new()
                {
                    TripId = int.Parse(context.ZoneId),
                    UserNumber = context.UserNumber,
                    Username = context.FullName,
                    RoomNumber = context.RoomNumber,
                    AdultsCount = context.Adults,
                    ChildrenCount = context.Children,
                    Email = context.Email,
                    Schedule = schedule,
                    ReservationDate = context.PickUpDate,
                    ReserveTime = schedule.Time,
                    Hotel = hotel,
                    HotelName = hotel.Name
                };

                await reservationRepository.SaveReservation(reservation).ConfigureAwait(true);

                return messageCreator.CreateReservationConfirmationMessage(context.UserNumber, hotel, schedule, context.PickUpDate, languageId);
            });
        }
        else
        {
            // Invalid email, ask again - stay in ReservationComplete state
            context.CurrentStep = ConversationStep.ReservationComplete;
            return messageCreator.CreateAskingEmailMessage(context.UserNumber, languageId);
        }
    }

    /// <summary>
    /// Validates if the email is in a proper format
    /// </summary>
    private static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        try
        {
            // Basic email format validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }
        catch
        {
            return false;
        }
    }
}