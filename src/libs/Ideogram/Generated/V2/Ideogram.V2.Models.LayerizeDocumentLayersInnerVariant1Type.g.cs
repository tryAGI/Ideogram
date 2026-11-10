
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: image
    /// </summary>
    public enum LayerizeDocumentLayersInnerVariant1Type
    {
        /// <summary>
        /// image
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeDocumentLayersInnerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeDocumentLayersInnerVariant1Type value)
        {
            return value switch
            {
                LayerizeDocumentLayersInnerVariant1Type.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeDocumentLayersInnerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "image" => LayerizeDocumentLayersInnerVariant1Type.Image,
                _ => null,
            };
        }
    }
}