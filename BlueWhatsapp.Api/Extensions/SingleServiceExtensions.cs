using BlueWhatsapp.Core.Logger;

namespace BlueWhatsapp.Api.Extensions;

internal static class SingleServiceExtensions
{
    internal static void ConfigureSingletonServices(this WebApplicationBuilder builder)
    {
        string rootDirectory = builder.Environment.ContentRootPath;
        builder.Services.AddSingleton<IAppLogger>(provider => new AppLogger(rootDirectory));
    }
}