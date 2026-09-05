
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminates layerized results from other generation output types.
    /// </summary>
    public enum LayerizedImageObjectObjectType
    {
        /// <summary>
        ///
        /// </summary>
        LayerizedImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizedImageObjectObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizedImageObjectObjectType value)
        {
            return value switch
            {
                LayerizedImageObjectObjectType.LayerizedImage => "layerized_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizedImageObjectObjectType? ToEnum(string value)
        {
            return value switch
            {
                "layerized_image" => LayerizedImageObjectObjectType.LayerizedImage,
                _ => null,
            };
        }
    }
}