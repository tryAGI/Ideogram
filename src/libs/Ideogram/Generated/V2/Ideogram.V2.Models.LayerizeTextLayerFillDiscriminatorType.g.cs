
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextLayerFillDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Gradient,
        /// <summary>
        ///
        /// </summary>
        Solid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerFillDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerFillDiscriminatorType value)
        {
            return value switch
            {
                LayerizeTextLayerFillDiscriminatorType.Gradient => "gradient",
                LayerizeTextLayerFillDiscriminatorType.Solid => "solid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerFillDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "gradient" => LayerizeTextLayerFillDiscriminatorType.Gradient,
                "solid" => LayerizeTextLayerFillDiscriminatorType.Solid,
                _ => null,
            };
        }
    }
}