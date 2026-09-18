
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum GenerateImageIdeogramV3RequestRenderingSpeed
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
    public static class GenerateImageIdeogramV3RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV3RequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV3RequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV3RequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV3RequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV3RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => GenerateImageIdeogramV3RequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV3RequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV3RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}