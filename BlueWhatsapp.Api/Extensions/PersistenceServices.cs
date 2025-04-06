using BlueWhatsapp.Boundaries.Persistence;
using BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Api.Extensions;

/// <summary>
/// 
/// </summary>
internal static class PersistenceServices
{
    internal static void ConfigurePersistenceServices(this WebApplicationBuilder builder)
    {
        //sqlite db context
        builder.Services.AddDbContext<WhatsappBlueContext>(options =>
        {
            var projectRoot = Directory.GetCurrentDirectory();
            var dbPath = Path.Combine(projectRoot, "WhatsappApp.db"); 
            options.UseSqlite($"Data Source={dbPath}");
        });
        
        builder.Services.AddTransient<IWhatsappBlueContext, WhatsappBlueContext>();

        //repositories
        builder.Services.AddTransient<IMessageRepository, MessageRepository>();
    }
}