
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Vertical anchor (top|middle|bottom) for the rendered text within<br/>
    /// its bounding box. Maps to SVG `dominant-baseline`. V4 vector-text<br/>
    /// only. Distinct from horizontal `alignment` (left|center|right).
    /// </summary>
    public enum TextItemV3VerticalAlignment
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
    public static class TextItemV3VerticalAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextItemV3VerticalAlignment value)
        {
            return value switch
            {
                TextItemV3VerticalAlignment.Bottom => "bottom",
                TextItemV3VerticalAlignment.Middle => "middle",
                TextItemV3VerticalAlignment.Top => "top",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextItemV3VerticalAlignment? ToEnum(string value)
        {
            return value switch
            {
                "bottom" => TextItemV3VerticalAlignment.Bottom,
                "middle" => TextItemV3VerticalAlignment.Middle,
                "top" => TextItemV3VerticalAlignment.Top,
                _ => null,
            };
        }
    }
}