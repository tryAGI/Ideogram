
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum PackshotsQuality
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
    public static class PackshotsQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PackshotsQuality value)
        {
            return value switch
            {
                PackshotsQuality.High => "high",
                PackshotsQuality.Low => "low",
                PackshotsQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PackshotsQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => PackshotsQuality.High,
                "low" => PackshotsQuality.Low,
                "medium" => PackshotsQuality.Medium,
                _ => null,
            };
        }
    }
}