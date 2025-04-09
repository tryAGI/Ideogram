
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1:1.
    /// </summary>
    public enum AspectRatioV3
    {
        /// <summary>
        /// 
        /// </summary>
        x1x3,
        /// <summary>
        /// 
        /// </summary>
        x3x1,
        /// <summary>
        /// 
        /// </summary>
        x1x2,
        /// <summary>
        /// 
        /// </summary>
        x2x1,
        /// <summary>
        /// 
        /// </summary>
        x9x16,
        /// <summary>
        /// 
        /// </summary>
        x16x9,
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
        x1x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioV3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatioV3 value)
        {
            return value switch
            {
                AspectRatioV3.x1x3 => "1x3",
                AspectRatioV3.x3x1 => "3x1",
                AspectRatioV3.x1x2 => "1x2",
                AspectRatioV3.x2x1 => "2x1",
                AspectRatioV3.x9x16 => "9x16",
                AspectRatioV3.x16x9 => "16x9",
                AspectRatioV3.x10x16 => "10x16",
                AspectRatioV3.x16x10 => "16x10",
                AspectRatioV3.x2x3 => "2x3",
                AspectRatioV3.x3x2 => "3x2",
                AspectRatioV3.x3x4 => "3x4",
                AspectRatioV3.x4x3 => "4x3",
                AspectRatioV3.x4x5 => "4x5",
                AspectRatioV3.x5x4 => "5x4",
                AspectRatioV3.x1x1 => "1x1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatioV3? ToEnum(string value)
        {
            return value switch
            {
                "1x3" => AspectRatioV3.x1x3,
                "3x1" => AspectRatioV3.x3x1,
                "1x2" => AspectRatioV3.x1x2,
                "2x1" => AspectRatioV3.x2x1,
                "9x16" => AspectRatioV3.x9x16,
                "16x9" => AspectRatioV3.x16x9,
                "10x16" => AspectRatioV3.x10x16,
                "16x10" => AspectRatioV3.x16x10,
                "2x3" => AspectRatioV3.x2x3,
                "3x2" => AspectRatioV3.x3x2,
                "3x4" => AspectRatioV3.x3x4,
                "4x3" => AspectRatioV3.x4x3,
                "4x5" => AspectRatioV3.x4x5,
                "5x4" => AspectRatioV3.x5x4,
                "1x1" => AspectRatioV3.x1x1,
                _ => null,
            };
        }
    }
}