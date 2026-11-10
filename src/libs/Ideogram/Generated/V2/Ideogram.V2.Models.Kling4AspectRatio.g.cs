
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The aspect ratio of the generated video. Defaults to the ratio nearest the first frame's shape, or 16x9 without a first frame.
    /// </summary>
    public enum Kling4AspectRatio
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
        x9x16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Kling4AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Kling4AspectRatio value)
        {
            return value switch
            {
                Kling4AspectRatio.x16x9 => "16x9",
                Kling4AspectRatio.x1x1 => "1x1",
                Kling4AspectRatio.x21x9 => "21x9",
                Kling4AspectRatio.x9x16 => "9x16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Kling4AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16x9" => Kling4AspectRatio.x16x9,
                "1x1" => Kling4AspectRatio.x1x1,
                "21x9" => Kling4AspectRatio.x21x9,
                "9x16" => Kling4AspectRatio.x9x16,
                _ => null,
            };
        }
    }
}