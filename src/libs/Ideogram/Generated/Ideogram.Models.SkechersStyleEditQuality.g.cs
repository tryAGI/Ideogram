
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum SkechersStyleEditQuality
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
    public static class SkechersStyleEditQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkechersStyleEditQuality value)
        {
            return value switch
            {
                SkechersStyleEditQuality.High => "high",
                SkechersStyleEditQuality.Low => "low",
                SkechersStyleEditQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkechersStyleEditQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => SkechersStyleEditQuality.High,
                "low" => SkechersStyleEditQuality.Low,
                "medium" => SkechersStyleEditQuality.Medium,
                _ => null,
            };
        }
    }
}