
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The rendering quality to use. Higher quality takes longer and costs more.<br/>
    /// Default Value: high
    /// </summary>
    public enum V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality
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
    public static class V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImageRemixIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                _ => null,
            };
        }
    }
}