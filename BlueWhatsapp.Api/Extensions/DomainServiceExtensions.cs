using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Services;
using BlueWhatsapp.Core.Services.ChatService;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Api.Extensions;

/// <summary>
/// Provides extension methods for configuring domain services in the application.
/// </summary>
internal static class DomainServiceExtensions
{
    /// <summary>
    /// Configures domain services necessary for the application.
    /// </summary>
    /// <param name="builder">The WebApplicationBuilder instance used to register services.</param>
    internal static void ConfigureDomainServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IWhatsappCloudService, WhatsappCloudService>();
        builder.Services.AddTransient<IMessageService, MessageService>();
        builder.Services.AddTransient<IConversationStateService, ConversationStateService>();
        builder.Services.AddTransient<IUserService, UserService>();
        builder.Services.AddTransient<IMessageCreator, MessageCreator>();
        builder.Services.AddTransient<IChatResponseService, ChatResponseResponseService>();

        builder.Services.Configure<ConversationFlowOptions>(builder.Configuration.GetSection("ConversationFlow"));
    }
}