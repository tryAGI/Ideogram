
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// How much the model may rewrite the prompt before generating. `disabled`<br/>
    /// uses the prompt as written; the other modes trade latency for a richer<br/>
    /// rewrite.<br/>
    /// Default Value: balanced
    /// </summary>
    public enum MinimaxH3PromptExpansionMode
    {
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Quality,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinimaxH3PromptExpansionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxH3PromptExpansionMode value)
        {
            return value switch
            {
                MinimaxH3PromptExpansionMode.Balanced => "balanced",
                MinimaxH3PromptExpansionMode.Disabled => "disabled",
                MinimaxH3PromptExpansionMode.Fast => "fast",
                MinimaxH3PromptExpansionMode.Quality => "quality",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxH3PromptExpansionMode? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => MinimaxH3PromptExpansionMode.Balanced,
                "disabled" => MinimaxH3PromptExpansionMode.Disabled,
                "fast" => MinimaxH3PromptExpansionMode.Fast,
                "quality" => MinimaxH3PromptExpansionMode.Quality,
                _ => null,
            };
        }
    }
}