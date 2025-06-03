
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum RenderingSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        FLASH,
        /// <summary>
        /// 
        /// </summary>
        TURBO,
        /// <summary>
        /// 
        /// </summary>
        BALANCED,
        /// <summary>
        /// 
        /// </summary>
        DEFAULT,
        /// <summary>
        /// 
        /// </summary>
        QUALITY,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderingSpeed value)
        {
            return value switch
            {
                RenderingSpeed.FLASH => "FLASH",
                RenderingSpeed.TURBO => "TURBO",
                RenderingSpeed.BALANCED => "BALANCED",
                RenderingSpeed.DEFAULT => "DEFAULT",
                RenderingSpeed.QUALITY => "QUALITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "FLASH" => RenderingSpeed.FLASH,
                "TURBO" => RenderingSpeed.TURBO,
                "BALANCED" => RenderingSpeed.BALANCED,
                "DEFAULT" => RenderingSpeed.DEFAULT,
                "QUALITY" => RenderingSpeed.QUALITY,
                _ => null,
            };
        }
    }
}