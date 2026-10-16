
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The output resolution tier. Affects which model serves the request, since not every model offers every tier. When omitted, the selected model's default tier is used.
    /// </summary>
    public enum V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier
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
    public static class V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier value)
        {
            return value switch
            {
                V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k => "1k",
                V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k => "2k",
                V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k => "4k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1k" => V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k,
                "2k" => V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k,
                "4k" => V2ImageGenerateAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x4k,
                _ => null,
            };
        }
    }
}