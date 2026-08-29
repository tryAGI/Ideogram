
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. `TURBO` generates faster at a lower cost, while `QUALITY` prioritizes the highest-quality result.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum GenerateImageIdeogramV2ARequestRenderingSpeed
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
    public static class GenerateImageIdeogramV2ARequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV2ARequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV2ARequestRenderingSpeed.Default => "DEFAULT",
                GenerateImageIdeogramV2ARequestRenderingSpeed.Quality => "QUALITY",
                GenerateImageIdeogramV2ARequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV2ARequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => GenerateImageIdeogramV2ARequestRenderingSpeed.Default,
                "QUALITY" => GenerateImageIdeogramV2ARequestRenderingSpeed.Quality,
                "TURBO" => GenerateImageIdeogramV2ARequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}