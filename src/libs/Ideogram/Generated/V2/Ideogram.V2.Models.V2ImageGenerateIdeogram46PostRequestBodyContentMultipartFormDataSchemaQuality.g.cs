
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium`. `very_low` is the fastest and cheapest, and renders up to 2K (2048x2048 total pixels).
    /// </summary>
    public enum V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality
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
        /// <summary>
        ///
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                "very_low" => V2ImageGenerateIdeogram46PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow,
                _ => null,
            };
        }
    }
}