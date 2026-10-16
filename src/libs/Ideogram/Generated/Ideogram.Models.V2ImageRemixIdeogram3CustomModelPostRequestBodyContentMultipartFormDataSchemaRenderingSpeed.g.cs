
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
    /// </summary>
    public enum V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed
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
    public static class V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed value)
        {
            return value switch
            {
                V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default => "default",
                V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality => "quality",
                V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default,
                "quality" => V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality,
                "turbo" => V2ImageRemixIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}