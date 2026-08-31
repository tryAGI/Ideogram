
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Default Value: DEFAULT
    /// </summary>
    public enum ReframeImageIdeogramV3RequestRenderingSpeed
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
    public static class ReframeImageIdeogramV3RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeImageIdeogramV3RequestRenderingSpeed value)
        {
            return value switch
            {
                ReframeImageIdeogramV3RequestRenderingSpeed.Default => "DEFAULT",
                ReframeImageIdeogramV3RequestRenderingSpeed.Quality => "QUALITY",
                ReframeImageIdeogramV3RequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeImageIdeogramV3RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => ReframeImageIdeogramV3RequestRenderingSpeed.Default,
                "QUALITY" => ReframeImageIdeogramV3RequestRenderingSpeed.Quality,
                "TURBO" => ReframeImageIdeogramV3RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}