
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio of the generated video. `AUTO` lets the model choose the<br/>
    /// most suitable ratio from the prompt; any other value pins the ratio.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum SeedDance2AspectRatio
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
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeedDance2AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeedDance2AspectRatio value)
        {
            return value switch
            {
                SeedDance2AspectRatio.x16x9 => "16x9",
                SeedDance2AspectRatio.x1x1 => "1x1",
                SeedDance2AspectRatio.x21x9 => "21x9",
                SeedDance2AspectRatio.x3x4 => "3x4",
                SeedDance2AspectRatio.x4x3 => "4x3",
                SeedDance2AspectRatio.x9x16 => "9x16",
                SeedDance2AspectRatio.Auto => "AUTO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeedDance2AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16x9" => SeedDance2AspectRatio.x16x9,
                "1x1" => SeedDance2AspectRatio.x1x1,
                "21x9" => SeedDance2AspectRatio.x21x9,
                "3x4" => SeedDance2AspectRatio.x3x4,
                "4x3" => SeedDance2AspectRatio.x4x3,
                "9x16" => SeedDance2AspectRatio.x9x16,
                "AUTO" => SeedDance2AspectRatio.Auto,
                _ => null,
            };
        }
    }
}