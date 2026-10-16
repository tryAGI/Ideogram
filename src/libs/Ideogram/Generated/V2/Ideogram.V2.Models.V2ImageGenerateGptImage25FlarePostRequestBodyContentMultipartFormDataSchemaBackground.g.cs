
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The output background. `transparent` returns images with an alpha channel, `opaque` forces a solid background, and `auto` lets the model decide from the prompt.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground
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
    public static class V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground value)
        {
            return value switch
            {
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground.Auto => "auto",
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground.Opaque => "opaque",
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground.Auto,
                "opaque" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground.Opaque,
                "transparent" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaBackground.Transparent,
                _ => null,
            };
        }
    }
}