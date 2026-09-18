
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GenerateImageGptImage25FlareRequestQuality
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
    public static class GenerateImageGptImage25FlareRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageGptImage25FlareRequestQuality value)
        {
            return value switch
            {
                GenerateImageGptImage25FlareRequestQuality.Auto => "auto",
                GenerateImageGptImage25FlareRequestQuality.High => "high",
                GenerateImageGptImage25FlareRequestQuality.Low => "low",
                GenerateImageGptImage25FlareRequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageGptImage25FlareRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateImageGptImage25FlareRequestQuality.Auto,
                "high" => GenerateImageGptImage25FlareRequestQuality.High,
                "low" => GenerateImageGptImage25FlareRequestQuality.Low,
                "medium" => GenerateImageGptImage25FlareRequestQuality.Medium,
                _ => null,
            };
        }
    }
}