
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextLayerShapeDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Arc,
        /// <summary>
        ///
        /// </summary>
        Envelope,
        /// <summary>
        ///
        /// </summary>
        Path,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayerShapeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayerShapeDiscriminatorType value)
        {
            return value switch
            {
                LayerizeTextLayerShapeDiscriminatorType.Arc => "arc",
                LayerizeTextLayerShapeDiscriminatorType.Envelope => "envelope",
                LayerizeTextLayerShapeDiscriminatorType.Path => "path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayerShapeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "arc" => LayerizeTextLayerShapeDiscriminatorType.Arc,
                "envelope" => LayerizeTextLayerShapeDiscriminatorType.Envelope,
                "path" => LayerizeTextLayerShapeDiscriminatorType.Path,
                _ => null,
            };
        }
    }
}