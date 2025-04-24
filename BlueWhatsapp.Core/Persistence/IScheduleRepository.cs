using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Models.Schedule;
using BlueWhatsapp.Core.Models.Users;

namespace BlueWhatsapp.Core.Persistence;

public interface IScheduleRepository
{
    /// <summary>
    /// Asynchronously retrieves all schedules from the repository.
    /// </summary>
    /// <returns>Returns a task that represents the asynchronous operation, containing a collection of all schedules.</returns>
    Task<IEnumerable<CoreSchedule>> GetAllSchedulesAsync();

    /// <summary>
    /// Asynchronously retrieves a schedule by its ID.
    /// </summary>
    /// <param name="id">The ID of the schedule to retrieve.</param>
    /// <returns>Returns a task that represents the asynchronous operation, containing the schedule with the specified ID.</returns>
    Task<CoreSchedule?> GetScheduleByIdAsync(int id);

    /// <summary>
    /// Asynchronously persists a schedule into the repository.
    /// </summary>
    /// <param name="schedule">The schedule to be persisted.</param>
    /// <returns>Returns a task representing the asynchronous operation.</returns>
    Task PersistAsync(CoreSchedule schedule);

    /// <summary>
    /// Asynchronously updates a schedule in the repository.
    /// </summary>
    /// <param name="schedule">The schedule to be updated.</param>
    /// <returns>Returns a task representing the asynchronous operation.</returns>
    Task UpdateAsync(CoreSchedule schedule);

    /// <summary>
    /// Asynchronously deletes a schedule from the repository.
    /// </summary>
    /// <param name="id">The ID of the schedule to delete.</param>
    /// <returns>Returns a task representing the asynchronous operation.</returns>
    Task DeleteAsync(int id);

    /// <summary>
    /// Asynchronously retrieves paginated schedules from the repository.
    /// </summary>
    /// <param name="page">The page number to retrieve.</param>
    /// <param name="pageSize">The number of schedules per page.</param>
    /// <returns>Returns a task that represents the asynchronous operation, containing a collection of paginated schedules.</returns>
    Task<IEnumerable<CoreSchedule>> GetSchedulesPaginated(int page, int pageSize = 20);

    /// <summary>
    /// Asynchronously retrieves the total number of schedules in the repository.
    /// </summary>
    /// <returns>Returns a task that represents the asynchronous operation, containing the total number of schedules.</returns> 
    Task<int> GetTotalSchedulesAsync();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<IEnumerable<CoreSchedule>> GetSchedulesByHotelId(int id);
}
