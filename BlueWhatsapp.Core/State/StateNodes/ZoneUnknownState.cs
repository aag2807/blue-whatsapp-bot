using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ZoneUnknownState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ZoneUnknown;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        return await ExecuteRepositoryAsync<CoreBaseMessage?>(async serviceProvider =>
        {
            IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            IHotelMatcher hotelMatcher = new HotelMatcher();

            var hotels = await hotelRepository.GetAllHotelsAsync().ConfigureAwait(true);
            hotelMatcher.SetHotelData(hotels.ToList());
            
            var matchedHotels = hotelMatcher.FindMatches(userMessage);

            if (!matchedHotels.Any())
            {
                // No matching hotels found, redirect to manual handling
                context.IsAdminOverridden = true;
                context.CurrentStep = ConversationStep.ManualHandling;
                return messageCreator.CreateUnknownHotelMessage(context.UserNumber, languageId);
            }

            if (matchedHotels.Count == 1)
            {
                // Single match found, proceed with this hotel
                var hotel = matchedHotels.First().Hotel;
                context.HotelId = hotel.Id.ToString();
                context.ZoneId = hotel.RouteId.ToString();

                // Check if hotel requires VIP service
                if (hotel.Price > 0)
                {
                    context.CurrentStep = ConversationStep.VipServiceOffer;
                    return messageCreator.CreateVipServiceOfferMessage(context.UserNumber, hotel, languageId);
                }
                else
                {
                    // Free shuttle service - proceed to schedule selection
                    context.CurrentStep = ConversationStep.ScheduleSelection;
                    var scheduleRepository = serviceProvider.GetRequiredService<IScheduleRepository>();
                    var schedules = await scheduleRepository.GetSchedulesByHotelId(hotel.Id).ConfigureAwait(true);
                    return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel, schedules, languageId);
                }
            }
            else
            {
                // Multiple matches found, ask user to choose
                var hotelIds = matchedHotels.Select(x => x.Hotel.Id).ToList();
                context.ExtraInformation = PipeStringHelper.PipeStringFromCollection(hotelIds);
                context.CurrentStep = ConversationStep.MoreThanOneMatchingHotel;
                
                return messageCreator.CreateMultipleHotelMatchMessage(context.UserNumber, 
                    matchedHotels.Select(m => m.Hotel), languageId);
            }
        });
    }
}