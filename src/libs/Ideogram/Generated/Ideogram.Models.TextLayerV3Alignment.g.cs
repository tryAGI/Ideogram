
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The text alignment of the layer.<br/>
    /// Example: center
    /// </summary>
    public enum TextLayerV3Alignment
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextLayerV3AlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextLayerV3Alignment value)
        {
            return value switch
            {
                TextLayerV3Alignment.Left => "left",
                TextLayerV3Alignment.Center => "center",
                TextLayerV3Alignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextLayerV3Alignment? ToEnum(string value)
        {
            return value switch
            {
                "left" => TextLayerV3Alignment.Left,
                "center" => TextLayerV3Alignment.Center,
                "right" => TextLayerV3Alignment.Right,
                _ => null,
            };
        }
    }
}