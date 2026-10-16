
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use. When omitted, a speed supported by the custom model is used.
    /// </summary>
    public enum V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed
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
    public static class V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed value)
        {
            return value switch
            {
                V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default => "default",
                V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality => "quality",
                V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default,
                "quality" => V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality,
                "turbo" => V2ImageGenerateIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}