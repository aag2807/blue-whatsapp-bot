using BlueWhatsapp.Core.Models.Trip;

namespace BlueWhatsapp.Core.Persistence;

public interface ITripRepository
{
    /// <summary>   
    /// Get all trip    s
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<CoreTrip>> GetAllTripsAsync();

    /// <summary>
    /// Get a trip by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<CoreTrip?> GetTripByIdAsync(int id);

    /// <summary>
    /// Create a new trip
    /// </summary>
    /// <param name="trip"></param>
    /// <returns></returns>
    Task<CoreTrip> CreateTripAsync(CoreTrip trip);

    /// <summary>
    /// Update a trip
    /// </summary>
    /// <param name="trip"></param>
    /// <returns></returns>
    Task UpdateTripAsync(CoreTrip trip);

    /// <summary>
    /// Delete a trip
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task DeleteTripAsync(int id);

    /// <summary>
    /// Update the status of a trip
    /// </summary>
    /// <param name="id"></param>
    /// <param name="isActiveForToday"></param>
    /// <returns></returns>
    Task UpdateTripStatusAsync(int id, bool isActiveForToday);

    /// <summary>
    /// Search for trips by user name, user number, or route name
    /// </summary>
    /// <param name="value">Value to search for</param>
    /// <returns>List of trips that match the search</returns>
    Task<IEnumerable<CoreTrip>> SearchTripsAsync(string value);
}