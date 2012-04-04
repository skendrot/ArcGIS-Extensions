using System.Collections.Generic;
using ESRI.ArcGIS.Geodatabase;

// ReSharper disable CheckNamespace
namespace VisuallyLocated.ArcGIS.Extensions
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Provides extension methods for ArcGIS COM collections
    /// </summary>
    public static class GeodatabaseEnumerableExtensions
    {
        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IFields"/>
        /// </summary>
        /// <param name="source">An <see cref="IFields"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the fields from the input source.</returns>
        public static IEnumerable<IField> ToEnumerable(this IFields source)
        {
            if (source != null)
            {
                for (int i = 0; i < source.FieldCount; i++)
                {
                    yield return source.Field[i];
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumRelationshipClass"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumRelationshipClass"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the relationship classes from the input source.</returns>
        public static IEnumerable<IRelationshipClass> ToEnumerable(this IEnumRelationshipClass source)
        {
            if (source != null)
            {
                source.Reset();
                IRelationshipClass relationshipClass = source.Next();
                while (relationshipClass != null)
                {
                    yield return relationshipClass;
                    relationshipClass = source.Next();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="ICursor"/>
        /// </summary>
        /// <param name="source">An <see cref="ICursor"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the rows from the input source.</returns>
        /// <remarks>This method does not dispose of the cursor. Care should be taken to properly dispoose of all cursors</remarks>
        public static IEnumerable<IRow> ToEnumerable(this ICursor source)
        {
            if (source != null)
            {
                IRow row = source.NextRow();
                while (row != null)
                {
                    yield return row;
                    row = source.NextRow();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IFeatureCursor"/>
        /// </summary>
        /// <param name="source">An <see cref="IFeatureCursor"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the features from the input source.</returns>
        public static IEnumerable<IFeature> ToEnumerable(this IFeatureCursor source)
        {
            if (source != null)
            {
                IFeature feature = source.NextFeature();
                while (feature != null)
                {
                    yield return feature;
                    feature = source.NextFeature();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IFeatureClassContainer"/>
        /// </summary>
        /// <param name="source">An <see cref="IFeatureClassContainer"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the feature class from the input source.</returns>
        public static IEnumerable<IFeatureClass> ToEnumerable(this IFeatureClassContainer source)
        {
            if (source != null)
            {
                for (int i = 0; i < source.ClassCount; i++)
                {
                    yield return source.Class[i];
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumFeatureClass"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumFeatureClass"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the feature classes from the input source.</returns>
        public static IEnumerable<IFeatureClass> ToEnumerable(this IEnumFeatureClass source)
        {
            if (source != null)
            {
                source.Reset();
                IFeatureClass featureclass = source.Next();
                while (featureclass != null)
                {
                    yield return featureclass;
                    featureclass = source.Next();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IFIDSet"/>
        /// </summary>
        /// <param name="source">An <see cref="IFIDSet"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the IDs from the input source.</returns>
        public static IEnumerable<int> ToEnumerable(this IFIDSet source)
        {
            if (source != null)
            {
                source.Reset();
                int objectId;

                source.Next(out objectId);
                while (objectId >= 0)
                {
                    yield return objectId;
                    source.Next(out objectId);
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumFeature"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumFeature"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the features from the input source.</returns>
        public static IEnumerable<IFeature> ToEnumerable(this IEnumFeature source)
        {
            if (source != null)
            {
                source.Reset();
                IFeature feature = source.Next();
                while (feature != null)
                {
                    yield return feature;
                    feature = source.Next();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumRelationship"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumRelationship"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the relationships from the input source.</returns>
        public static IEnumerable<IRelationship> ToEnumerable(this IEnumRelationship source)
        {
            if (source != null)
            {
                source.Reset();
                IRelationship relationship = source.Next();
                while (relationship != null)
                {
                    yield return relationship;
                    relationship = source.Next();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumDataset"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumDataset"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the datasets from the input source.</returns>
        public static IEnumerable<IDataset> ToEnumerable(this IEnumDataset source)
        {
            if (source != null)
            {
                source.Reset();
                IDataset dataset = source.Next();
                while (dataset != null)
                {
                    yield return dataset;
                    dataset = source.Next();
                }
            }
        }

        /// <summary>
        /// Creates an <see cref="IEnumerable{T}"/> from an <see cref="IEnumSubtype"/>
        /// </summary>
        /// <param name="source">An <see cref="IEnumSubtype"/> to create an <see cref="IEnumerable{T}"/> from.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> that contains the datasets from the input source.</returns>
        public static IEnumerable<KeyValuePair<string, int>> ToEnumerable(this IEnumSubtype source)
        {
            if (source != null)
            {
                source.Reset();
                int subtypeCode;
                string subtype = source.Next(out subtypeCode);
                while (string.IsNullOrEmpty(subtype) == false)
                {
                    yield return new KeyValuePair<string, int>(subtype, subtypeCode);
                    subtype = source.Next(out subtypeCode);
                }
            }
        }
    }
}
