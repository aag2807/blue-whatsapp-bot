using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class HotelSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.HotelSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        bool isValidZoneSelected = userMessage != I_DONT_KNOW_OPTION;
        IMessageCreator messageCreator = GetMessageCreator()!;

        if (isValidZoneSelected)
        {
            context.ZoneId = userMessage;
            context.CurrentStep = ConversationStep.ScheduleSelection;

            return await ExecuteRepositoryAsync(async serviceProvider =>
            {
                IHotelRepository repository = serviceProvider.GetRequiredService<IHotelRepository>()!;
                IEnumerable<CoreHotel> hotelsByRoute = await repository.GetHotelsByRouteIdAsync(int.Parse(userMessage)).ConfigureAwait(true);

                return messageCreator.CreateHotelSelectionMessage(context.UserNumber, hotelsByRoute);
            });
        }

        context.CurrentStep = ConversationStep.ZoneUnknown;
        return messageCreator.CreateUnknownHotelMessage(context.UserNumber);
    }
}