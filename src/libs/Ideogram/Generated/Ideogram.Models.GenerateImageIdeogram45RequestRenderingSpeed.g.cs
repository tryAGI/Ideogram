
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum GenerateImageIdeogram45RequestRenderingSpeed
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
    public static class GenerateImageIdeogram45RequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogram45RequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogram45RequestRenderingSpeed.Default => "default",
                GenerateImageIdeogram45RequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogram45RequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogram45RequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => GenerateImageIdeogram45RequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogram45RequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogram45RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}