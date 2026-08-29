
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The generation quality level. Higher levels may use more inference steps<br/>
    /// or additional prompt processing.
    /// </summary>
    public enum Quality
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
    public static class QualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Quality value)
        {
            return value switch
            {
                Quality.High => "HIGH",
                Quality.Low => "LOW",
                Quality.Medium => "MEDIUM",
                Quality.VeryHigh => "VERY_HIGH",
                Quality.VeryLow => "VERY_LOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Quality? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => Quality.High,
                "LOW" => Quality.Low,
                "MEDIUM" => Quality.Medium,
                "VERY_HIGH" => Quality.VeryHigh,
                "VERY_LOW" => Quality.VeryLow,
                _ => null,
            };
        }
    }
}