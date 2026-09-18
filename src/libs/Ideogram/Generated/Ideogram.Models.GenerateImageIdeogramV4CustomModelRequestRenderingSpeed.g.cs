
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
                GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Default => "default",
                GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Quality => "quality",
                GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Turbo => "turbo",
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
                "default" => GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Default,
                "quality" => GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Quality,
                "turbo" => GenerateImageIdeogramV4CustomModelRequestRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}