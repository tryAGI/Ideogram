
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The rendering quality to use. Higher quality renders take longer.<br/>
    /// Default Value: high
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
                _ => null,
            };
        }
    }
}