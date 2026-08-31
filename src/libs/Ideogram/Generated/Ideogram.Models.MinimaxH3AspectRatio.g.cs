
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio of the generated video.<br/>
    /// Default Value: 16x9
    /// </summary>
    public enum MinimaxH3AspectRatio
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
        x3x4,
        /// <summary>
        ///
        /// </summary>
        x4x3,
        /// <summary>
        ///
        /// </summary>
        x9x16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinimaxH3AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxH3AspectRatio value)
        {
            return value switch
            {
                MinimaxH3AspectRatio.x16x9 => "16x9",
                MinimaxH3AspectRatio.x1x1 => "1x1",
                MinimaxH3AspectRatio.x21x9 => "21x9",
                MinimaxH3AspectRatio.x3x4 => "3x4",
                MinimaxH3AspectRatio.x4x3 => "4x3",
                MinimaxH3AspectRatio.x9x16 => "9x16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxH3AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16x9" => MinimaxH3AspectRatio.x16x9,
                "1x1" => MinimaxH3AspectRatio.x1x1,
                "21x9" => MinimaxH3AspectRatio.x21x9,
                "3x4" => MinimaxH3AspectRatio.x3x4,
                "4x3" => MinimaxH3AspectRatio.x4x3,
                "9x16" => MinimaxH3AspectRatio.x9x16,
                _ => null,
            };
        }
    }
}