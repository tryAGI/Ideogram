
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The output background. `transparent` returns images with an alpha channel, `opaque` returns a solid one, and `auto` decides for you.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground
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
    public static class V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground value)
        {
            return value switch
            {
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground.Auto => "auto",
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground.Opaque => "opaque",
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground.Auto,
                "opaque" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground.Opaque,
                "transparent" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaBackground.Transparent,
                _ => null,
            };
        }
    }
}