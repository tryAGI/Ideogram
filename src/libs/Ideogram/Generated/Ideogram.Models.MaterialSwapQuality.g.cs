
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum MaterialSwapQuality
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
    public static class MaterialSwapQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MaterialSwapQuality value)
        {
            return value switch
            {
                MaterialSwapQuality.High => "high",
                MaterialSwapQuality.Low => "low",
                MaterialSwapQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MaterialSwapQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => MaterialSwapQuality.High,
                "low" => MaterialSwapQuality.Low,
                "medium" => MaterialSwapQuality.Medium,
                _ => null,
            };
        }
    }
}