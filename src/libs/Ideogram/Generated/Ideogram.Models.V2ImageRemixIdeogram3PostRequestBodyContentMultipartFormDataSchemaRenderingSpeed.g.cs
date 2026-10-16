
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed
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
    public static class V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed value)
        {
            return value switch
            {
                V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default => "default",
                V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality => "quality",
                V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default,
                "quality" => V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality,
                "turbo" => V2ImageRemixIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}