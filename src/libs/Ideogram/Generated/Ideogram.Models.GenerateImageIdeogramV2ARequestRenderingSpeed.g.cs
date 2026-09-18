
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. `turbo` generates faster at a lower cost, while `quality` prioritizes the highest-quality result.<br/>
    /// Default Value: default
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
                GenerateImageIdeogramV2ARequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV2ARequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV2ARequestRenderingSpeed.Turbo => "turbo",
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
                "default" => GenerateImageIdeogramV2ARequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV2ARequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV2ARequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}