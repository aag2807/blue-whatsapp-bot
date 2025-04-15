using System.Data.SqlTypes;
using System.Text;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
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
    IAppLogger logger
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
                return messageCreator.CreateSelectHotelZoneLocationMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.HotelSelection)
            {
                return messageCreator.CreateHotelSelectionMessage(state.UserNumber, new List<CoreHotel>());
            }

            if (state.CurrentStep == ConversationStep.ScheduleSelection)
            {
                CoreHotel? hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(state.HotelId)).ConfigureAwait(true);
                return messageCreator.CreateTimeFrameSelectionMessage(state.UserNumber, hotel, new List<CoreSchedule>());
            }

            if (state.CurrentStep == ConversationStep.AskForReservationDetails)
            {
                return messageCreator.CreateAskForReservationDetailsMessage(state.UserNumber);
            }

            if (state.CurrentStep == ConversationStep.ReservationComplete)
            {
                CoreHotel? hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(state.HotelId)).ConfigureAwait(true);
                CoreSchedule? schedule = await scheduleRepository.GetScheduleByIdAsync(int.Parse(state.ScheduleId)).ConfigureAwait(true);
                string date = state.PickUpDate;

                return messageCreator.CreateReservationConfirmationMessage(state.UserNumber, hotel!, schedule!, date);
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