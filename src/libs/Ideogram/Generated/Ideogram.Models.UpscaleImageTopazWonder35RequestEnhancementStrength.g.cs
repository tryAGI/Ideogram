
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How strongly the generative model reconstructs detail while upscaling. Lower values stay closer to the source image; higher values produce a more enhanced result.<br/>
    /// Default Value: high
    /// </summary>
    public enum UpscaleImageTopazWonder35RequestEnhancementStrength
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
    public static class UpscaleImageTopazWonder35RequestEnhancementStrengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpscaleImageTopazWonder35RequestEnhancementStrength value)
        {
            return value switch
            {
                UpscaleImageTopazWonder35RequestEnhancementStrength.High => "high",
                UpscaleImageTopazWonder35RequestEnhancementStrength.Low => "low",
                UpscaleImageTopazWonder35RequestEnhancementStrength.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpscaleImageTopazWonder35RequestEnhancementStrength? ToEnum(string value)
        {
            return value switch
            {
                "high" => UpscaleImageTopazWonder35RequestEnhancementStrength.High,
                "low" => UpscaleImageTopazWonder35RequestEnhancementStrength.Low,
                "medium" => UpscaleImageTopazWonder35RequestEnhancementStrength.Medium,
                _ => null,
            };
        }
    }
}