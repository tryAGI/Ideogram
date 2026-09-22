
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum AdVariationsQuality
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
    public static class AdVariationsQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdVariationsQuality value)
        {
            return value switch
            {
                AdVariationsQuality.High => "high",
                AdVariationsQuality.Low => "low",
                AdVariationsQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdVariationsQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => AdVariationsQuality.High,
                "low" => AdVariationsQuality.Low,
                "medium" => AdVariationsQuality.Medium,
                _ => null,
            };
        }
    }
}