
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: gradient
    /// </summary>
    public enum LayerizeTextLayerFillVariant2Type
    {
        /// <summary>
        /// gradient
        /// </summary>
        Gradient,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerFillVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerFillVariant2Type value)
        {
            return value switch
            {
                LayerizeTextLayerFillVariant2Type.Gradient => "gradient",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerFillVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "gradient" => LayerizeTextLayerFillVariant2Type.Gradient,
                _ => null,
            };
        }
    }
}