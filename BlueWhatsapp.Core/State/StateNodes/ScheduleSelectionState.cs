using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Utils;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.State.StateNodes;

public class ScheduleSelectionState : BaseConversationState
{
    public override ConversationStep StateId => ConversationStep.ScheduleSelection;

    public override async Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage)
    {
        IMessageCreator messageCreator = GetMessageCreator();
        int languageId = GetLanguageId(context);
        
        // Check if user selected "I'll text later" option
        if (userMessage.Equals("99", StringComparison.OrdinalIgnoreCase) || 
            userMessage.Contains("analizar", StringComparison.OrdinalIgnoreCase) ||
            userMessage.Contains("later", StringComparison.OrdinalIgnoreCase))
        {
            context.CurrentStep = ConversationStep.WillTextLater;
            return messageCreator.CreateWillTextLaterMessage(context.UserNumber, languageId);
        }

        // Validate schedule selection
        if (int.TryParse(userMessage, out int scheduleId) && scheduleId > 0)
        {
            context.ScheduleId = userMessage;
            context.CurrentStep = ConversationStep.AskForFullName;
            
            // Proceed to collect user information
            return messageCreator.CreateAskingForNameMessage(context.UserNumber, languageId);
        }
        else
        {
            // Invalid schedule selection, ask again
            return await ExecuteRepositoryAsync(async serviceProvider =>
            {
                IHotelRepository hotelRepository = serviceProvider.GetRequiredService<IHotelRepository>();
                IScheduleRepository scheduleRepository = serviceProvider.GetRequiredService<IScheduleRepository>();

                var hotel = await hotelRepository.GetHotelByIdAsync(int.Parse(context.HotelId)).ConfigureAwait(true);
                var schedules = await scheduleRepository.GetSchedulesByHotelId(hotel!.Id).ConfigureAwait(true);

                return messageCreator.CreateTimeFrameSelectionMessage(context.UserNumber, hotel, schedules, languageId);
            });
        }
    }
}