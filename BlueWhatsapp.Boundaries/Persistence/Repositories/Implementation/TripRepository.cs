using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Enums;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Core.Models.Messages;
using BlueWhatsapp.Core.Models.Trip;
using BlueWhatsapp.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class TripRepository : BaseRepository<Trip>, ITripRepository
{
    public TripRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreTrip>> ITripRepository.GetAllTripsAsync()
    {
        IReadOnlyList<Trip> models = await GetAllAsync(false).ConfigureAwait(true);

        return models.Select(m => m.ToCoreTrip());
    }

    /// <inheritdoc/>
    async Task<CoreTrip?> ITripRepository.GetTripByIdAsync(int id)
    {
        Trip? model = await GetByIdAsync(id).ConfigureAwait(true);
        
        return model?.ToCoreTrip();
    }

    /// <inheritdoc/>
    async Task<CoreTrip> ITripRepository.CreateTripAsync(CoreTrip trip)
    {
        Trip newTrip = new Trip
        {
            TripName = trip.TripName,
            IsActiveForToday = trip.IsActiveForToday
        };

        Trip createdTrip = await AddAsync(newTrip).ConfigureAwait(true);    

        return createdTrip.ToCoreTrip();
    }

    /// <inheritdoc/>
    async Task ITripRepository.UpdateTripAsync(CoreTrip trip)
    {
        Arguments.NotNull(trip, nameof(trip));
        Arguments.NotEmptyOrWhiteSpaceOnly(trip.TripName, nameof(trip.TripName));
        
        Trip? existingTrip = await GetByIdAsync(trip.Id).ConfigureAwait(true);

        if (existingTrip == null)
        {
            throw new InvalidOperationException("Trip not found");
        }

        existingTrip.TripName = trip.TripName;
        existingTrip.IsActiveForToday = trip.IsActiveForToday;

        await UpdateAsync(existingTrip).ConfigureAwait(true);
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task ITripRepository.DeleteTripAsync(int id)
    {
        await SoftDeleteAsync(id).ConfigureAwait(true);
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }
    
    /// <inheritdoc/>
    async Task ITripRepository.UpdateTripStatusAsync(int id, bool isActiveForToday)
    {
        Trip? trip = await GetByIdAsync(id).ConfigureAwait(true);
        
        if (trip == null)
        {
            throw new InvalidOperationException("Trip not found");
        }

        trip.IsActiveForToday = isActiveForToday;
        await UpdateAsync(trip).ConfigureAwait(true);
        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }

    /// <inheritdoc/>
    async Task<IEnumerable<CoreTrip>> ITripRepository.SearchTripsAsync(string value)
    {
        IReadOnlyList<Trip> models = await SearchAsync(value).ConfigureAwait(true);

        return models.Select(m => m.ToCoreTrip());
    }
}
