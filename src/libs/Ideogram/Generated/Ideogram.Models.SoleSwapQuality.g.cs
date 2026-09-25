
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum SoleSwapQuality
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
    public static class SoleSwapQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SoleSwapQuality value)
        {
            return value switch
            {
                SoleSwapQuality.High => "high",
                SoleSwapQuality.Low => "low",
                SoleSwapQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SoleSwapQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => SoleSwapQuality.High,
                "low" => SoleSwapQuality.Low,
                "medium" => SoleSwapQuality.Medium,
                _ => null,
            };
        }
    }
}