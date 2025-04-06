using BlueWhatsapp.Core.Services;

namespace BlueWhatsapp.Api.Extensions;

/// <summary>
/// 
/// </summary>
internal static class DomainServiceExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    internal static void ConfigureDomainServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IWhatsappCloudService, WhatsappCloudService>();
        builder.Services.AddTransient<IMessageService, MessageService>();
    }
}