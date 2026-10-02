
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much rendering effort the model spends. Lower tiers return sooner and cost less; `auto` lets the model choose.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ReframeImageGptImage25FlareRequestQuality
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
    public static class ReframeImageGptImage25FlareRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReframeImageGptImage25FlareRequestQuality value)
        {
            return value switch
            {
                ReframeImageGptImage25FlareRequestQuality.Auto => "auto",
                ReframeImageGptImage25FlareRequestQuality.High => "high",
                ReframeImageGptImage25FlareRequestQuality.Low => "low",
                ReframeImageGptImage25FlareRequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReframeImageGptImage25FlareRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ReframeImageGptImage25FlareRequestQuality.Auto,
                "high" => ReframeImageGptImage25FlareRequestQuality.High,
                "low" => ReframeImageGptImage25FlareRequestQuality.Low,
                "medium" => ReframeImageGptImage25FlareRequestQuality.Medium,
                _ => null,
            };
        }
    }
}