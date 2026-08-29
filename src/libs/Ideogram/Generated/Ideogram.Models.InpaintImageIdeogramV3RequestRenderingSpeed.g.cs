
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum InpaintImageIdeogramV3RequestRenderingSpeed
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
    public static class InpaintImageIdeogramV3RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintImageIdeogramV3RequestRenderingSpeed value)
        {
            return value switch
            {
                InpaintImageIdeogramV3RequestRenderingSpeed.Default => "DEFAULT",
                InpaintImageIdeogramV3RequestRenderingSpeed.Quality => "QUALITY",
                InpaintImageIdeogramV3RequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintImageIdeogramV3RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => InpaintImageIdeogramV3RequestRenderingSpeed.Default,
                "QUALITY" => InpaintImageIdeogramV3RequestRenderingSpeed.Quality,
                "TURBO" => InpaintImageIdeogramV3RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}