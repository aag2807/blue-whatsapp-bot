using System.Data.SqlTypes;
using System.Text;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Triplex.Validations;

namespace BlueWhatsapp.Core.Services;

public sealed class ConversationHandlingService(
    IMessageCreator messageCreator,
    IHotelMatcher hotelMatcher,
    IScheduleRepository scheduleRepository,
    IHotelRepository hotelRepository,
    IReservationRepository reservationRepository,
    IAppLogger logger,
    IRouteRepository routeRepository
) : IConversationHandlingService
{
    async Task<CoreBaseMessage?> IConversationHandlingService.HandleState(CoreConversationState state, string userMessage = "")
    {
        if (state.Flow == ConversationFlowEnum.None)
        {
            return null;
        }

        if (state.Flow == ConversationFlowEnum.DIRECT_CLIENT_FREE_ROUTE)
        {
            return await HandleDirectClientFreeRoute(state, userMessage).ConfigureAwait(true);
        }

        return null;
    }

    private async Task<CoreBaseMessage> HandleDirectClientFreeRoute(CoreConversationState state, string userMessage)
    {
        try
        {
            if (state.CurrentStep == ConversationStep.Welcome || state.CurrentStep == ConversationStep.None)
            {
                return messageCreator.CreateWelcomeMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.LanguageSelection)
            {
                return messageCreator.CreateLanguagePromptMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.DateSelection)
            {
                return messageCreator.CreateDatePromptMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.ZoneSelection)
            {
                IEnumerable<CoreRoute> routes = await routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
                return messageCreator.CreateSelectHotelZoneLocationMessage(state.UserNumber, routes);
            }

            if (state.CurrentStep == ConversationStep.HotelSelection)
            {
                int.TryParse(state.ZoneId, out int id);
                IEnumerable<CoreHotel> hotels = await hotelRepository.GetHotelsByRouteIdAsync(id).ConfigureAwait(true);
                return messageCreator.CreateHotelSelectionMessage(state.UserNumber, hotels);
            }

            if (state.CurrentStep == ConversationStep.ScheduleSelection)
            {
                int.TryParse(state.HotelId, out int hotelId);
                CoreHotel? hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true);
                IEnumerable<CoreSchedule> schedules = await scheduleRepository.GetSchedulesByHotelId(hotelId).ConfigureAwait(true);

                return messageCreator.CreateTimeFrameSelectionMessage(state.UserNumber, hotel!, schedules);
            }

            if (state.CurrentStep == ConversationStep.AskForFullName)
            {
                return messageCreator.CreateAskingForNameMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.AskForRoomNumber)
            {
                return messageCreator.CreateAskingForRoomNumberMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.AskForAdults)
            {
                return messageCreator.CreateAskingForAdultsMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.AskForChildren)
            {
                return messageCreator.CreateAskingForAdultsMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.AskForEmail)
            {
                return messageCreator.CreateAskingEmailMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.ReservationComplete)
            {
                CoreHotel? hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(state.HotelId)).ConfigureAwait(true);
                CoreSchedule? schedule = await scheduleRepository.GetScheduleByIdAsync(int.Parse(state.ScheduleId)).ConfigureAwait(true);
                string date = state.PickUpDate;
                
                CoreReservation reservation = new CoreReservation();
                reservation.UserNumber = state.UserNumber;
                reservation.Username = state.PersonName;
                reservation.Details = userMessage;
                reservation.ReservationDate = state.PickUpDate;
                reservation.HotelName = hotel!.Name;
                reservation.ReserveTime = schedule!.Time;
                
                var message = messageCreator.CreateReservationConfirmationMessage(state.UserNumber, hotel!, schedule!, date);
                await reservationRepository.SaveReservation(reservation).ConfigureAwait(true);
                return message;
            }
            
            //states which break the regular flow
            if (state.CurrentStep == ConversationStep.ZoneUnknown)
            {
            }
            
            if (state.CurrentStep == ConversationStep.HotelUnknown)
            {
            }
            
            if (state.CurrentStep == ConversationStep.HotelConfirmation)
            {
            }
            
            if (state.CurrentStep == ConversationStep.WillTextLater)
            {
            }

            return null;
        }
        catch (Exception ex)
        {
            logger.LogError(ex);
            logger.LogError(ex.Data);
            logger.LogError(state);

            return null;
        }
    }
}