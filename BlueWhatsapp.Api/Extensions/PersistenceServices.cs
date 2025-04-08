using BlueWhatsapp.Boundaries.Persistence;
using BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Api.Extensions;

/// <summary>
/// Provides configuration for persistence-related services in the application, including database contexts
/// and repositories required for data access and management.
/// </summary>
internal static class PersistenceServices
{
    /// <summary>
    /// Configures persistence-related services for the application, including the SQLite database context
    /// and associated repositories.
    /// </summary>
    /// <param name="builder">The <see cref="WebApplicationBuilder"/> used to configure services for the application.</param>
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
        builder.Services.AddTransient<IConversationStateRepository, ConversationStateRepository>();
        builder.Services.AddTransient<IUserRepository, UserRepository>();
    }
}