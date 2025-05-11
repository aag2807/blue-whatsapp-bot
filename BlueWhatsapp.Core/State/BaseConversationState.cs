using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.State;

public abstract class BaseConversationState : IConversationState
{
    private ServiceLocator Services => ServiceLocator.Instance;
    
    protected string I_DONT_KNOW_OPTION = "-1";

    public abstract ConversationStep StateId { get; }

    public abstract Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage);

    // Helper to determine next state based on user input
    protected ConversationStep DetermineNextState(string userMessage, ConversationStep defaultNextState)
    {
        return defaultNextState;
    }

    protected IMessageCreator GetMessageCreator()
    {
        return Services.GetMessageCreator();
    }

    protected IHotelRepository GetHotelRepository()
    {
        return Services.GetHotelRepository();
    }

    protected IRouteRepository GetRouteRepository()
    {
        return Services.GetRouteRepository();
    }

    protected IScheduleRepository GetScheduleRepository()
    {
        return Services.GetScheduleRepository();
    }
    
    protected async Task<TResult> ExecuteRepositoryAsync<TResult>(Func<IServiceProvider, Task<TResult>> func)
    {
        return await Services.ExecuteRepositoryAsync(func);
    }
}