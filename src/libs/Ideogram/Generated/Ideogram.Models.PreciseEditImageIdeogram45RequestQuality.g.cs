
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering quality to use. `very_low` is the fastest and cheapest, and `high` takes longer and is priced higher.<br/>
    /// Default Value: medium
    /// </summary>
    public enum PreciseEditImageIdeogram45RequestQuality
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
        /// <summary>
        ///
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreciseEditImageIdeogram45RequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreciseEditImageIdeogram45RequestQuality value)
        {
            return value switch
            {
                PreciseEditImageIdeogram45RequestQuality.High => "high",
                PreciseEditImageIdeogram45RequestQuality.Low => "low",
                PreciseEditImageIdeogram45RequestQuality.Medium => "medium",
                PreciseEditImageIdeogram45RequestQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreciseEditImageIdeogram45RequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => PreciseEditImageIdeogram45RequestQuality.High,
                "low" => PreciseEditImageIdeogram45RequestQuality.Low,
                "medium" => PreciseEditImageIdeogram45RequestQuality.Medium,
                "very_low" => PreciseEditImageIdeogram45RequestQuality.VeryLow,
                _ => null,
            };
        }
    }
}