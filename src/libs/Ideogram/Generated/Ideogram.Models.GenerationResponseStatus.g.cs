
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Current status of the generation. `pending`: still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response also includes `response_type` and `data`. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
    /// </summary>
    public enum GenerationResponseStatus
    {
        /// <summary>
        /// still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response also includes `response_type` and `data`. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </summary>
        Completed,
        /// <summary>
        /// still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response also includes `response_type` and `data`. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </summary>
        Failed,
        /// <summary>
        /// still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response also includes `response_type` and `data`. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationResponseStatus value)
        {
            return value switch
            {
                GenerationResponseStatus.Completed => "completed",
                GenerationResponseStatus.Failed => "failed",
                GenerationResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GenerationResponseStatus.Completed,
                "failed" => GenerationResponseStatus.Failed,
                "pending" => GenerationResponseStatus.Pending,
                _ => null,
            };
        }
    }
}