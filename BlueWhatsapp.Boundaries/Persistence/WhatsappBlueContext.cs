using System.Reflection;
using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Triplex.Validations;

namespace BlueWhatsapp.Boundaries.Persistence;

public class WhatsappBlueContext : DbContext, IWhatsappBlueContext
{
    /// <summary>
    /// Builds an instance of <see cref="WhatsappBlueContext"/> and passes the Dbcontext Options to base class
    /// </summary>
    /// <param name="options">An instance of <see cref="DbContextOptions"/> with configured data</param>
    public WhatsappBlueContext(DbContextOptions<WhatsappBlueContext> options) : base(options)
    {
    }

    /// <summary>
    /// Override on model creating
    /// </summary>
    /// <param name="modelBuilder"></param>
    /// <exception cref="ArgumentNullException"></exception>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Arguments.NotNull(modelBuilder, nameof(modelBuilder));

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    #region [DBSET]

    /// <inheritdoc />
    DbSet<Message> IWhatsappBlueContext.Messages { get; set; }

    /// <inheritdoc />
    DbSet<User> IWhatsappBlueContext.Users { get; set; }
    
    /// <inheritdoc />
    DbSet<Hotel> IWhatsappBlueContext.Hotels { get; set; }

    /// <inheritdoc />
    DbSet<HotelSchedule> IWhatsappBlueContext.HotelSchedules { get; set; }
    
    /// <inheritdoc />
    DbSet<Route> IWhatsappBlueContext.Routes { get; set; }
    
    /// <inheritdoc />
    DbSet<Schedule> IWhatsappBlueContext.Schedules { get; set; }

    /// <inheritdoc />
    DbSet<Reservation> IWhatsappBlueContext.Reservations { get; set; }

    /// <inheritdoc />
    DbSet<Trip> IWhatsappBlueContext.Trips { get; set; }

    #endregion
    
    #region Context methods implementations

    /// <inheritdoc />
    int IWhatsappBlueContext.SaveChanges() => SaveChanges();

    /// <inheritdoc />
    async Task<int> IWhatsappBlueContext.SaveChangesAsync() => await SaveChangesAsync().ConfigureAwait(true);

    /// <inheritdoc />
    async Task<int> IWhatsappBlueContext.SaveChangesAsync(CancellationToken cancellationToken) => await SaveChangesAsync(cancellationToken).ConfigureAwait(true);

    /// <inheritdoc />
    async Task<int> IWhatsappBlueContext.SaveChangesWithRollBack()
    {
        try
        {
            return await SaveChangesAsync();
        }
        catch (Exception e)
        {
            await Database.RollbackTransactionAsync();
            throw;
        }
    }

    /// <inheritdoc />
    EntityEntry IWhatsappBlueContext.Update<TEntity>(TEntity entity) => Update(entity);
    
    /// <inheritdoc />
    void IWhatsappBlueContext.UpdateRange<TEntity>(IEnumerable<TEntity> entity) => UpdateRange(entity);

    /// <inheritdoc />
    EntityEntry IWhatsappBlueContext.Attach(object entity) => Attach(entity);

    /// <inheritdoc />
    EntityEntry IWhatsappBlueContext.Entry<TEntity>(TEntity entity) => Entry(entity);

    /// <inheritdoc />
    async Task IWhatsappBlueContext.BeginTransaction() => await Database.BeginTransactionAsync();

    /// <inheritdoc />
    async Task IWhatsappBlueContext.Commit() => await Database.CommitTransactionAsync();

    /// <inheritdoc />
    async Task IWhatsappBlueContext.RollBack() => await Database.RollbackTransactionAsync();

    #endregion
}