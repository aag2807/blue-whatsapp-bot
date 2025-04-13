using BlueWhatsapp.Core.Models.Route;

namespace BlueWhatsapp.Core.Persistence;

public interface IRouteRepository
{
    /// <summary>   
    /// Get all routes
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<CoreRoute>> GetAllRoutesAsync();

    /// <summary>
    /// Get route by id 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CoreRoute?> GetRouteByIdAsync(int id);

    /// <summary>
    /// Create a new route  
    /// </summary>
    /// <param name="route"></param>
    /// <returns></returns>
    Task<CoreRoute> CreateRouteAsync(CoreRoute route);

    /// <summary>
    /// Update a route  
    /// </summary>
    /// <param name="route"></param>
    Task UpdateRouteAsync(CoreRoute route);

    /// <summary>
    /// Delete a route
    /// </summary>
    /// <param name="id"></param>
    Task DeleteRouteAsync(int id);
}

