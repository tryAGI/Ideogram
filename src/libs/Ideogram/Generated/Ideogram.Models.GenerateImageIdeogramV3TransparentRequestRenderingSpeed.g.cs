
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum GenerateImageIdeogramV3TransparentRequestRenderingSpeed
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
    public static class GenerateImageIdeogramV3TransparentRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV3TransparentRequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV3TransparentRequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV3TransparentRequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV3TransparentRequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV3TransparentRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => GenerateImageIdeogramV3TransparentRequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV3TransparentRequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV3TransparentRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}