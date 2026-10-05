
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Aspect ratios Nano Banana 2 can reframe an image to.
    /// </summary>
    public enum NanoBanana2ReframeAspectRatio
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
        x1_4,
        /// <summary>
        ///
        /// </summary>
        x1_8,
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
        x4_1,
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
        x8_1,
        /// <summary>
        ///
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NanoBanana2ReframeAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NanoBanana2ReframeAspectRatio value)
        {
            return value switch
            {
                NanoBanana2ReframeAspectRatio.x16_9 => "16:9",
                NanoBanana2ReframeAspectRatio.x1_1 => "1:1",
                NanoBanana2ReframeAspectRatio.x1_4 => "1:4",
                NanoBanana2ReframeAspectRatio.x1_8 => "1:8",
                NanoBanana2ReframeAspectRatio.x21_9 => "21:9",
                NanoBanana2ReframeAspectRatio.x2_3 => "2:3",
                NanoBanana2ReframeAspectRatio.x3_2 => "3:2",
                NanoBanana2ReframeAspectRatio.x3_4 => "3:4",
                NanoBanana2ReframeAspectRatio.x4_1 => "4:1",
                NanoBanana2ReframeAspectRatio.x4_3 => "4:3",
                NanoBanana2ReframeAspectRatio.x4_5 => "4:5",
                NanoBanana2ReframeAspectRatio.x5_4 => "5:4",
                NanoBanana2ReframeAspectRatio.x8_1 => "8:1",
                NanoBanana2ReframeAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NanoBanana2ReframeAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => NanoBanana2ReframeAspectRatio.x16_9,
                "1:1" => NanoBanana2ReframeAspectRatio.x1_1,
                "1:4" => NanoBanana2ReframeAspectRatio.x1_4,
                "1:8" => NanoBanana2ReframeAspectRatio.x1_8,
                "21:9" => NanoBanana2ReframeAspectRatio.x21_9,
                "2:3" => NanoBanana2ReframeAspectRatio.x2_3,
                "3:2" => NanoBanana2ReframeAspectRatio.x3_2,
                "3:4" => NanoBanana2ReframeAspectRatio.x3_4,
                "4:1" => NanoBanana2ReframeAspectRatio.x4_1,
                "4:3" => NanoBanana2ReframeAspectRatio.x4_3,
                "4:5" => NanoBanana2ReframeAspectRatio.x4_5,
                "5:4" => NanoBanana2ReframeAspectRatio.x5_4,
                "8:1" => NanoBanana2ReframeAspectRatio.x8_1,
                "9:16" => NanoBanana2ReframeAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}