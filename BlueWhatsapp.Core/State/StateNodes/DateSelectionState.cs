using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Route;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class DateSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.DateSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        // Parse and validate the date input
        DateParser parser = new();
        string parsedDate = parser.TryParseDate(userMessage);
        
        if (!string.IsNullOrEmpty(parsedDate))
        {
            context.PickUpDate = parsedDate;
            context.CurrentStep = ConversationStep.ZoneSelection;
            
            int languageId = GetLanguageId(context);
            return GetMessageCreator().CreateSelectHotelZoneLocationMessage(context.UserNumber, 
                await GetAllRoutesAsync(), languageId);
        }
        else
        {
            // Invalid date format, ask again
            int languageId = GetLanguageId(context);
            return GetMessageCreator().CreateDatePromptMessage(context.UserNumber, languageId);
        }
    }

    private async Task<IEnumerable<CoreRoute>> GetAllRoutesAsync()
    {
        return await ExecuteRepositoryAsync(async serviceProvider =>
        {
            var routeRepository = serviceProvider.GetRequiredService<IRouteRepository>();
            return await routeRepository.GetAllRoutesAsync().ConfigureAwait(true);
        });
    }
}