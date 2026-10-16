
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier.<br/>
    /// Default Value: 1K
    /// </summary>
    public enum V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier
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
    public static class V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier value)
        {
            return value switch
            {
                V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k => "1K",
                V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k => "2K",
                V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k => "4K",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1K" => V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k,
                "2K" => V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k,
                "4K" => V2ImageGenerateNanoBanana2PostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k,
                _ => null,
            };
        }
    }
}