
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum ColorwaysQuality
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
    public static class ColorwaysQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColorwaysQuality value)
        {
            return value switch
            {
                ColorwaysQuality.High => "high",
                ColorwaysQuality.Low => "low",
                ColorwaysQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColorwaysQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => ColorwaysQuality.High,
                "low" => ColorwaysQuality.Low,
                "medium" => ColorwaysQuality.Medium,
                _ => null,
            };
        }
    }
}