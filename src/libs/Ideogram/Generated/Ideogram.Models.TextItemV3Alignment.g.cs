
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The text alignment of the item.<br/>
    /// Example: center
    /// </summary>
    public enum TextItemV3Alignment
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
    public static class TextItemV3AlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextItemV3Alignment value)
        {
            return value switch
            {
                TextItemV3Alignment.Center => "center",
                TextItemV3Alignment.Left => "left",
                TextItemV3Alignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextItemV3Alignment? ToEnum(string value)
        {
            return value switch
            {
                "center" => TextItemV3Alignment.Center,
                "left" => TextItemV3Alignment.Left,
                "right" => TextItemV3Alignment.Right,
                _ => null,
            };
        }
    }
}