
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The output resolution tier. The model sizes its output by tier at the source image's aspect ratio; exact pixel dimensions cannot be requested. Rejected when the source is already at or above the requested tier. Defaults to "2K".<br/>
    /// Default Value: 2K
    /// </summary>
    public enum V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier
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
    public static class V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier value)
        {
            return value switch
            {
                V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k => "1K",
                V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k => "2K",
                V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k,
                "2K" => V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k,
                "4K" => V2ImageUpscaleNanoBananaProPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k,
                _ => null,
            };
        }
    }
}