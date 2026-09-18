
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
    /// </summary>
    public enum GenerateImageIdeogramV3CustomModelRequestRenderingSpeed
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
    public static class GenerateImageIdeogramV3CustomModelRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV3CustomModelRequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV3CustomModelRequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV3CustomModelRequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV3CustomModelRequestRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV3CustomModelRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => GenerateImageIdeogramV3CustomModelRequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV3CustomModelRequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV3CustomModelRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}