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
}