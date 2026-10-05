
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Output aspect ratios Nano Banana Pro serves. `auto` lets the model choose the shape; an edit keeps its source image's shape.<br/>
    /// Default Value: auto
    /// </summary>
    public enum NanoBananaProAspectRatio
    {
        /// <summary>
        ///
        /// </summary>
        x16_9,
        /// <summary>
        ///
        /// </summary>
        x1_1,
        /// <summary>
        ///
        /// </summary>
        x21_9,
        /// <summary>
        ///
        /// </summary>
        x2_3,
        /// <summary>
        ///
        /// </summary>
        x3_2,
        /// <summary>
        ///
        /// </summary>
        x3_4,
        /// <summary>
        ///
        /// </summary>
        x4_3,
        /// <summary>
        ///
        /// </summary>
        x4_5,
        /// <summary>
        ///
        /// </summary>
        x5_4,
        /// <summary>
        ///
        /// </summary>
        x9_16,
        /// <summary>
        ///
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NanoBananaProAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NanoBananaProAspectRatio value)
        {
            return value switch
            {
                NanoBananaProAspectRatio.x16_9 => "16:9",
                NanoBananaProAspectRatio.x1_1 => "1:1",
                NanoBananaProAspectRatio.x21_9 => "21:9",
                NanoBananaProAspectRatio.x2_3 => "2:3",
                NanoBananaProAspectRatio.x3_2 => "3:2",
                NanoBananaProAspectRatio.x3_4 => "3:4",
                NanoBananaProAspectRatio.x4_3 => "4:3",
                NanoBananaProAspectRatio.x4_5 => "4:5",
                NanoBananaProAspectRatio.x5_4 => "5:4",
                NanoBananaProAspectRatio.x9_16 => "9:16",
                NanoBananaProAspectRatio.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NanoBananaProAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => NanoBananaProAspectRatio.x16_9,
                "1:1" => NanoBananaProAspectRatio.x1_1,
                "21:9" => NanoBananaProAspectRatio.x21_9,
                "2:3" => NanoBananaProAspectRatio.x2_3,
                "3:2" => NanoBananaProAspectRatio.x3_2,
                "3:4" => NanoBananaProAspectRatio.x3_4,
                "4:3" => NanoBananaProAspectRatio.x4_3,
                "4:5" => NanoBananaProAspectRatio.x4_5,
                "5:4" => NanoBananaProAspectRatio.x5_4,
                "9:16" => NanoBananaProAspectRatio.x9_16,
                "auto" => NanoBananaProAspectRatio.Auto,
                _ => null,
            };
        }
    }
}