using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlueWhatsapp.Boundaries.Persistence;

/// <summary>
/// 
/// </summary>
public interface IWhatsappBlueContext
{
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
}