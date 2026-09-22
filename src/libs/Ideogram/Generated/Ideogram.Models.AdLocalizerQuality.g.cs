
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum AdLocalizerQuality
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
    public static class AdLocalizerQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdLocalizerQuality value)
        {
            return value switch
            {
                AdLocalizerQuality.High => "high",
                AdLocalizerQuality.Low => "low",
                AdLocalizerQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdLocalizerQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => AdLocalizerQuality.High,
                "low" => AdLocalizerQuality.Low,
                "medium" => AdLocalizerQuality.Medium,
                _ => null,
            };
        }
    }
}