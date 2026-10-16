
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The rendering quality to use. Higher quality takes longer and costs more. Defaults to `medium` with source images and `high` without. `very_low`, the fastest and cheapest, requires source images.
    /// </summary>
    public enum V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality
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
    public static class V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                "very_low" => V2ImageGenerateIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow,
                _ => null,
            };
        }
    }
}