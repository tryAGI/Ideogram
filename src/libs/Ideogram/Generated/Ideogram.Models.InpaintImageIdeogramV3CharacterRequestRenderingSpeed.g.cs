
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
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
                InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Default => "default",
                InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Quality => "quality",
                InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Turbo => "turbo",
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
                "default" => InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Default,
                "quality" => InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Quality,
                "turbo" => InpaintImageIdeogramV3CharacterRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}