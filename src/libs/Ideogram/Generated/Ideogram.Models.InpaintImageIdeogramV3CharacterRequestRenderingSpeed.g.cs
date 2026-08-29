
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: DEFAULT
    /// </summary>
    public enum InpaintImageIdeogramV3CharacterRequestRenderingSpeed
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
    public static class InpaintImageIdeogramV3CharacterRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintImageIdeogramV3CharacterRequestRenderingSpeed value)
        {
            return value switch
            {
                InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Default => "DEFAULT",
                InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Quality => "QUALITY",
                InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintImageIdeogramV3CharacterRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Default,
                "QUALITY" => InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Quality,
                "TURBO" => InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}