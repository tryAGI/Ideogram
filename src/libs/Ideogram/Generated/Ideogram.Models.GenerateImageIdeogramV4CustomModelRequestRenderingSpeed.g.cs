
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
    /// </summary>
    public enum GenerateImageIdeogramV4CustomModelRequestRenderingSpeed
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
    public static class GenerateImageIdeogramV4CustomModelRequestRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogramV4CustomModelRequestRenderingSpeed value)
        {
            return value switch
            {
                GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Default => "DEFAULT",
                GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Quality => "QUALITY",
                GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Turbo => "TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogramV4CustomModelRequestRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Default,
                "QUALITY" => GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Quality,
                "TURBO" => GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}