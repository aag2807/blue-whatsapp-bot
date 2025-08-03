using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ZoneSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ZoneSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        DateParser parser = new();
        context.PickUpDate = parser.TryParseDate(userMessage);
        context.CurrentStep = ConversationStep.HotelSelection;

        return await ExecuteRepositoryAsync(async serviceProvider =>
        {
            IRouteRepository routeRepository = serviceProvider.GetRequiredService<IRouteRepository>();
            IMessageCreator messageCreator = serviceProvider.GetRequiredService<IMessageCreator>();

            IEnumerable<CoreRoute> routes = await routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
            int languageId = GetLanguageId(context);

            return messageCreator.CreateSelectHotelZoneLocationMessage(context.UserNumber, routes, languageId);
        });
    }
}