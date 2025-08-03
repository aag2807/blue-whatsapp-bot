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
    
    protected string I_DONT_KNOW_OPTION = "99";

    public abstract ConversationStep StateId { get; }

    public abstract Task<CoreBaseMessage?> Process(CoreConversationState context, string userMessage);

    /// <summary>
    /// Gets the language ID from the conversation context, defaulting to Spanish (1) if not set
    /// </summary>
    protected int GetLanguageId(CoreConversationState context)
    {
        return int.TryParse(context.LanguageId, out int langId) && langId >= 1 && langId <= 6 ? langId : 1;
    }

    /// <summary>
    /// Helper to determine next state based on user input
    /// </summary>
    protected ConversationStep DetermineNextState(string userMessage, ConversationStep defaultNextState)
    {
        return defaultNextState;
    }

    /// <summary>
    /// Gets the message creator service
    /// </summary>
    protected IMessageCreator GetMessageCreator()
    {
        return Services.GetMessageCreator();
    }

    /// <summary>
    /// Gets the hotel repository service
    /// </summary>
    protected IHotelRepository GetHotelRepository()
    {
        return Services.GetHotelRepository();
    }

    /// <summary>
    /// Gets the route repository service
    /// </summary>
    protected IRouteRepository GetRouteRepository()
    {
        return Services.GetRouteRepository();
    }

    /// <summary>
    /// Gets the schedule repository service
    /// </summary>
    protected IScheduleRepository GetScheduleRepository()
    {
        return Services.GetScheduleRepository();
    }
    
    /// <summary>
    /// Executes a repository operation with proper scope management
    /// </summary>
    protected async Task<TResult> ExecuteRepositoryAsync<TResult>(Func<IServiceProvider, Task<TResult>> func)
    {
        return await Services.ExecuteRepositoryAsync(func);
    }

    /// <summary>
    /// Validates if the selected language is valid
    /// </summary>
    protected bool IsValidLanguageSelection(string userMessage)
    {
        return int.TryParse(userMessage, out int langId) && langId >= 1 && langId <= 6;
    }

    /// <summary>
    /// Checks if the user selected the "I don't know" option
    /// </summary>
    protected bool IsIDontKnowOption(string userMessage)
    {
        return userMessage == I_DONT_KNOW_OPTION;
    }

    /// <summary>
    /// Helper method to create localized messages with language context
    /// </summary>
    protected CoreMessageToSend CreateLocalizedMessage(CoreConversationState context, Func<int, string> messageFunc)
    {
        int languageId = GetLanguageId(context);
        string message = messageFunc(languageId);
        return new CoreMessageToSend(message, context.UserNumber);
    }

    /// <summary>
    /// Helper method to create localized interactive messages with language context
    /// </summary>
    protected CoreInteractiveMessage CreateLocalizedInteractiveMessage<T>(
        CoreConversationState context, 
        T data, 
        Func<string, T, int, CoreInteractiveMessage> messageFunc)
    {
        int languageId = GetLanguageId(context);
        return messageFunc(context.UserNumber, data, languageId);
    }
}