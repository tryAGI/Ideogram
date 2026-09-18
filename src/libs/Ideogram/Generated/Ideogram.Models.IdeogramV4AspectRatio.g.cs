
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio for an Ideogram 4.0 magic prompt. `auto` lets the<br/>
    /// model select the most suitable ratio from the prompt; any other value<br/>
    /// pins the ratio. The non-auto values are the buckets the 4.0 model<br/>
    /// supports.<br/>
    /// Default Value: auto
    /// </summary>
    public enum IdeogramV4AspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x10x16,
        /// <summary>
        ///
        /// </summary>
        x16x10,
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
        x1x2,
        /// <summary>
        ///
        /// </summary>
        x1x3,
        /// <summary>
        ///
        /// </summary>
        x1x4,
        /// <summary>
        ///
        /// </summary>
        x2x1,
        /// <summary>
        ///
        /// </summary>
        x2x3,
        /// <summary>
        ///
        /// </summary>
        x3x1,
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
        x4x1,
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
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdeogramV4AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdeogramV4AspectRatio value)
        {
            return value switch
            {
                IdeogramV4AspectRatio.x10x16 => "10x16",
                IdeogramV4AspectRatio.x16x10 => "16x10",
                IdeogramV4AspectRatio.x16x9 => "16x9",
                IdeogramV4AspectRatio.x1x1 => "1x1",
                IdeogramV4AspectRatio.x1x2 => "1x2",
                IdeogramV4AspectRatio.x1x3 => "1x3",
                IdeogramV4AspectRatio.x1x4 => "1x4",
                IdeogramV4AspectRatio.x2x1 => "2x1",
                IdeogramV4AspectRatio.x2x3 => "2x3",
                IdeogramV4AspectRatio.x3x1 => "3x1",
                IdeogramV4AspectRatio.x3x2 => "3x2",
                IdeogramV4AspectRatio.x3x4 => "3x4",
                IdeogramV4AspectRatio.x4x1 => "4x1",
                IdeogramV4AspectRatio.x4x3 => "4x3",
                IdeogramV4AspectRatio.x4x5 => "4x5",
                IdeogramV4AspectRatio.x5x4 => "5x4",
                IdeogramV4AspectRatio.x9x16 => "9x16",
                IdeogramV4AspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdeogramV4AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "10x16" => IdeogramV4AspectRatio.x10x16,
                "16x10" => IdeogramV4AspectRatio.x16x10,
                "16x9" => IdeogramV4AspectRatio.x16x9,
                "1x1" => IdeogramV4AspectRatio.x1x1,
                "1x2" => IdeogramV4AspectRatio.x1x2,
                "1x3" => IdeogramV4AspectRatio.x1x3,
                "1x4" => IdeogramV4AspectRatio.x1x4,
                "2x1" => IdeogramV4AspectRatio.x2x1,
                "2x3" => IdeogramV4AspectRatio.x2x3,
                "3x1" => IdeogramV4AspectRatio.x3x1,
                "3x2" => IdeogramV4AspectRatio.x3x2,
                "3x4" => IdeogramV4AspectRatio.x3x4,
                "4x1" => IdeogramV4AspectRatio.x4x1,
                "4x3" => IdeogramV4AspectRatio.x4x3,
                "4x5" => IdeogramV4AspectRatio.x4x5,
                "5x4" => IdeogramV4AspectRatio.x5x4,
                "9x16" => IdeogramV4AspectRatio.x9x16,
                "auto" => IdeogramV4AspectRatio.Auto,
                _ => null,
            };
        }
    }
}