
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
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
                RemixImageIdeogramV3CharacterRequestRenderingSpeed.Default => "default",
                RemixImageIdeogramV3CharacterRequestRenderingSpeed.Quality => "quality",
                RemixImageIdeogramV3CharacterRequestRenderingSpeed.Turbo => "turbo",
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
                "default" => RemixImageIdeogramV3CharacterRequestRenderingSpeed.Default,
                "quality" => RemixImageIdeogramV3CharacterRequestRenderingSpeed.Quality,
                "turbo" => RemixImageIdeogramV3CharacterRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}