
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
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
    public static class V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.Auto => "auto",
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.Auto,
                "high" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImageGenerateGptImage25SunburstPostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                _ => null,
            };
        }
    }
}