
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much rendering effort GPT Image 2.6 Sunburst spends on the image the SVG is drawn from. Lower tiers return sooner and cost less; `auto` lets the model choose, which it currently renders at `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum GenerateSvgGptImage26SunburstRequestQuality
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
    public static class GenerateSvgGptImage26SunburstRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateSvgGptImage26SunburstRequestQuality value)
        {
            return value switch
            {
                GenerateSvgGptImage26SunburstRequestQuality.Auto => "auto",
                GenerateSvgGptImage26SunburstRequestQuality.High => "high",
                GenerateSvgGptImage26SunburstRequestQuality.Low => "low",
                GenerateSvgGptImage26SunburstRequestQuality.Max => "max",
                GenerateSvgGptImage26SunburstRequestQuality.Medium => "medium",
                GenerateSvgGptImage26SunburstRequestQuality.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateSvgGptImage26SunburstRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GenerateSvgGptImage26SunburstRequestQuality.Auto,
                "high" => GenerateSvgGptImage26SunburstRequestQuality.High,
                "low" => GenerateSvgGptImage26SunburstRequestQuality.Low,
                "max" => GenerateSvgGptImage26SunburstRequestQuality.Max,
                "medium" => GenerateSvgGptImage26SunburstRequestQuality.Medium,
                "xhigh" => GenerateSvgGptImage26SunburstRequestQuality.Xhigh,
                _ => null,
            };
        }
    }
}