
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The queue this request resolved to. Present when `reject_reason`<br/>
    /// is `inflight_limit`.
    /// </summary>
    public enum GenerationErrorResponseTaskCompletionSpeed
    {
        /// <summary>
        ///
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Slow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationErrorResponseTaskCompletionSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationErrorResponseTaskCompletionSpeed value)
        {
            return value switch
            {
                GenerationErrorResponseTaskCompletionSpeed.Fast => "fast",
                GenerationErrorResponseTaskCompletionSpeed.Slow => "slow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationErrorResponseTaskCompletionSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => GenerationErrorResponseTaskCompletionSpeed.Fast,
                "slow" => GenerationErrorResponseTaskCompletionSpeed.Slow,
                _ => null,
            };
        }
    }
}