
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum RemixImageIdeogramV3CharacterRequestRenderingSpeed
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
    public static class RemixImageIdeogramV3CharacterRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemixImageIdeogramV3CharacterRequestRenderingSpeed value)
        {
            return value switch
            {
                RemixImageIdeogramV3CharacterRequestRenderingSpeed.Default => "DEFAULT",
                RemixImageIdeogramV3CharacterRequestRenderingSpeed.Quality => "QUALITY",
                RemixImageIdeogramV3CharacterRequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemixImageIdeogramV3CharacterRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => RemixImageIdeogramV3CharacterRequestRenderingSpeed.Default,
                "QUALITY" => RemixImageIdeogramV3CharacterRequestRenderingSpeed.Quality,
                "TURBO" => RemixImageIdeogramV3CharacterRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}