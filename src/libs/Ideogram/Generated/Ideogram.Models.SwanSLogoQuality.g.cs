
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum SwanSLogoQuality
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
    public static class SwanSLogoQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwanSLogoQuality value)
        {
            return value switch
            {
                SwanSLogoQuality.High => "high",
                SwanSLogoQuality.Low => "low",
                SwanSLogoQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwanSLogoQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => SwanSLogoQuality.High,
                "low" => SwanSLogoQuality.Low,
                "medium" => SwanSLogoQuality.Medium,
                _ => null,
            };
        }
    }
}