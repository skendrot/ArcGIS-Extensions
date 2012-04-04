using System.Collections.Generic;
using ESRI.ArcGIS.esriSystem;

// ReSharper disable CheckNamespace
namespace VisuallyLocated.ArcGIS.Extensions
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Provides extension methods for ArcGIS COM collections
    /// </summary>
    public static class SystemEnumerableExtensions
    {
        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumBSTR"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumBSTR"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the strings from the input source.</returns>
        public static IEnumerable<string> ToEnumerable(this IEnumBSTR source)
        {
            if (source != null)
            {
                source.Reset();
                string str = source.Next();
                while (str != null)
                {
                    yield return str;
                    str = source.Next();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="ILongArray"/>
        /// </summary>
        /// <param name="source">An <see cref="ILongArray"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the numbers from the input source.</returns>
        public static IEnumerable<int> ToEnumerable(this ILongArray source)
        {
            if (source != null)
            {
                for (int i = 0; i < source.Count; i++)
                {
                    yield return source.Element[i];
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IArray"/>
        /// </summary>
        /// <param name="source">An <see cref="IArray"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the objects from the input source.</returns>
        public static IEnumerable<object> ToEnumerable(this IArray source)
        {
            if (source != null)
            {
                for (int i = 0; i < source.Count; i++)
                {
                    yield return source.Element[i];
                }
            }
        }
    }
}
