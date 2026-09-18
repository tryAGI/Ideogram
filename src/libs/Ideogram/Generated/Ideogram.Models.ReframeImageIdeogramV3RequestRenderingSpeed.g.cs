
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Default Value: default
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
                ReframeImageIdeogramV3RequestRenderingSpeed.Default => "default",
                ReframeImageIdeogramV3RequestRenderingSpeed.Quality => "quality",
                ReframeImageIdeogramV3RequestRenderingSpeed.Turbo => "turbo",
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
                "default" => ReframeImageIdeogramV3RequestRenderingSpeed.Default,
                "quality" => ReframeImageIdeogramV3RequestRenderingSpeed.Quality,
                "turbo" => ReframeImageIdeogramV3RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}