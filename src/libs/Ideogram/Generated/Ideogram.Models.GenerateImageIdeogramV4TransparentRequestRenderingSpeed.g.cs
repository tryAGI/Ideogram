
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum GenerateImageIdeogramV4TransparentRequestRenderingSpeed
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
    public static class GenerateImageIdeogramV4TransparentRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV4TransparentRequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV4TransparentRequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV4TransparentRequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV4TransparentRequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV4TransparentRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => GenerateImageIdeogramV4TransparentRequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV4TransparentRequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV4TransparentRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}