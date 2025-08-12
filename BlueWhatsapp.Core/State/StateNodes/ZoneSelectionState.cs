using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ZoneSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ZoneSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        // Validate zone selection
        if (int.TryParse(userMessage, out int zoneId) && zoneId > 0)
        {
            context.ZoneId = userMessage;
            
            // Check if user selected "I don't know" option
            if (IsIDontKnowOption(userMessage))
            {
                context.CurrentStep = ConversationStep.ZoneUnknown;
                int languageId = GetLanguageId(context);
                return GetMessageCreator().CreateUnknownHotelMessage(context.UserNumber, languageId);
            }
            
            context.CurrentStep = ConversationStep.HotelSelection;
            
            return await ExecuteRepositoryAsync(async serviceProvider =>
            {
                IHotelRepository repository = serviceProvider.GetRequiredService<IHotelRepository>();
                IMessageCreator messageCreator = serviceProvider.GetRequiredService<IMessageCreator>();

                var hotelsByRoute = await repository.GetHotelsByRouteIdAsync(zoneId).ConfigureAwait(true);
                int languageId = GetLanguageId(context);

                return messageCreator.CreateHotelSelectionMessage(context.UserNumber, hotelsByRoute, languageId);
            });
        }
        else
        {
            // Invalid zone selection, ask again
            int languageId = GetLanguageId(context);
            return await ExecuteRepositoryAsync(async serviceProvider =>
            {
                var routeRepository = serviceProvider.GetRequiredService<IRouteRepository>();
                var routes = await routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
                return GetMessageCreator().CreateSelectHotelZoneLocationMessage(context.UserNumber, routes, languageId);
            });
        }
    }
}