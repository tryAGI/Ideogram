
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the reframe. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum AdResizerQuality
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
    public static class AdResizerQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdResizerQuality value)
        {
            return value switch
            {
                AdResizerQuality.High => "high",
                AdResizerQuality.Low => "low",
                AdResizerQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdResizerQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => AdResizerQuality.High,
                "low" => AdResizerQuality.Low,
                "medium" => AdResizerQuality.Medium,
                _ => null,
            };
        }
    }
}