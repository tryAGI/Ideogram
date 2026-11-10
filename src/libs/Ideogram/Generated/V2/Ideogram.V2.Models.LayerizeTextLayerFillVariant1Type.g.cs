
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: solid
    /// </summary>
    public enum LayerizeTextLayerFillVariant1Type
    {
        /// <summary>
        /// solid
        /// </summary>
        Solid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerFillVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerFillVariant1Type value)
        {
            return value switch
            {
                LayerizeTextLayerFillVariant1Type.Solid => "solid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerFillVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "solid" => LayerizeTextLayerFillVariant1Type.Solid,
                _ => null,
            };
        }
    }
}