
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: arc
    /// </summary>
    public enum LayerizeTextLayerShapeVariant1Type
    {
        /// <summary>
        /// arc
        /// </summary>
        Arc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerShapeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerShapeVariant1Type value)
        {
            return value switch
            {
                LayerizeTextLayerShapeVariant1Type.Arc => "arc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerShapeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "arc" => LayerizeTextLayerShapeVariant1Type.Arc,
                _ => null,
            };
        }
    }
}