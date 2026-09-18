
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
    /// </summary>
    public enum RemixImageIdeogramV3CustomModelRequestRenderingSpeed
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
    public static class RemixImageIdeogramV3CustomModelRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RemixImageIdeogramV3CustomModelRequestRenderingSpeed value)
        {
            return value switch
            {
                RemixImageIdeogramV3CustomModelRequestRenderingSpeed.Default => "default",
                RemixImageIdeogramV3CustomModelRequestRenderingSpeed.Quality => "quality",
                RemixImageIdeogramV3CustomModelRequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RemixImageIdeogramV3CustomModelRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => RemixImageIdeogramV3CustomModelRequestRenderingSpeed.Default,
                "quality" => RemixImageIdeogramV3CustomModelRequestRenderingSpeed.Quality,
                "turbo" => RemixImageIdeogramV3CustomModelRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}