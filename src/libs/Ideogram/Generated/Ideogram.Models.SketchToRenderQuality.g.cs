
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The quality tier for the edit. Higher tiers may improve detail and<br/>
    /// take longer to complete.
    /// </summary>
    public enum SketchToRenderQuality
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
    public static class SketchToRenderQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SketchToRenderQuality value)
        {
            return value switch
            {
                SketchToRenderQuality.High => "high",
                SketchToRenderQuality.Low => "low",
                SketchToRenderQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SketchToRenderQuality? ToEnum(string value)
        {
            return value switch
            {
                "high" => SketchToRenderQuality.High,
                "low" => SketchToRenderQuality.Low,
                "medium" => SketchToRenderQuality.Medium,
                _ => null,
            };
        }
    }
}