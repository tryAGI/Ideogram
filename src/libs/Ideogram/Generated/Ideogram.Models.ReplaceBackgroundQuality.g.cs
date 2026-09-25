
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum ReplaceBackgroundQuality
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
    public static class ReplaceBackgroundQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplaceBackgroundQuality value)
        {
            return value switch
            {
                ReplaceBackgroundQuality.High => "high",
                ReplaceBackgroundQuality.Low => "low",
                ReplaceBackgroundQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplaceBackgroundQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReplaceBackgroundQuality.High,
                "low" => ReplaceBackgroundQuality.Low,
                "medium" => ReplaceBackgroundQuality.Medium,
                _ => null,
            };
        }
    }
}