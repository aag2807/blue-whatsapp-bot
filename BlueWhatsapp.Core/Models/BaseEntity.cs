using System.Reflection;
using BlueWhatsapp.Core.Utils;

namespace BlueWhatsapp.Core.Models;

public abstract class BaseEntity
{
    /// <summary>
    /// Maps properties from source object to this entity
    /// </summary>
    protected void MapFrom<TSource>(TSource source)
    {
        PropertyMapper.MapProperties(source, this);
    }

    /// <summary>
    /// Generic factory method that creates an entity of type TEntity from data of type TData
    /// </summary>
    public static TEntity Create<TEntity, TData>(TData data) where TEntity : class, new()
    {
        var entity = new TEntity();
        PropertyMapper.MapProperties(data, entity);
        return entity;
    }

    /// <summary>
    /// Factory method with inline initialization using a setup action
    /// </summary>
    public static TEntity Create<TEntity, TData>(TData data, Action<TEntity> setupAction) where TEntity : BaseEntity, new()
    {
        var entity = Create<TEntity, TData>(data);
        setupAction?.Invoke(entity);
        return entity;
    }
}