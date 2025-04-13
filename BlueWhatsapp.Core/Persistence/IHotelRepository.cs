using BlueWhatsapp.Core.Models;

namespace BlueWhatsapp.Core.Persistence;
public interface IHotelRepository
{
    /// <summary>
    /// Get all hotels
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<CoreHotel>> GetAllHotelsAsync();

    /// <summary>
    /// Get a hotel by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CoreHotel?> GetHotelByIdAsync(int id);

    /// <summary>
    /// Create a new hotel
    /// </summary>
    /// <param name="hotel"></param>
    /// <returns></returns>
    Task<CoreHotel> CreateHotelAsync(CoreHotel hotel);

    /// <summary>
    /// Update a hotel
    /// </summary>
    /// <param name="hotel"></param>
    /// <returns></returns>
    Task UpdateHotelAsync(CoreHotel hotel);

    /// <summary>
    /// Delete a hotel
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteHotelAsync(int id);

    /// <summary>
    /// Get all hotels by route id
    /// </summary>
    /// <param name="routeId"></param>
    /// <returns></returns>
    Task<IEnumerable<CoreHotel>> GetHotelsByRouteIdAsync(int routeId);
}