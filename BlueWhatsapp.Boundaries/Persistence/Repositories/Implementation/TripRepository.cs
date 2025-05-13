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
        IEnumerable<Trip> models = await GetAllActiveQuery(false)
            .Include(t => t.Route)
            .ThenInclude( route => route.Hotels )
            .ThenInclude( hotel => hotel.HotelSchedules )
            .ThenInclude( hotelSchedules => hotelSchedules.Schedule )
            .ToListAsync()
            .ConfigureAwait(true);

        return models.Select(m => m.ToCoreTrip());
    }

    /// <inheritdoc/>
    async Task<CoreTrip?> ITripRepository.GetTripByIdAsync(int id)
    {
        Trip? model = await _dbSet
            .Include(t => t.Route)
            .Include(t => t.Reservations)
            .FirstOrDefaultAsync(t => t.Id == id)
            .ConfigureAwait(true);

        return model?.ToCoreTrip();
    }

    /// <inheritdoc/>
    async Task<CoreTrip> ITripRepository.CreateTripAsync(CoreTrip trip)
    {
        Trip newTrip = new Trip
        {
            TripName = trip.TripName,
            IsActiveForToday = trip.IsActiveForToday,
            RouteId = trip.Route?.Id ?? 0,
            MaxCapacity = trip.MaxCapacity
        };

        Trip createdTrip = await AddAsync(newTrip).ConfigureAwait(true);

        // Add schedules if provided
        if (trip.Schedules.Any())
        {
            await _dbContext.SaveChangesAsync();
        }

        return (await ((ITripRepository)this).GetTripByIdAsync(createdTrip.Id))!;
    }

    /// <inheritdoc/>
    async Task ITripRepository.UpdateTripAsync(CoreTrip trip)
    {
        try
        {
            Arguments.NotNull(trip, nameof(trip));
            Arguments.NotEmptyOrWhiteSpaceOnly(trip.TripName, nameof(trip.TripName));

            Trip? existingTrip = await _dbSet
                .FirstOrDefaultAsync(t => t.Id == trip.Id)
                .ConfigureAwait(true);

            if (existingTrip == null)
            {
                throw new InvalidOperationException("Trip not found");
            }

            existingTrip.TripName = trip.TripName;
            existingTrip.IsActiveForToday = trip.IsActiveForToday;
            existingTrip.RouteId = trip.Route?.Id ?? 0;
            existingTrip.MaxCapacity = trip.MaxCapacity;

            // Update schedules
            if (trip.Schedules != null)
            {
                // Remove existing schedules
                await _dbContext.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error updating trip: {ex.Message}");
            throw;
        }
    }

    /// <inheritdoc/>
    async Task ITripRepository.DeleteTripAsync(int id)
    {
        var trip = await _dbSet
            .FirstOrDefaultAsync(t => t.Id == id);

        if (trip != null)
        {
            // Remove associated schedules

            // Soft delete the trip
            await SoftDeleteAsync(id).ConfigureAwait(true);
            await _dbContext.SaveChangesAsync().ConfigureAwait(true);
        }
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