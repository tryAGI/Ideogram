
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the image edit. Higher tiers may improve detail<br/>
    /// and take longer to complete.
    /// </summary>
    public enum GptImage2Quality
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
    public static class GptImage2QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GptImage2Quality value)
        {
            return value switch
            {
                GptImage2Quality.High => "HIGH",
                GptImage2Quality.Low => "LOW",
                GptImage2Quality.Medium => "MEDIUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GptImage2Quality? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => GptImage2Quality.High,
                "LOW" => GptImage2Quality.Low,
                "MEDIUM" => GptImage2Quality.Medium,
                _ => null,
            };
        }
    }
}