
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum ModelSwapQuality
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
    public static class ModelSwapQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelSwapQuality value)
        {
            return value switch
            {
                ModelSwapQuality.High => "high",
                ModelSwapQuality.Low => "low",
                ModelSwapQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelSwapQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelSwapQuality.High,
                "low" => ModelSwapQuality.Low,
                "medium" => ModelSwapQuality.Medium,
                _ => null,
            };
        }
    }
}