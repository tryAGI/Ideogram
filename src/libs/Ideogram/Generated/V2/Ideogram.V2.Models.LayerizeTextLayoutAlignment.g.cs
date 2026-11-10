
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextLayoutAlignment
    {
        /// <summary>
        ///
        /// </summary>
        Center,
        /// <summary>
        ///
        /// </summary>
        Justify,
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
    public static class LayerizeTextLayoutAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayoutAlignment value)
        {
            return value switch
            {
                LayerizeTextLayoutAlignment.Center => "center",
                LayerizeTextLayoutAlignment.Justify => "justify",
                LayerizeTextLayoutAlignment.Left => "left",
                LayerizeTextLayoutAlignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayoutAlignment? ToEnum(string value)
        {
            return value switch
            {
                "center" => LayerizeTextLayoutAlignment.Center,
                "justify" => LayerizeTextLayoutAlignment.Justify,
                "left" => LayerizeTextLayoutAlignment.Left,
                "right" => LayerizeTextLayoutAlignment.Right,
                _ => null,
            };
        }
    }
}