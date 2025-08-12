using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class MoreThanOneMatchingHotelState: BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.MoreThanOneMatchingHotel;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);

        // Parse the hotel IDs from ExtraInformation (pipe-separated)
        if (string.IsNullOrEmpty(context.ExtraInformation))
        {
            context.IsAdminOverridden = true;
            context.CurrentStep = ConversationStep.ManualHandling;
            return messageCreator.CreateUnknownHotelMessage(context.UserNumber, languageId);
        }

        // Validate user selection
        if (int.TryParse(userMessage, out int selectedIndex) && selectedIndex > 0)
        {
            var hotelIds = PipeStringHelper.PipeStringToIntList(context.ExtraInformation);
            
            // Check if selection is within valid range
            if (selectedIndex <= hotelIds.Count)
            {
                int selectedHotelId = hotelIds[selectedIndex - 1]; // Convert to 0-based index
                
                return await ExecuteRepositoryAsync<CoreBaseMessage?>(async serviceProvider =>
                {
                    var hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
                    var hotel = await hotelRepository.GetHotelByIdAsync(selectedHotelId).ConfigureAwait(true);
                    
                    if (hotel == null)
                    {
                        context.IsAdminOverridden = true;
                        context.CurrentStep = ConversationStep.ManualHandling;
                        return messageCreator.CreateUnknownHotelMessage(context.UserNumber, languageId);
                    }

                    // Set hotel information
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
                });
            }
        }

        // Invalid selection, show options again
        return await ExecuteRepositoryAsync<CoreBaseMessage?>(async serviceProvider =>
        {
            var hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            var hotelIds = PipeStringHelper.PipeStringToIntList(context.ExtraInformation);
            var hotels = new List<CoreHotel>();
            
            foreach (int hotelId in hotelIds)
            {
                var hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true);
                if (hotel != null)
                {
                    hotels.Add(hotel);
                }
            }

            return messageCreator.CreateMultipleHotelMatchMessage(context.UserNumber, hotels, languageId);
        });
    }
}
