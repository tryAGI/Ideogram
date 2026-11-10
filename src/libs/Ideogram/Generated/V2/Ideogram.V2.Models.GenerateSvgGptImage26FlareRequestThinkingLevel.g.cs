
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// How much the model plans before it renders, separate from `quality`. Lower levels return sooner.<br/>
    /// Default Value: high
    /// </summary>
    public enum GenerateSvgGptImage26FlareRequestThinkingLevel
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
    public static class GenerateSvgGptImage26FlareRequestThinkingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateSvgGptImage26FlareRequestThinkingLevel value)
        {
            return value switch
            {
                GenerateSvgGptImage26FlareRequestThinkingLevel.High => "high",
                GenerateSvgGptImage26FlareRequestThinkingLevel.Low => "low",
                GenerateSvgGptImage26FlareRequestThinkingLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateSvgGptImage26FlareRequestThinkingLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerateSvgGptImage26FlareRequestThinkingLevel.High,
                "low" => GenerateSvgGptImage26FlareRequestThinkingLevel.Low,
                "medium" => GenerateSvgGptImage26FlareRequestThinkingLevel.Medium,
                _ => null,
            };
        }
    }
}