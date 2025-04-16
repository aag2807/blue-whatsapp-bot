using BlueWhatsapp.Core.Models.Reservations;

namespace BlueWhatsapp.Core.Persistence;

public interface IReservationRepository
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="reservation"></param>
    /// <returns></returns>
    public Task SaveReservation(CoreReservation reservation);

    /// <summary>
    /// Retrieves all reservations ordered by creation date for the current week.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of reservations ordered by creation date for the current week.</returns>
    public Task<IEnumerable<CoreReservation>> GetAllWeeklyReservationsOrderedByCreationDate();
}