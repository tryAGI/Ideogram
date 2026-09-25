
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum PreciseMaskedEditQuality
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
    public static class PreciseMaskedEditQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreciseMaskedEditQuality value)
        {
            return value switch
            {
                PreciseMaskedEditQuality.High => "high",
                PreciseMaskedEditQuality.Low => "low",
                PreciseMaskedEditQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreciseMaskedEditQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => PreciseMaskedEditQuality.High,
                "low" => PreciseMaskedEditQuality.Low,
                "medium" => PreciseMaskedEditQuality.Medium,
                _ => null,
            };
        }
    }
}