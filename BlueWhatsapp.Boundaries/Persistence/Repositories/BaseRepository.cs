using System.Linq.Expressions;
using BlueWhatsapp.Boundaries.Persistence.Models;
using BlueWhatsapp.Core.Logger;
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
    protected readonly IAppLogger _logger;

    protected BaseRepository(IWhatsappBlueContext dbContext, IAppLogger logger)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
        _logger = logger;
    }

    /// <summary>
    /// Helper method to filter entities by the current day
    /// </summary>
    /// <returns>Expression that filters entities to the current day</returns>
    protected Expression<Func<TEntity, bool>> GetSameDayFilter()
    {
        var today = DateTime.UtcNow.Date;
        return e => e.CreatedTime.Date == today;
    }

    /// <summary>
    /// Apply all standard filters (active status and same day)
    /// </summary>
    /// <param name="query">Query to filter</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>Filtered query</returns>
    protected IQueryable<TEntity> ApplyStandardFilters(
        IQueryable<TEntity> query,
        bool includeInactive = false,
        bool filterByToday = true)
    {
        if (!includeInactive)
        {
            query = query.Where(e => e.IsActive);
        }

        if (filterByToday)
        {
            var today = DateTime.UtcNow.Date;
            query = query.Where(e => e.CreatedTime.Date == today);
        }

        return query;
    }

    #region Read Operations

    /// <summary>
    /// Get entity by ID
    /// </summary>
    /// <param name="id">Entity ID</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>Entity if found, null otherwise</returns>
    public virtual async Task<TEntity?> GetByIdAsync(int id, bool filterByToday = true)
    {
        if (!filterByToday)
        {
            return await _dbSet.FindAsync(id);
        }

        var entity = await _dbSet.FindAsync(id);
        if (entity != null && entity.CreatedTime.Date != DateTime.UtcNow.Date)
        {
            return null;
        }

        return entity;
    }

    /// <summary>
    /// Search all string properties in an entity to see if the string value is present or partially matches
    /// </summary>
    /// <param name="value">Value to search for</param>
    /// <returns>List of entities that match the search</returns>
    public virtual async Task<IReadOnlyList<TEntity>> SearchAsync(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return await _dbSet.ToListAsync();
        }

        // Get all string properties of the entity
        IEnumerable<System.Reflection.PropertyInfo> stringProperties = typeof(TEntity).GetProperties()
            .Where(p => p.PropertyType == typeof(string));

        ParameterExpression parameter = Expression.Parameter(typeof(TEntity), "e");
        Expression combinedExpression = null;

        foreach (var prop in stringProperties)
        {
            MemberExpression propertyAccess = Expression.Property(parameter, prop);
            var constant = Expression.Constant(value, typeof(string));

            // e.Property.Contains(value)
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var containsExpression = Expression.Call(propertyAccess, containsMethod, constant);

            // Handle null properties
            var propertyNotNull = Expression.NotEqual(propertyAccess, Expression.Constant(null, typeof(string)));
            var safePropCheck = Expression.AndAlso(propertyNotNull, containsExpression);

            // Combine with OR
            if (combinedExpression == null)
            {
                combinedExpression = safePropCheck;
            }
            else
            {
                combinedExpression = Expression.OrElse(combinedExpression, safePropCheck);
            }
        }

        if (combinedExpression == null)
        {
            return new List<TEntity>().AsReadOnly();
        }

        // Create the lambda expression
        Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(combinedExpression, parameter);

        return await _dbSet.Where(lambda).ToListAsync();
    }

    /// <summary>
    /// Get all active entities
    /// </summary>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>List of all active entities</returns>
    public virtual async Task<IReadOnlyList<TEntity>> GetAllActiveAsync(bool filterByToday = true)
    {
        var query = _dbSet.Where(e => e.IsActive);

        if (filterByToday)
        {
            var today = DateTime.UtcNow.Date;
            query = query.Where(e => e.CreatedTime.Date == today);
        }

        return await query.ToListAsync();
    }

    /// <summary>
    /// Get all active entities
    /// </summary>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>List of all active entities</returns>
    public virtual System.Linq.IQueryable<TEntity> GetAllActiveQuery(bool filterByToday = true)
    {
        var query = _dbSet.Where(e => e.IsActive);

        if (filterByToday)
        {
            var today = DateTime.UtcNow.Date;
            query = query.Where(e => e.CreatedTime.Date == today);
        }

        return query;
    }

    /// <summary>
    /// Get all entities (including inactive ones)
    /// </summary>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>List of all entities</returns>
    public virtual async Task<IReadOnlyList<TEntity>> GetAllAsync(bool filterByToday = true)
    {
        var query = _dbSet.AsQueryable();

        if (filterByToday)
        {
            var today = DateTime.UtcNow.Date;
            query = query.Where(e => e.CreatedTime.Date == today);
        }

        return await query.ToListAsync();
    }

    /// <summary>
    /// Find entities based on a predicate
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>List of entities matching the condition</returns>
    public virtual async Task<IReadOnlyList<TEntity>> FindAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool includeInactive = false,
        bool filterByToday = true)
    {
        var query = ApplyStandardFilters(_dbSet, includeInactive, filterByToday);
        return await query.Where(predicate).ToListAsync();
    }

    /// <summary>
    /// Get first entity matching a condition or null if none found
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>First entity matching the condition or null</returns>
    public virtual async Task<TEntity?> GetFirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool includeInactive = false,
        bool filterByToday = true)
    {
        var query = ApplyStandardFilters(_dbSet, includeInactive, filterByToday);
        return await query.FirstOrDefaultAsync(predicate);
    }

    /// <summary>
    /// Check if any entity matches the given condition
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>True if at least one entity matches, false otherwise</returns>
    public virtual async Task<bool> ExistsAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool includeInactive = false,
        bool filterByToday = true)
    {
        var query = ApplyStandardFilters(_dbSet, includeInactive, filterByToday);
        return await query.AnyAsync(predicate);
    }

    /// <summary>
    /// Count entities matching a condition
    /// </summary>
    /// <param name="predicate">Filter condition</param>
    /// <param name="includeInactive">Whether to include inactive entities</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>Count of matching entities</returns>
    public virtual async Task<int> CountAsync(
        Expression<Func<TEntity, bool>>? predicate = null,
        bool includeInactive = false,
        bool filterByToday = true)
    {
        var query = ApplyStandardFilters(_dbSet, includeInactive, filterByToday);

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
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>Updated entity</returns>
    public virtual async Task<TEntity> UpdateAsync(TEntity entity, bool filterByToday = false)
    {
        if (filterByToday)
        {
            var existingEntity = await _dbSet.FindAsync(entity.Id);
            if (existingEntity == null || existingEntity.CreatedTime.Date != DateTime.UtcNow.Date)
            {
                throw new InvalidOperationException($"Entity with ID {entity.Id} not found for today's date or is not eligible for update.");
            }
        }

        entity.ModifiedTime = DateTime.UtcNow;

        _dbContext.Entry(entity).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();

        return entity;
    }

    /// <summary>
    /// Soft delete an entity (mark as inactive)
    /// </summary>
    /// <param name="id">Entity ID</param>
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>True if successfully deleted, false if entity not found</returns>
    public virtual async Task<bool> SoftDeleteAsync(int id, bool filterByToday = true)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null)
        {
            return false;
        }

        if (filterByToday && entity.CreatedTime.Date != DateTime.UtcNow.Date)
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
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>True if successfully deleted, false if entity not found</returns>
    public virtual async Task<bool> HardDeleteAsync(int id, bool filterByToday = true)
    {
        var entity = await _dbSet.FindAsync(id);

        if (entity == null)
        {
            return false;
        }

        if (filterByToday && entity.CreatedTime.Date != DateTime.UtcNow.Date)
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
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>Number of entities updated</returns>
    public virtual async Task<int> BulkUpdateAsync(
        Expression<Func<TEntity, bool>> predicate,
        Action<TEntity> updateAction,
        bool filterByToday = true)
    {
        var query = _dbSet.Where(predicate);

        if (filterByToday)
        {
            var today = DateTime.UtcNow.Date;
            query = query.Where(e => e.CreatedTime.Date == today);
        }

        var entities = await query.ToListAsync();

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
    /// <param name="filterByToday">Whether to filter by today's date</param>
    /// <returns>Number of entities deleted</returns>
    public virtual async Task<int> BulkSoftDeleteAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool filterByToday = true)
    {
        return await BulkUpdateAsync(predicate, entity => entity.IsActive = false, filterByToday);
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