
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GenerateImageGptImage25SunburstRequestQuality
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
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
    public static class GenerateImageGptImage25SunburstRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageGptImage25SunburstRequestQuality value)
        {
            return value switch
            {
                GenerateImageGptImage25SunburstRequestQuality.Auto => "auto",
                GenerateImageGptImage25SunburstRequestQuality.High => "high",
                GenerateImageGptImage25SunburstRequestQuality.Low => "low",
                GenerateImageGptImage25SunburstRequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageGptImage25SunburstRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateImageGptImage25SunburstRequestQuality.Auto,
                "high" => GenerateImageGptImage25SunburstRequestQuality.High,
                "low" => GenerateImageGptImage25SunburstRequestQuality.Low,
                "medium" => GenerateImageGptImage25SunburstRequestQuality.Medium,
                _ => null,
            };
        }
    }
}