
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher.<br/>
    /// Default Value: medium
    /// </summary>
    public enum V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality
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
    public static class V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                "very_low" => V2ImagePreciseEditIdeogram45PostRequestBodyContentMultipartFormDataSchemaQuality.VeryLow,
                _ => null,
            };
        }
    }
}