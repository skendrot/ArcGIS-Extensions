using System.Collections.Generic;
using ESRI.ArcGIS.Carto;

// ReSharper disable CheckNamespace
namespace VisuallyLocated.ArcGIS.Extensions
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Provides extension methods for ArcGIS COM collections
    /// </summary>
    public static class CartoEnumerableExtensions
    {
        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="ILayer"/>
        /// </summary>
        /// <param name="source">An <see cref="IMap"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the layers from the input source.</returns>
        public static IEnumerable<ILayer> ToEnumerable(this IMap source)
        {
            if(source != null)
            {
                return source.Layers.ToEnumerable();
            }
            return new ILayer[0];
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="ILayer"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumLayer"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the layers from the input source.</returns>
        public static IEnumerable<ILayer> ToEnumerable(this IEnumLayer source)
        {
            if (source != null)
            {
                source.Reset();
                ILayer layer = source.Next();
                while (layer != null)
                {
                    yield return layer;
                    layer = source.Next();
                }
            }
        }
    }
}
