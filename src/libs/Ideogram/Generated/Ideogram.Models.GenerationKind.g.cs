
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The kind of generation identified by generation_id. Both kinds can be polled through GET /v2/generations/{generation_id}.
    /// </summary>
    public enum GenerationKind
    {
        /// <summary>
        ///
        /// </summary>
        Sampling,
        /// <summary>
        ///
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationKind value)
        {
            return value switch
            {
                GenerationKind.Sampling => "sampling",
                GenerationKind.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationKind? ToEnum(string value)
        {
            return value switch
            {
                "sampling" => GenerationKind.Sampling,
                "workflow" => GenerationKind.Workflow,
                _ => null,
            };
        }
    }
}