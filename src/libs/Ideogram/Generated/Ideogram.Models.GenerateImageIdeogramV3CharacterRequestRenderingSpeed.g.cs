
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum GenerateImageIdeogramV3CharacterRequestRenderingSpeed
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
    public static class GenerateImageIdeogramV3CharacterRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV3CharacterRequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV3CharacterRequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV3CharacterRequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV3CharacterRequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV3CharacterRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => GenerateImageIdeogramV3CharacterRequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV3CharacterRequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV3CharacterRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}