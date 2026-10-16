
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Detected text alignment.
    /// </summary>
    public enum LayerizedTextBlockAlignment
    {
        /// <summary>
        ///
        /// </summary>
        Center,
        /// <summary>
        ///
        /// </summary>
        Left,
        /// <summary>
        ///
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizedTextBlockAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizedTextBlockAlignment value)
        {
            return value switch
            {
                LayerizedTextBlockAlignment.Center => "center",
                LayerizedTextBlockAlignment.Left => "left",
                LayerizedTextBlockAlignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizedTextBlockAlignment? ToEnum(string value)
        {
            return value switch
            {
                "center" => LayerizedTextBlockAlignment.Center,
                "left" => LayerizedTextBlockAlignment.Left,
                "right" => LayerizedTextBlockAlignment.Right,
                _ => null,
            };
        }
    }
}