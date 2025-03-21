using System.Reflection;

namespace BlueWhatsapp.Core.Utils;

/// <summary>
/// Static class that handles object property mapping via reflection
/// </summary>
public static class PropertyMapper
{
    /// <summary>
        /// Maps properties from source object to target object using reflection
        /// </summary>
        /// <typeparam name="TSource">Type of source object</typeparam>
        /// <typeparam name="TTarget">Type of target object</typeparam>
        /// <param name="source">Source object instance</param>
        /// <param name="target">Target object instance</param>
        public static void MapProperties<TSource, TTarget>(TSource source, TTarget target)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            var sourceProperties = typeof(TSource).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var targetProperties = typeof(TTarget).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var sourceProp in sourceProperties)
            {
                var targetProp = targetProperties.FirstOrDefault(p => 
                    p.Name == sourceProp.Name && 
                    p.PropertyType == sourceProp.PropertyType);

                if (targetProp != null && targetProp.CanWrite)
                {
                    var value = sourceProp.GetValue(source);
                    targetProp.SetValue(target, value);
                }
            }
        }

        /// <summary>
        /// Creates a new instance of TTarget and maps properties from source
        /// </summary>
        /// <typeparam name="TSource">Type of source object</typeparam>
        /// <typeparam name="TTarget">Type of target object</typeparam>
        /// <param name="source">Source object instance</param>
        /// <returns>New target instance with mapped properties</returns>
        public static TTarget MapTo<TSource, TTarget>(TSource source) where TTarget : new()
        {
            var target = new TTarget();
            MapProperties(source, target);
            return target;
        } 
}