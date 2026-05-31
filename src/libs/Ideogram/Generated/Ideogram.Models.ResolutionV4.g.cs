
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The 2K resolutions supported for Ideogram 4.0 image generation.<br/>
    /// Example: 2048x2048
    /// </summary>
    public enum ResolutionV4
    {
        /// <summary>
        /// 
        /// </summary>
        x1152x2944,
        /// <summary>
        /// 
        /// </summary>
        x1248x3328,
        /// <summary>
        /// 
        /// </summary>
        x1280x3072,
        /// <summary>
        /// 
        /// </summary>
        x1296x3168,
        /// <summary>
        /// 
        /// </summary>
        x1440x2560,
        /// <summary>
        /// 
        /// </summary>
        x1440x2880,
        /// <summary>
        /// 
        /// </summary>
        x1600x2560,
        /// <summary>
        /// 
        /// </summary>
        x1664x2496,
        /// <summary>
        /// 
        /// </summary>
        x1728x2304,
        /// <summary>
        /// 
        /// </summary>
        x1792x2240,
        /// <summary>
        /// 
        /// </summary>
        x2048x2048,
        /// <summary>
        /// 
        /// </summary>
        x2240x1792,
        /// <summary>
        /// 
        /// </summary>
        x2304x1728,
        /// <summary>
        /// 
        /// </summary>
        x2496x1664,
        /// <summary>
        /// 
        /// </summary>
        x2560x1440,
        /// <summary>
        /// 
        /// </summary>
        x2560x1600,
        /// <summary>
        /// 
        /// </summary>
        x2880x1440,
        /// <summary>
        /// 
        /// </summary>
        x2944x1152,
        /// <summary>
        /// 
        /// </summary>
        x3072x1280,
        /// <summary>
        /// 
        /// </summary>
        x3168x1296,
        /// <summary>
        /// 
        /// </summary>
        x3328x1248,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResolutionV4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResolutionV4 value)
        {
            return value switch
            {
                ResolutionV4.x1152x2944 => "1152x2944",
                ResolutionV4.x1248x3328 => "1248x3328",
                ResolutionV4.x1280x3072 => "1280x3072",
                ResolutionV4.x1296x3168 => "1296x3168",
                ResolutionV4.x1440x2560 => "1440x2560",
                ResolutionV4.x1440x2880 => "1440x2880",
                ResolutionV4.x1600x2560 => "1600x2560",
                ResolutionV4.x1664x2496 => "1664x2496",
                ResolutionV4.x1728x2304 => "1728x2304",
                ResolutionV4.x1792x2240 => "1792x2240",
                ResolutionV4.x2048x2048 => "2048x2048",
                ResolutionV4.x2240x1792 => "2240x1792",
                ResolutionV4.x2304x1728 => "2304x1728",
                ResolutionV4.x2496x1664 => "2496x1664",
                ResolutionV4.x2560x1440 => "2560x1440",
                ResolutionV4.x2560x1600 => "2560x1600",
                ResolutionV4.x2880x1440 => "2880x1440",
                ResolutionV4.x2944x1152 => "2944x1152",
                ResolutionV4.x3072x1280 => "3072x1280",
                ResolutionV4.x3168x1296 => "3168x1296",
                ResolutionV4.x3328x1248 => "3328x1248",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResolutionV4? ToEnum(string value)
        {
            return value switch
            {
                "1152x2944" => ResolutionV4.x1152x2944,
                "1248x3328" => ResolutionV4.x1248x3328,
                "1280x3072" => ResolutionV4.x1280x3072,
                "1296x3168" => ResolutionV4.x1296x3168,
                "1440x2560" => ResolutionV4.x1440x2560,
                "1440x2880" => ResolutionV4.x1440x2880,
                "1600x2560" => ResolutionV4.x1600x2560,
                "1664x2496" => ResolutionV4.x1664x2496,
                "1728x2304" => ResolutionV4.x1728x2304,
                "1792x2240" => ResolutionV4.x1792x2240,
                "2048x2048" => ResolutionV4.x2048x2048,
                "2240x1792" => ResolutionV4.x2240x1792,
                "2304x1728" => ResolutionV4.x2304x1728,
                "2496x1664" => ResolutionV4.x2496x1664,
                "2560x1440" => ResolutionV4.x2560x1440,
                "2560x1600" => ResolutionV4.x2560x1600,
                "2880x1440" => ResolutionV4.x2880x1440,
                "2944x1152" => ResolutionV4.x2944x1152,
                "3072x1280" => ResolutionV4.x3072x1280,
                "3168x1296" => ResolutionV4.x3168x1296,
                "3328x1248" => ResolutionV4.x3328x1248,
                _ => null,
            };
        }
    }
}