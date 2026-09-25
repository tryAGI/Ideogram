
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio for an Ideogram 3.x or 2.x generation. `auto` lets the<br/>
    /// model select a ratio from the prompt; any other value pins the ratio.<br/>
    /// Cannot be combined with `resolution`. Omitting the field is not `auto`:<br/>
    /// it uses `1x1`.
    /// </summary>
    public enum IdeogramV3AspectRatio
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
    public static class IdeogramV3AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdeogramV3AspectRatio value)
        {
            return value switch
            {
                IdeogramV3AspectRatio.x10x16 => "10x16",
                IdeogramV3AspectRatio.x16x10 => "16x10",
                IdeogramV3AspectRatio.x16x9 => "16x9",
                IdeogramV3AspectRatio.x1x1 => "1x1",
                IdeogramV3AspectRatio.x1x2 => "1x2",
                IdeogramV3AspectRatio.x1x3 => "1x3",
                IdeogramV3AspectRatio.x2x1 => "2x1",
                IdeogramV3AspectRatio.x2x3 => "2x3",
                IdeogramV3AspectRatio.x3x1 => "3x1",
                IdeogramV3AspectRatio.x3x2 => "3x2",
                IdeogramV3AspectRatio.x3x4 => "3x4",
                IdeogramV3AspectRatio.x4x3 => "4x3",
                IdeogramV3AspectRatio.x4x5 => "4x5",
                IdeogramV3AspectRatio.x5x4 => "5x4",
                IdeogramV3AspectRatio.x9x16 => "9x16",
                IdeogramV3AspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdeogramV3AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "10x16" => IdeogramV3AspectRatio.x10x16,
                "16x10" => IdeogramV3AspectRatio.x16x10,
                "16x9" => IdeogramV3AspectRatio.x16x9,
                "1x1" => IdeogramV3AspectRatio.x1x1,
                "1x2" => IdeogramV3AspectRatio.x1x2,
                "1x3" => IdeogramV3AspectRatio.x1x3,
                "2x1" => IdeogramV3AspectRatio.x2x1,
                "2x3" => IdeogramV3AspectRatio.x2x3,
                "3x1" => IdeogramV3AspectRatio.x3x1,
                "3x2" => IdeogramV3AspectRatio.x3x2,
                "3x4" => IdeogramV3AspectRatio.x3x4,
                "4x3" => IdeogramV3AspectRatio.x4x3,
                "4x5" => IdeogramV3AspectRatio.x4x5,
                "5x4" => IdeogramV3AspectRatio.x5x4,
                "9x16" => IdeogramV3AspectRatio.x9x16,
                "auto" => IdeogramV3AspectRatio.Auto,
                _ => null,
            };
        }
    }
}