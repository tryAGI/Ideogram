
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering quality to use. Higher quality renders take longer. With source images it defaults to `medium`, and `high` takes longer and is priced higher; `very_low` requires source images and is the fastest and cheapest. Without source images it defaults to `high`.
    /// </summary>
    public enum GenerateImageIdeogram45RequestQuality
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
    public static class GenerateImageIdeogram45RequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageIdeogram45RequestQuality value)
        {
            return value switch
            {
                GenerateImageIdeogram45RequestQuality.High => "high",
                GenerateImageIdeogram45RequestQuality.Low => "low",
                GenerateImageIdeogram45RequestQuality.Medium => "medium",
                GenerateImageIdeogram45RequestQuality.VeryLow => "very_low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageIdeogram45RequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerateImageIdeogram45RequestQuality.High,
                "low" => GenerateImageIdeogram45RequestQuality.Low,
                "medium" => GenerateImageIdeogram45RequestQuality.Medium,
                "very_low" => GenerateImageIdeogram45RequestQuality.VeryLow,
                _ => null,
            };
        }
    }
}