
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum ReplaceBackgroundIdeogramV3RequestRenderingSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Quality,
        /// <summary>
        ///
        /// </summary>
        Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplaceBackgroundIdeogramV3RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplaceBackgroundIdeogramV3RequestRenderingSpeed value)
        {
            return value switch
            {
                ReplaceBackgroundIdeogramV3RequestRenderingSpeed.Default => "default",
                ReplaceBackgroundIdeogramV3RequestRenderingSpeed.Quality => "quality",
                ReplaceBackgroundIdeogramV3RequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplaceBackgroundIdeogramV3RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => ReplaceBackgroundIdeogramV3RequestRenderingSpeed.Default,
                "quality" => ReplaceBackgroundIdeogramV3RequestRenderingSpeed.Quality,
                "turbo" => ReplaceBackgroundIdeogramV3RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}