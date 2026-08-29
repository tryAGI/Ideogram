
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
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
                GenerateImageIdeogram45RequestRenderingSpeed.Default => "DEFAULT",
                GenerateImageIdeogram45RequestRenderingSpeed.Quality => "QUALITY",
                GenerateImageIdeogram45RequestRenderingSpeed.Turbo => "TURBO",
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
                "DEFAULT" => GenerateImageIdeogram45RequestRenderingSpeed.Default,
                "QUALITY" => GenerateImageIdeogram45RequestRenderingSpeed.Quality,
                "TURBO" => GenerateImageIdeogram45RequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}