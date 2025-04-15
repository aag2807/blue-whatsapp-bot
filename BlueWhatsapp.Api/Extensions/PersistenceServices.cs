using BlueWhatsapp.Boundaries.Persistence;
using BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;
using BlueWhatsapp.Core.Logger;
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
        builder.Services.AddTransient<IRouteRepository, RouteRepository>();
        builder.Services.AddTransient<IScheduleRepository, ScheduleRepository>();
        builder.Services.AddTransient<ITripRepository, TripRepository>();
        builder.Services.AddTransient<IHotelRepository, HotelRepository>();
        builder.Services.AddTransient<IReservationRepository, ReservationRepository>();
    }
    
    /// <summary>
    /// Runs database migrations at application startup.
    /// </summary>
    /// <param name="app">The application to configure.</param>
    internal static void MigrateDatabase(this IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var services = scope.ServiceProvider;
            try
            {
                WhatsappBlueContext context = services.GetRequiredService<WhatsappBlueContext>();
                
                context.Database.EnsureCreated();
                
                Console.WriteLine("Database migration completed successfully.");
                
                try 
                {
                    var logger = services.GetRequiredService<IAppLogger>();
                    logger.LogInfo("Database migration completed successfully.");
                }
                catch 
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while migrating the database: {ex.Message}");
                
                try 
                {
                    var logger = services.GetRequiredService<IAppLogger>();
                    logger.LogError($"An error occurred while migrating the database: {ex.Message}");
                }
                catch 
                {
                }
            }
        }
    }
}