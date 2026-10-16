
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality
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
    public static class V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality value)
        {
            return value switch
            {
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.Auto => "auto",
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.High => "high",
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.Low => "low",
                V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.Auto,
                "high" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.High,
                "low" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.Low,
                "medium" => V2ImageGenerateGptImage25FlarePostRequestBodyContentMultipartFormDataSchemaQuality.Medium,
                _ => null,
            };
        }
    }
}