
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How strongly the generative model reconstructs detail while upscaling. Lower values stay closer to the source image; higher values produce a more enhanced result.<br/>
    /// Default Value: high
    /// </summary>
    public enum V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength
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
    public static class V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength value)
        {
            return value switch
            {
                V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength.High => "high",
                V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength.Low => "low",
                V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength? ToEnum(string value)
        {
            return value switch
            {
                "high" => V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength.High,
                "low" => V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength.Low,
                "medium" => V2ImageUpscaleTopazWonder35PostRequestBodyContentMultipartFormDataSchemaEnhancementStrength.Medium,
                _ => null,
            };
        }
    }
}