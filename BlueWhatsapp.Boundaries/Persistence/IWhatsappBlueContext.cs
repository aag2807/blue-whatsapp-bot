using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BlueWhatsapp.Boundaries.Persistence;

/// <summary>
/// 
/// </summary>
public interface IWhatsappBlueContext
{
    /// <summary>
    /// Provides access to database related information and operations for this context.
    /// </summary>
    DatabaseFacade Database { get; }
    
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Message> Messages { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<User> Users { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Hotel> Hotels { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DbSet<HotelSchedule> HotelSchedules { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Route> Routes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<Reservation> Reservations { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Trip> Trips { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Schedule> Schedules { get; set; }
    
    /// <inheritdoc cref="DbContext.SaveChanges()"/>
    int SaveChanges();

    /// <inheritdoc cref="DbContext.SaveChangesAsync(bool, System.Threading.CancellationToken)"/>
    Task<int> SaveChangesAsync();

    /// <summary>
    /// Custom implementation of <inheritdoc cref="DbContext.SaveChangesAsync(bool, System.Threading.CancellationToken)"/>
    /// with the integration of a rollback
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesWithRollBack();

    /// <inheritdoc cref="DbContext.SaveChangesAsync(bool, System.Threading.CancellationToken)"/>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    /// <inheritdoc cref="DbContext.Update{TEntity}(TEntity)"/>
    EntityEntry Update<TEntity>(TEntity entity);

    /// <inheritdoc cref="DbContext.UpdateRange(IEnumerable{object})"/>
    void UpdateRange<TEntity>(IEnumerable<TEntity> entity);

    /// <inheritdoc cref="DbContext.Attach(object)"/>
    EntityEntry Attach(object entity);

    /// <inheritdoc cref="DbContext.Entry(object)"/>
    EntityEntry Entry<TEntity>(TEntity entity);

    /// <inheritdoc cref="DbContext.BeginTransactionAsync()"/>
    Task BeginTransaction();
    
    /// <inheritdoc cref="DbContext.CommitTransactionAsync()"/>
    Task Commit();

    /// <inheritdoc cref="DbContext.RollbackTransactionAsync()"/>
    Task RollBack();
    
    /// <inheritdoc cref="DbContext.Set()"/>
    DbSet<TEntity> Set<TEntity>() where TEntity: class;
}