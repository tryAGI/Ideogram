
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much rendering effort GPT Image 2.6 Flare spends on the image the SVG is drawn from. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GenerateSvgGptImage26FlareRequestQuality
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
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateSvgGptImage26FlareRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateSvgGptImage26FlareRequestQuality value)
        {
            return value switch
            {
                GenerateSvgGptImage26FlareRequestQuality.Auto => "auto",
                GenerateSvgGptImage26FlareRequestQuality.High => "high",
                GenerateSvgGptImage26FlareRequestQuality.Low => "low",
                GenerateSvgGptImage26FlareRequestQuality.Max => "max",
                GenerateSvgGptImage26FlareRequestQuality.Medium => "medium",
                GenerateSvgGptImage26FlareRequestQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateSvgGptImage26FlareRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateSvgGptImage26FlareRequestQuality.Auto,
                "high" => GenerateSvgGptImage26FlareRequestQuality.High,
                "low" => GenerateSvgGptImage26FlareRequestQuality.Low,
                "max" => GenerateSvgGptImage26FlareRequestQuality.Max,
                "medium" => GenerateSvgGptImage26FlareRequestQuality.Medium,
                "xhigh" => GenerateSvgGptImage26FlareRequestQuality.Xhigh,
                _ => null,
            };
        }
    }
}