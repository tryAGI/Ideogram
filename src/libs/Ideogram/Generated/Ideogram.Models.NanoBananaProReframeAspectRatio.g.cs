
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Aspect ratios Nano Banana Pro can reframe an image to.
    /// </summary>
    public enum NanoBananaProReframeAspectRatio
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NanoBananaProReframeAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NanoBananaProReframeAspectRatio value)
        {
            return value switch
            {
                NanoBananaProReframeAspectRatio.x16_9 => "16:9",
                NanoBananaProReframeAspectRatio.x1_1 => "1:1",
                NanoBananaProReframeAspectRatio.x21_9 => "21:9",
                NanoBananaProReframeAspectRatio.x2_3 => "2:3",
                NanoBananaProReframeAspectRatio.x3_2 => "3:2",
                NanoBananaProReframeAspectRatio.x3_4 => "3:4",
                NanoBananaProReframeAspectRatio.x4_3 => "4:3",
                NanoBananaProReframeAspectRatio.x4_5 => "4:5",
                NanoBananaProReframeAspectRatio.x5_4 => "5:4",
                NanoBananaProReframeAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NanoBananaProReframeAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => NanoBananaProReframeAspectRatio.x16_9,
                "1:1" => NanoBananaProReframeAspectRatio.x1_1,
                "21:9" => NanoBananaProReframeAspectRatio.x21_9,
                "2:3" => NanoBananaProReframeAspectRatio.x2_3,
                "3:2" => NanoBananaProReframeAspectRatio.x3_2,
                "3:4" => NanoBananaProReframeAspectRatio.x3_4,
                "4:3" => NanoBananaProReframeAspectRatio.x4_3,
                "4:5" => NanoBananaProReframeAspectRatio.x4_5,
                "5:4" => NanoBananaProReframeAspectRatio.x5_4,
                "9:16" => NanoBananaProReframeAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}