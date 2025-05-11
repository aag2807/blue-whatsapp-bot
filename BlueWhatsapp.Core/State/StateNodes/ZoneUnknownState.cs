using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.VisualBasic;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ZoneUnknownState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ZoneUnknown;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        IHotelRepository hotelRepository = GetHotelRepository();
        IHotelMatcher hotelMatcher = new HotelMatcher();

        IEnumerable<CoreHotel> hotels = await hotelRepository.GetAllHotelsAsync().ConfigureAwait(false);
        hotelMatcher.SetHotelData(hotels.ToList());
        
        List<HotelMatch> matchedHotels = hotelMatcher.FindMatches(userMessage);

        if (!matchedHotels.Any())
        {
            context.IsAdminOverridden = true;
            context.CurrentStep = ConversationStep.NoMatchingHotel;

            return messageCreator.CreateUnknownHotelMessage(context.UserNumber);
        }

        IEnumerable<int> foundHotelIds = matchedHotels.Select(x => x.Hotel.Id).ToList();
        if (matchedHotels.Count() > 1)
        {
            context.ExtraInformation = PipeStringHelper.PipeStringFromCollection(foundHotelIds);
        }

        return null;
    }
}