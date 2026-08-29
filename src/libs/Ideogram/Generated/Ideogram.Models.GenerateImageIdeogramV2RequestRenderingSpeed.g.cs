
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. `TURBO` generates faster at a lower cost, while `QUALITY` prioritizes the highest-quality result.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum GenerateImageIdeogramV2RequestRenderingSpeed
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
    public static class GenerateImageIdeogramV2RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV2RequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV2RequestRenderingSpeed.Default => "DEFAULT",
                GenerateImageIdeogramV2RequestRenderingSpeed.Quality => "QUALITY",
                GenerateImageIdeogramV2RequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV2RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => GenerateImageIdeogramV2RequestRenderingSpeed.Default,
                "QUALITY" => GenerateImageIdeogramV2RequestRenderingSpeed.Quality,
                "TURBO" => GenerateImageIdeogramV2RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}