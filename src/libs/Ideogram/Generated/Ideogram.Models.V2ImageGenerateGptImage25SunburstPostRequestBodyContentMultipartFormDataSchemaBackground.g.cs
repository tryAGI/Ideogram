
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Opaque,
        /// <summary>
        ///
        /// </summary>
        Transparent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground value)
        {
            return value switch
            {
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground.Auto => "auto",
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground.Opaque => "opaque",
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground.Auto,
                "opaque" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground.Opaque,
                "transparent" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaBackground.Transparent,
                _ => null,
            };
        }
    }
}