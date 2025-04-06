using System.Linq.Expressions;
using BlueWhatsapp.Boundaries.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueWhatsapp.Boundaries.Persistence.Repositories;

/// <summary>
/// Abstract base repository for all entity repositories
/// </summary>
/// <typeparam name="TEntity">Entity type that inherits from BaseEntity</typeparam>
public abstract class BaseRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly IWhatsappBlueContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;

    protected BaseRepository(IWhatsappBlueContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    #region Read Operations

    /// <summary>
    /// Get entity by ID
    /// </summary>
    /// <param name="id">Entity ID</param>
    /// <returns>Entity if found, null otherwise</returns>
    public virtual async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    /// <summary>
    /// Get all active entities
    /// </summary>
    /// <returns>List of all active entities</returns>
    public virtual async Task<IReadOnlyList<TEntity>> GetAllActiveAsync()
    {
        return await _dbSet.Where(e => e.IsActive).ToListAsync();
    }

    /// <summary>
    /// Get all entities (including inactive ones)
    /// </summary>
    /// <returns>List of all entities</returns>
    public virtual async Task<IReadOnlyList<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    /// <summary>
    /// Find entities based on a predicate
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <returns>List of entities matching the condition</returns>
    public virtual async Task<IReadOnlyList<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, bool includeInactive = false)
    {
        IQueryable<TEntity> query = _dbSet;

        if (!includeInactive)
        {
            query = query.Where(e => e.IsActive);
        }

        return await query.Where(predicate).ToListAsync();
    }

    /// <summary>
    /// Get first entity matching a condition or null if none found
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <returns>First entity matching the condition or null</returns>
    public virtual async Task<TEntity?> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool includeInactive = false)
    {
        IQueryable<TEntity> query = _dbSet;

        if (!includeInactive)
        {
            query = query.Where(e => e.IsActive);
        }

        return await query.FirstOrDefaultAsync(predicate);
    }

    /// <summary>
    /// Check if any entity matches the given condition
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <returns>True if at least one entity matches, false otherwise</returns>
    public virtual async Task<bool> ExistsAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool includeInactive = false)
    {
        IQueryable<TEntity> query = _dbSet;

        if (!includeInactive)
        {
            query = query.Where(e => e.IsActive);
        }

        return await query.AnyAsync(predicate);
    }

    /// <summary>
    /// Count entities matching a condition
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <returns>Count of matching entities</returns>
    public virtual async Task<int> CountAsync(
        Expression<Func<TEntity, bool>>? predicate = null,
        bool includeInactive = false)
    {
        IQueryable<TEntity> query = _dbSet;

        if (!includeInactive)
        {
            query = query.Where(e => e.IsActive);
        }

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        return await query.CountAsync();
    }

    #endregion

    #region Write Operations

    /// <summary>
    /// Add a new entity
    /// </summary>
    /// <param name="entity">Entity to add</param>
    /// <returns>Added entity</returns>
    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        entity.CreatedTime = DateTime.UtcNow;
        entity.IsActive = true;

        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    /// <summary>
    /// Add multiple entities
    /// </summary>
    /// <param name="entities">Entities to add</param>
    /// <returns>Number of entities added</returns>
    public virtual async Task<int> AddRangeAsync(IEnumerable<TEntity> entities)
    {
        var utcNow = DateTime.UtcNow;

        foreach (var entity in entities)
        {
            entity.CreatedTime = utcNow;
            entity.IsActive = true;
        }

        await _dbSet.AddRangeAsync(entities);
        return await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Update an existing entity
    /// </summary>
    /// <param name="entity">Entity to update</param>
    /// <returns>Updated entity</returns>
    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        entity.ModifiedTime = DateTime.UtcNow;

        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    /// <summary>
    /// Soft delete an entity (mark as inactive)
    /// </summary>
    /// <param name="id">Entity ID</param>
    /// <returns>True if successfully deleted, false if entity not found</returns>
    public virtual async Task<bool> SoftDeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null)
        {
            return false;
        }

        entity.IsActive = false;
        entity.ModifiedTime = DateTime.UtcNow;

        await _dbContext.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Hard delete an entity (completely remove from database)
    /// </summary>
    /// <param name="id">Entity ID</param>
    /// <returns>True if successfully deleted, false if entity not found</returns>
    public virtual async Task<bool> HardDeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null)
        {
            return false;
        }

        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Bulk update entities that match a condition
    /// </summary>
    /// <param name="predicate">Condition to select entities</param>
    /// <param name="updateAction">Action to perform on each entity</param>
    /// <returns>Number of entities updated</returns>
    public virtual async Task<int> BulkUpdateAsync(Expression<Func<TEntity, bool>> predicate, Action<TEntity> updateAction)
    {
        var entities = await _dbSet.Where(predicate).ToListAsync();

        if (entities.Count == 0)
        {
            return 0;
        }

        var utcNow = DateTime.UtcNow;

        foreach (var entity in entities)
        {
            updateAction(entity);
            entity.ModifiedTime = utcNow;
        }

        return await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Bulk soft delete entities that match a condition
    /// </summary>
    /// <param name="predicate">Condition to select entities</param>
    /// <returns>Number of entities deleted</returns>
    public virtual async Task<int> BulkSoftDeleteAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await BulkUpdateAsync(predicate, entity => entity.IsActive = false);
    }

    #endregion

    #region Transaction Operations

    /// <summary>
    /// Execute operations within a transaction
    /// </summary>
    /// <param name="action">Action to perform within transaction</param>
    /// <returns>Result of the action</returns>
    public virtual async Task<TResult> ExecuteTransactionAsync<TResult>(Func<Task<TResult>> action)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            var result = await action();
            await transaction.CommitAsync();
            return result;
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    /// <summary>
    /// Execute operations within a transaction
    /// </summary>
    /// <param name="action">Action to perform within transaction</param>
    public virtual async Task ExecuteTransactionAsync(Func<Task> action)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();

        try
        {
            await action();
            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    #endregion
}