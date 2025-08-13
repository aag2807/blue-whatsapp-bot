using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class HotelSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.HotelSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        // Check if user selected "I don't know" option
        if (IsIDontKnowOption(userMessage))
        {
            context.CurrentStep = ConversationStep.HotelUnknown;
            return messageCreator.CreateUnknownHotelMessage(context.UserNumber, languageId);
        }

        // Validate hotel selection and ZoneId
        if (int.TryParse(userMessage, out int hotelId) && hotelId > 0 && !string.IsNullOrEmpty(context.ZoneId) && int.TryParse(context.ZoneId, out int zoneId))
        {
            context.HotelId = userMessage;

            return await ExecuteRepositoryAsync(async serviceProvider =>
            {
                IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
                IScheduleRepository scheduleRepository = serviceProvider.GetRequiredService<IScheduleRepository>();

                var hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true);
                
                if (hotel == null)
                {
                    // Hotel not found, ask again - stay in HotelSelection state
                    context.CurrentStep = ConversationStep.HotelSelection;
                    var hotelsByRoute = await hotelRepository.GetHotelsByRouteIdAsync(zoneId).ConfigureAwait(true);
                    return messageCreator.CreateHotelSelectionMessage(context.UserNumber, hotelsByRoute, languageId);
                }

                // Check if hotel requires VIP service (has a price)
                if (hotel.Price > 0)
                {
                    context.CurrentStep = ConversationStep.VipServiceOffer;
                    return messageCreator.CreateVipServiceOfferMessage(context.UserNumber, hotel, languageId);
                }
                else
                {
                    // Free shuttle service - proceed to schedule selection
                    context.CurrentStep = ConversationStep.ScheduleSelection;
                    var schedules = await scheduleRepository.GetSchedulesByHotelId(hotel.Id).ConfigureAwait(true);
                    return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel, schedules, languageId);
                }
            });
        }
        else
        {
            // Invalid hotel selection, ask again - stay in HotelSelection state
            context.CurrentStep = ConversationStep.HotelSelection;
            return await ExecuteRepositoryAsync(async serviceProvider =>
            {
                var repository = serviceProvider.GetRequiredService<IHotelRepository>();
                if (int.TryParse(context.ZoneId, out int zoneId))
                {
                    var hotelsByRoute = await repository.GetHotelsByRouteIdAsync(zoneId).ConfigureAwait(true);
                    return messageCreator.CreateHotelSelectionMessage(context.UserNumber, hotelsByRoute, languageId);
                }
                else
                {
                    // If ZoneId is invalid, return to zone selection
                    context.CurrentStep = ConversationStep.ZoneSelection;
                    var routeRepository = serviceProvider.GetRequiredService<IRouteRepository>();
                    var routes = await routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
                    return messageCreator.CreateSelectHotelZoneLocationMessage(context.UserNumber, routes, languageId);
                }
            });
        }
    }
}