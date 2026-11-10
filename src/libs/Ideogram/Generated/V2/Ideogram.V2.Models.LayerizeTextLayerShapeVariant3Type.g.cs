
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Discriminator value: envelope
    /// </summary>
    public enum LayerizeTextLayerShapeVariant3Type
    {
        /// <summary>
        /// envelope
        /// </summary>
        Envelope,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerShapeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerShapeVariant3Type value)
        {
            return value switch
            {
                LayerizeTextLayerShapeVariant3Type.Envelope => "envelope",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerShapeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "envelope" => LayerizeTextLayerShapeVariant3Type.Envelope,
                _ => null,
            };
        }
    }
}