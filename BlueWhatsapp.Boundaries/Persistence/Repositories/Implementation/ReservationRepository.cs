using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Reservations;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class ReservationRepository : BaseRepository<Reservation>, IReservationRepository
{
    public ReservationRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }
    
    /// <inheritdoc />
    async Task IReservationRepository.SaveReservation(CoreReservation reservation)
    {
        Reservation model = Reservation.FromCoreEntity(reservation);
        await AddAsync(model).ConfigureAwait(true);
    }
}
