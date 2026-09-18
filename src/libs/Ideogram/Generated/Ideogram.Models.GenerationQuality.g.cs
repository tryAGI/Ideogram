
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The generation quality level. Higher levels may use more inference steps<br/>
    /// or additional prompt processing. `very_high` generates multiple<br/>
    /// candidates internally and returns the strongest result, so it has<br/>
    /// noticeably higher latency and cost than the other levels.
    /// </summary>
    public enum GenerationQuality
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
        /// <summary>
        ///
        /// </summary>
        VeryLow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationQuality value)
        {
            return value switch
            {
                GenerationQuality.High => "high",
                GenerationQuality.Low => "low",
                GenerationQuality.Medium => "medium",
                GenerationQuality.VeryHigh => "very_high",
                GenerationQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerationQuality.High,
                "low" => GenerationQuality.Low,
                "medium" => GenerationQuality.Medium,
                "very_high" => GenerationQuality.VeryHigh,
                "very_low" => GenerationQuality.VeryLow,
                _ => null,
            };
        }
    }
}