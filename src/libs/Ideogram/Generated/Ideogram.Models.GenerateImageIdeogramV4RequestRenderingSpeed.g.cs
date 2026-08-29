
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum GenerateImageIdeogramV4RequestRenderingSpeed
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
    public static class GenerateImageIdeogramV4RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV4RequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV4RequestRenderingSpeed.Default => "DEFAULT",
                GenerateImageIdeogramV4RequestRenderingSpeed.Quality => "QUALITY",
                GenerateImageIdeogramV4RequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV4RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => GenerateImageIdeogramV4RequestRenderingSpeed.Default,
                "QUALITY" => GenerateImageIdeogramV4RequestRenderingSpeed.Quality,
                "TURBO" => GenerateImageIdeogramV4RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}