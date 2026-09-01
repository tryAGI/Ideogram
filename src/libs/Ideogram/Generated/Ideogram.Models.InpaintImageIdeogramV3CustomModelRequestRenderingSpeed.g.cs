
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
    /// </summary>
    public enum InpaintImageIdeogramV3CustomModelRequestRenderingSpeed
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
    public static class InpaintImageIdeogramV3CustomModelRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InpaintImageIdeogramV3CustomModelRequestRenderingSpeed value)
        {
            return value switch
            {
                InpaintImageIdeogramV3CustomModelRequestRenderingSpeed.Default => "DEFAULT",
                InpaintImageIdeogramV3CustomModelRequestRenderingSpeed.Quality => "QUALITY",
                InpaintImageIdeogramV3CustomModelRequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InpaintImageIdeogramV3CustomModelRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => InpaintImageIdeogramV3CustomModelRequestRenderingSpeed.Default,
                "QUALITY" => InpaintImageIdeogramV3CustomModelRequestRenderingSpeed.Quality,
                "TURBO" => InpaintImageIdeogramV3CustomModelRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}