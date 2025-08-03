using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
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
            context.CurrentStep = ConversationStep.NoMatchingHotel;
            return messageCreator.CreateNoMatchingHotelMessage(context.UserNumber, languageId);
        }

        List<int> hotelIds = PipeStringHelper.PipeStringToIntList(context.ExtraInformation);
        
        return await ExecuteRepositoryAsync(async serviceProvider =>
        {
            var hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
            var hotels = new List<CoreHotel>();
            
            foreach (int hotelId in hotelIds)
            {
                var hotel = await hotelRepository.GetHotelByIdAsync(hotelId).ConfigureAwait(true);
                if (hotel != null)
                {
                    hotels.Add(hotel);
                }
            }

            context.CurrentStep = ConversationStep.IsThisMatchingHotel;
            return messageCreator.CreateMultipleHotelMatchMessage(context.UserNumber, hotels, languageId);
        });
    }
}
