
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public enum LayerizeTextLayoutVerticalAlignment
    {
        /// <summary>
        ///
        /// </summary>
        Bottom,
        /// <summary>
        ///
        /// </summary>
        Middle,
        /// <summary>
        ///
        /// </summary>
        Top,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LayerizeTextLayoutVerticalAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayerizeTextLayoutVerticalAlignment value)
        {
            return value switch
            {
                LayerizeTextLayoutVerticalAlignment.Bottom => "bottom",
                LayerizeTextLayoutVerticalAlignment.Middle => "middle",
                LayerizeTextLayoutVerticalAlignment.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayerizeTextLayoutVerticalAlignment? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => LayerizeTextLayoutVerticalAlignment.Bottom,
                "middle" => LayerizeTextLayoutVerticalAlignment.Middle,
                "top" => LayerizeTextLayoutVerticalAlignment.Top,
                _ => null,
            };
        }
    }
}