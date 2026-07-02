
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The aspect ratio for an Ideogram 4.0 magic prompt. `AUTO` lets the<br/>
    /// model select the most suitable ratio from the prompt; any other value<br/>
    /// pins the ratio. The non-AUTO values are the buckets the 4.0 model<br/>
    /// supports.<br/>
    /// Default Value: AUTO
    /// </summary>
    public enum AspectRatioV4
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
    public static class AspectRatioV4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatioV4 value)
        {
            return value switch
            {
                AspectRatioV4.x10x16 => "10x16",
                AspectRatioV4.x16x10 => "16x10",
                AspectRatioV4.x16x9 => "16x9",
                AspectRatioV4.x1x1 => "1x1",
                AspectRatioV4.x1x2 => "1x2",
                AspectRatioV4.x1x3 => "1x3",
                AspectRatioV4.x1x4 => "1x4",
                AspectRatioV4.x2x1 => "2x1",
                AspectRatioV4.x2x3 => "2x3",
                AspectRatioV4.x3x1 => "3x1",
                AspectRatioV4.x3x2 => "3x2",
                AspectRatioV4.x3x4 => "3x4",
                AspectRatioV4.x4x1 => "4x1",
                AspectRatioV4.x4x3 => "4x3",
                AspectRatioV4.x4x5 => "4x5",
                AspectRatioV4.x5x4 => "5x4",
                AspectRatioV4.x9x16 => "9x16",
                AspectRatioV4.Auto => "AUTO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatioV4? ToEnum(string value)
        {
            return value switch
            {
                "10x16" => AspectRatioV4.x10x16,
                "16x10" => AspectRatioV4.x16x10,
                "16x9" => AspectRatioV4.x16x9,
                "1x1" => AspectRatioV4.x1x1,
                "1x2" => AspectRatioV4.x1x2,
                "1x3" => AspectRatioV4.x1x3,
                "1x4" => AspectRatioV4.x1x4,
                "2x1" => AspectRatioV4.x2x1,
                "2x3" => AspectRatioV4.x2x3,
                "3x1" => AspectRatioV4.x3x1,
                "3x2" => AspectRatioV4.x3x2,
                "3x4" => AspectRatioV4.x3x4,
                "4x1" => AspectRatioV4.x4x1,
                "4x3" => AspectRatioV4.x4x3,
                "4x5" => AspectRatioV4.x4x5,
                "5x4" => AspectRatioV4.x5x4,
                "9x16" => AspectRatioV4.x9x16,
                "AUTO" => AspectRatioV4.Auto,
                _ => null,
            };
        }
    }
}