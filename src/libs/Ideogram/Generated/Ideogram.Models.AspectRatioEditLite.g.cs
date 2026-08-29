
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio of the edited output. When omitted, the output<br/>
    /// follows the aspect ratio of the image being edited.<br/>
    /// Example: 16x9
    /// </summary>
    public enum AspectRatioEditLite
    {
        /// <summary>
        ///
        /// </summary>
        x16x9,
        /// <summary>
        ///
        /// </summary>
        x1x1,
        /// <summary>
        ///
        /// </summary>
        x21x9,
        /// <summary>
        ///
        /// </summary>
        x2x3,
        /// <summary>
        ///
        /// </summary>
        x3x2,
        /// <summary>
        ///
        /// </summary>
        x3x4,
        /// <summary>
        ///
        /// </summary>
        x4x3,
        /// <summary>
        ///
        /// </summary>
        x4x5,
        /// <summary>
        ///
        /// </summary>
        x5x4,
        /// <summary>
        ///
        /// </summary>
        x9x16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioEditLiteExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatioEditLite value)
        {
            return value switch
            {
                AspectRatioEditLite.x16x9 => "16x9",
                AspectRatioEditLite.x1x1 => "1x1",
                AspectRatioEditLite.x21x9 => "21x9",
                AspectRatioEditLite.x2x3 => "2x3",
                AspectRatioEditLite.x3x2 => "3x2",
                AspectRatioEditLite.x3x4 => "3x4",
                AspectRatioEditLite.x4x3 => "4x3",
                AspectRatioEditLite.x4x5 => "4x5",
                AspectRatioEditLite.x5x4 => "5x4",
                AspectRatioEditLite.x9x16 => "9x16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatioEditLite? ToEnum(string value)
        {
            return value switch
            {
                "16x9" => AspectRatioEditLite.x16x9,
                "1x1" => AspectRatioEditLite.x1x1,
                "21x9" => AspectRatioEditLite.x21x9,
                "2x3" => AspectRatioEditLite.x2x3,
                "3x2" => AspectRatioEditLite.x3x2,
                "3x4" => AspectRatioEditLite.x3x4,
                "4x3" => AspectRatioEditLite.x4x3,
                "4x5" => AspectRatioEditLite.x4x5,
                "5x4" => AspectRatioEditLite.x5x4,
                "9x16" => AspectRatioEditLite.x9x16,
                _ => null,
            };
        }
    }
}