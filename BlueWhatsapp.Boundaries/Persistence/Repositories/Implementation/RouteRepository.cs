
using BlueWhatsapp.Core.Models;
using BlueWhatsapp.Core.Persistence;
using BlueWhatsapp.Core.Logger;
using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Models.Route;
using Microsoft.EntityFrameworkCore;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories.Implementation;

public sealed class RouteRepository : BaseRepository<Route>, IRouteRepository
{
    public RouteRepository(IWhatsappBlueContext dbContext, IAppLogger logger) : base(dbContext, logger)
    {
    }

    async Task<IEnumerable<CoreRoute>> IRouteRepository.GetAllRoutesAsync()
    {
        var routes =  await GetAllAsync(false).ConfigureAwait(true);
        return routes.Select(r => new CoreRoute(r.Id, r.Name, r.Description));
    }   

    async Task<CoreRoute?> IRouteRepository.GetRouteByIdAsync(int id)
    {
        var route = await GetByIdAsync(id, false).ConfigureAwait(true);
        return route != null ? new CoreRoute(route.Id, route.Name, route.Description) : null;
    }

    async Task<CoreRoute> IRouteRepository.CreateRouteAsync(CoreRoute route)
    {
        Route newRoute = new Route
        {
            Name = route.Name,
            Description = route.Description
        };

        Route createdRoute = await AddAsync(newRoute).ConfigureAwait(true);

        return new CoreRoute(createdRoute.Id, createdRoute.Name, createdRoute.Description);
    }

    async Task IRouteRepository.UpdateRouteAsync(CoreRoute route)
    {
        Arguments.NotNull(route, nameof(route));
        Arguments.NotEmptyOrWhiteSpaceOnly(route.Name, nameof(route.Name));
        Arguments.NotEmptyOrWhiteSpaceOnly(route.Description, nameof(route.Description));

        Route? existingRoute =  await _dbContext.Routes.FirstOrDefaultAsync(r => r.Id == route.Id).ConfigureAwait(true);
        Arguments.NotNull(existingRoute, nameof(existingRoute));

        if (existingRoute == null)
        {
            throw new Exception("Route not found");
        }

        existingRoute.Name = route.Name;
        existingRoute.Description = route.Description;
        _dbContext.Update(existingRoute);

        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }       

    async Task IRouteRepository.DeleteRouteAsync(int id)
    {
        Route? route = await GetByIdAsync(id, false).ConfigureAwait(true);
        Arguments.NotNull(route, nameof(route));

        _dbContext.Routes.Remove(route!);

        await _dbContext.SaveChangesAsync().ConfigureAwait(true);
    }
}
