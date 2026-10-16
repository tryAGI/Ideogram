
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Discriminator value: layerized_image
    /// </summary>
    public enum GenerationResponseDataInnerVariant5ObjectType
    {
        /// <summary>
        /// layerized_image
        /// </summary>
        LayerizedImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseDataInnerVariant5ObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseDataInnerVariant5ObjectType value)
        {
            return value switch
            {
                GenerationResponseDataInnerVariant5ObjectType.LayerizedImage => "layerized_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseDataInnerVariant5ObjectType? ToEnum(string value)
        {
            return value switch
            {
                "layerized_image" => GenerationResponseDataInnerVariant5ObjectType.LayerizedImage,
                _ => null,
            };
        }
    }
}