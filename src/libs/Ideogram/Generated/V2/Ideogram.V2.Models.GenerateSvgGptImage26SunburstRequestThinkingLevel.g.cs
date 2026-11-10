
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much the model plans before it renders, separate from `quality`. Lower levels return sooner.<br/>
    /// Default Value: high
    /// </summary>
    public enum GenerateSvgGptImage26SunburstRequestThinkingLevel
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
    public static class GenerateSvgGptImage26SunburstRequestThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateSvgGptImage26SunburstRequestThinkingLevel value)
        {
            return value switch
            {
                GenerateSvgGptImage26SunburstRequestThinkingLevel.High => "high",
                GenerateSvgGptImage26SunburstRequestThinkingLevel.Low => "low",
                GenerateSvgGptImage26SunburstRequestThinkingLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateSvgGptImage26SunburstRequestThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerateSvgGptImage26SunburstRequestThinkingLevel.High,
                "low" => GenerateSvgGptImage26SunburstRequestThinkingLevel.Low,
                "medium" => GenerateSvgGptImage26SunburstRequestThinkingLevel.Medium,
                _ => null,
            };
        }
    }
}