using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Api.Extensions;

public static class ServiceLocatorExtensions
{
    public static void InitializeServiceLocator(IServiceProvider serviceProvider)
    {
        IAppLogger logger = serviceProvider.GetRequiredService<IAppLogger>();
        IServiceScopeFactory serviceScopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
        
        ServiceLocator.Initialize(serviceScopeFactory, logger);
    }
}