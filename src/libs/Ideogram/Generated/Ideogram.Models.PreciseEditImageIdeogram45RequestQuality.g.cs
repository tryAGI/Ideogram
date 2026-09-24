
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering quality to use. `very_high` renders multiple candidate edits internally and returns the one that best applies the instruction; it takes longer than `high`, is priced higher, and supports at most 4 images per request.<br/>
    /// Default Value: high
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
        VeryHigh,
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
                PreciseEditImageIdeogram45RequestQuality.VeryHigh => "very_high",
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
                "very_high" => PreciseEditImageIdeogram45RequestQuality.VeryHigh,
                _ => null,
            };
        }
    }
}