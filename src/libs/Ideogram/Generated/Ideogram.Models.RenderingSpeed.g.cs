
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
        Flash,
        /// <summary>
        /// 
        /// </summary>
        Turbo,
        /// <summary>
        /// 
        /// </summary>
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Quality,
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
                RenderingSpeed.Flash => "FLASH",
                RenderingSpeed.Turbo => "TURBO",
                RenderingSpeed.Balanced => "BALANCED",
                RenderingSpeed.Default => "DEFAULT",
                RenderingSpeed.Quality => "QUALITY",
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
                "FLASH" => RenderingSpeed.Flash,
                "TURBO" => RenderingSpeed.Turbo,
                "BALANCED" => RenderingSpeed.Balanced,
                "DEFAULT" => RenderingSpeed.Default,
                "QUALITY" => RenderingSpeed.Quality,
                _ => null,
            };
        }
    }
}