
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: path
    /// </summary>
    public enum LayerizeTextLayerShapeVariant2Type
    {
        /// <summary>
        /// path
        /// </summary>
        Path,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerShapeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerShapeVariant2Type value)
        {
            return value switch
            {
                LayerizeTextLayerShapeVariant2Type.Path => "path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerShapeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "path" => LayerizeTextLayerShapeVariant2Type.Path,
                _ => null,
            };
        }
    }
}