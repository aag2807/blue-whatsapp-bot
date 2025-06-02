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
    /// Updates an existing reservation.
    /// </summary>
    /// <param name="reservation">The reservation to update.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task UpdateReservation(CoreReservation reservation);

    /// <summary>
    /// Retrieves all reservations ordered by creation date for the current week.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of reservations ordered by creation date for the current week.</returns>
    public Task<IEnumerable<CoreReservation>> GetAllWeeklyReservationsOrderedByCreationDate();

    /// <summary>
    /// Retrieves all reservations ordered by creation date for the current day.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of reservations ordered by creation date for the current day.</returns>
    public Task<IEnumerable<CoreReservation>> GetAllDailyReservationsOrderedByCreationDate();

    /// <summary>
    /// Retrieves all reservations ordered by creation date for the upcoming days.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of reservations ordered by creation date for the upcoming days.</returns>
    public Task<IEnumerable<CoreReservation>> GetAllUpcomingReservationsOrderedByCreationDate();

    /// <summary>
    /// Retrieves reservations by trip ID.
    /// </summary>
    /// <param name="tripId">The ID of the trip.</param>
    /// <returns>A task representing the asynchronous operation, containing an enumerable of reservations for the specified trip.</returns>
    public Task<IEnumerable<CoreReservation>> GetReservationsByTripId(int tripId);

    /// <summary>
    /// Deletes a reservation by its ID.
    /// </summary>
    /// <param name="reservationId">The ID of the reservation to delete.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task DeleteReservation(int reservationId);

    /// <summary>
    /// Cancels a reservation by marking it as cancelled instead of deleting it.
    /// </summary>
    /// <param name="reservationId">The ID of the reservation to cancel.</param>
    /// <param name="reason">The reason for cancellation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task CancelReservation(int reservationId, string reason);

    /// <summary>
    /// Reschedules a reservation by cancelling the original and creating a new one.
    /// </summary>
    /// <param name="originalReservationId">The ID of the original reservation to reschedule.</param>
    /// <param name="newReservation">The new reservation details.</param>
    /// <param name="reason">The reason for rescheduling.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public Task RescheduleReservation(int originalReservationId, CoreReservation newReservation, string reason);
}