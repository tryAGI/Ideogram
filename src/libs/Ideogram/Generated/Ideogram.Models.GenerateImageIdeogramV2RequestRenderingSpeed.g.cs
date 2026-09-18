
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. `turbo` generates faster at a lower cost, while `quality` prioritizes the highest-quality result.<br/>
    /// Default Value: default
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
                GenerateImageIdeogramV2RequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV2RequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV2RequestRenderingSpeed.Turbo => "turbo",
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
                "default" => GenerateImageIdeogramV2RequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV2RequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV2RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}