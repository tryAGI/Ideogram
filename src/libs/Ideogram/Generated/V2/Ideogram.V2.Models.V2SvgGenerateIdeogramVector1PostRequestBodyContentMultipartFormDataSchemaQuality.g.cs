
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// Default Value: medium
    /// </summary>
    public enum V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                _ => null,
            };
        }
    }
}