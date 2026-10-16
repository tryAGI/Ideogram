
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering speed to use.<br/>
    /// Default Value: default
    /// </summary>
    public enum V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed
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
    public static class V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed value)
        {
            return value switch
            {
                V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default => "default",
                V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality => "quality",
                V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo => "turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? ToEnum(string value)
        {
            return value switch
            {
                "default" => V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Default,
                "quality" => V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Quality,
                "turbo" => V2ImageInpaintIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed.Turbo,
                _ => null,
            };
        }
    }
}