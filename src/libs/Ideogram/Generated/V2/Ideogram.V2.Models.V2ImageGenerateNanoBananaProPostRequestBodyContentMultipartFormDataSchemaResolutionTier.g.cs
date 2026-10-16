
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The output resolution tier.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
        /// <summary>
        ///
        /// </summary>
        x4k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier value)
        {
            return value switch
            {
                V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k => "1K",
                V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k => "2K",
                V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k,
                "2K" => V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k,
                "4K" => V2ImageGenerateNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k,
                _ => null,
            };
        }
    }
}