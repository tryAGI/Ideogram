
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The output resolution tier. When omitted, the tier is inferred from `resolution`, or defaults to 1k. A color palette, style codes, style preset, or non-`auto` style type are only supported at 1k.
    /// </summary>
    public enum V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier
    {
        /// <summary>
        ///
        /// </summary>
        x1k,
        /// <summary>
        ///
        /// </summary>
        x2k,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier value)
        {
            return value switch
            {
                V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k => "1k",
                V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k => "2k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier? ToEnum(string value)
        {
            return value switch
            {
                "1k" => V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x1k,
                "2k" => V2ImageRemixAutoPostRequestBodyContentMultipartFormDataSchemaResolutionTier.x2k,
                _ => null,
            };
        }
    }
}