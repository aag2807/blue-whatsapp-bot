using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlueWhatsapp.Core.Utils;

public class ServiceLocator
{
    private static ServiceLocator? _instance;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private readonly IAppLogger _logger;

    private ServiceLocator(IServiceScopeFactory serviceScopeFactory, IAppLogger logger)
    {
        _serviceScopeFactory = serviceScopeFactory;
        _logger = logger;
    }

    /// <summary>
    /// Initializes the ServiceLocator with the application's service scope factory.
    /// </summary>
    public static void Initialize(IServiceScopeFactory serviceScopeFactory, IAppLogger logger)
    {
        _instance = new ServiceLocator(serviceScopeFactory, logger);
    }

    /// <summary>
    /// Gets the current instance of the ServiceLocator.
    /// </summary>
    public static ServiceLocator Instance
    {
        get
        {
            if (_instance == null)
            {
                throw new InvalidOperationException("ServiceLocator not initialized. Call Initialize() first.");
            }

            return _instance;
        }
    }

    /// <summary>
    /// Executes a repository operation within a properly managed scope.
    /// IMPORTANT: Use this method for any operation that accesses the database.
    /// </summary>
    public async Task<TResult> ExecuteRepositoryAsync<TResult>(Func<IServiceProvider, Task<TResult>> func)
    {
        using var scope = _serviceScopeFactory.CreateScope();
        var serviceProvider = scope.ServiceProvider;

        try
        {
            return await func(serviceProvider);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error executing repository operation: {ex.Message}");
            return default(TResult);
        }
    }

    /// <summary>
    /// Executes multiple repository operations within a single scope.
    /// </summary>
    public async Task ExecuteInTransactionAsync(Func<IServiceProvider, Task> action)
    {
        using var scope = _serviceScopeFactory.CreateScope();
        var serviceProvider = scope.ServiceProvider;

        try
        {
            // For DbContext with explicit transaction support
            // var dbContext = serviceProvider.GetRequiredService<WhatsappBlueContext>();
            // using var transaction = await dbContext.Database.BeginTransactionAsync();

            await action(serviceProvider);

            // await transaction.CommitAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error executing transaction: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Gets a service of the specified type within a fresh scope.
    /// CAUTION: Do not use this for DbContext or repositories! Use ExecuteRepositoryAsync instead.
    /// </summary>
    public T GetService<T>() where T : class
    {
        // Only use this for simple services that don't involve DbContext
        using var scope = _serviceScopeFactory.CreateScope();
        return scope.ServiceProvider.GetRequiredService<T>();
    }

    // Convenience property for logger (singleton, so safe to cache)
    public IAppLogger Logger => _logger;

    // Helper methods for services that don't involve the database
    public IMessageCreator GetMessageCreator() => GetService<IMessageCreator>();

    // Convenience methods for common services
    public IHotelRepository GetHotelRepository() => GetService<IHotelRepository>();
    public IRouteRepository GetRouteRepository() => GetService<IRouteRepository>();
    public IScheduleRepository GetScheduleRepository() => GetService<IScheduleRepository>();
    public IReservationRepository GetReservationRepository() => GetService<IReservationRepository>();
    public ITripRepository GetTripRepository() => GetService<ITripRepository>();
    public IHotelMatcher GetHotelMatcher() => GetService<IHotelMatcher>();
}