using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class HotelRepository : BaseRepository<Hotel>, IHotelRepository
{
    public HotelRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }

    /// <inheritdoc/>
    async Task<CoreHotel> IHotelRepository.CreateHotelAsync(CoreHotel hotel)
    {
        Hotel newHotel = Hotel.FromCoreHotel(hotel);

        Hotel createdHotel = await AddAsync(newHotel).ConfigureAwait(true);

        return createdHotel.ToCoreHotel();
    }

    /// <inheritdoc/>
    async Task IHotelRepository.DeleteHotelAsync(int id)
    {
        await SoftDeleteAsync(id).ConfigureAwait(true);
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreHotel>> IHotelRepository.GetAllHotelsAsync()
    {
        IReadOnlyList<Hotel> hotels = await GetAllActiveAsync().ConfigureAwait(true);

        return hotels.Select(h => h.ToCoreHotel());
    }
            
    /// <inheritdoc/>
    async Task<CoreHotel?> IHotelRepository.GetHotelByIdAsync(int id)
    {
        Hotel? hotel = await GetByIdAsync(id).ConfigureAwait(true);

        return hotel?.ToCoreHotel();
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreHotel>> IHotelRepository.GetHotelsByRouteIdAsync(int routeId)
    {
        IReadOnlyList<Hotel> hotels = await GetAllActiveAsync().ConfigureAwait(true);

        return hotels.Where(h => h.RouteId == routeId).Select(h => h.ToCoreHotel());
    }

    /// <inheritdoc/>
    async Task IHotelRepository.UpdateHotelAsync(CoreHotel hotel)
    {
        Hotel updatedHotel = Hotel.FromCoreHotel(hotel);

        await UpdateAsync(updatedHotel).ConfigureAwait(true);
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }
}