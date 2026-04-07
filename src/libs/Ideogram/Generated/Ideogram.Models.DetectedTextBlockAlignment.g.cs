
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Detected text alignment.
    /// </summary>
    public enum DetectedTextBlockAlignment
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
    public static class DetectedTextBlockAlignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DetectedTextBlockAlignment value)
        {
            return value switch
            {
                DetectedTextBlockAlignment.Center => "center",
                DetectedTextBlockAlignment.Left => "left",
                DetectedTextBlockAlignment.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DetectedTextBlockAlignment? ToEnum(string value)
        {
            return value switch
            {
                "center" => DetectedTextBlockAlignment.Center,
                "left" => DetectedTextBlockAlignment.Left,
                "right" => DetectedTextBlockAlignment.Right,
                _ => null,
            };
        }
    }
}