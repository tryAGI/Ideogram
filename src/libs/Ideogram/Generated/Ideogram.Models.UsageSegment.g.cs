
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageSegment
    {
        /// <summary>
        /// Start time of the usage segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SegmentStart { get; set; }

        /// <summary>
        /// End time of the usage segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime SegmentEnd { get; set; }

        /// <summary>
        /// Tool-specific usage breakdown within this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ToolUsage> ToolUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSegment" /> class.
        /// </summary>
        /// <param name="segmentStart">
        /// Start time of the usage segment
        /// </param>
        /// <param name="segmentEnd">
        /// End time of the usage segment
        /// </param>
        /// <param name="toolUsage">
        /// Tool-specific usage breakdown within this segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageSegment(
            global::System.DateTime segmentStart,
            global::System.DateTime segmentEnd,
            global::System.Collections.Generic.IList<global::Ideogram.ToolUsage> toolUsage)
        {
            this.SegmentStart = segmentStart;
            this.SegmentEnd = segmentEnd;
            this.ToolUsage = toolUsage ?? throw new global::System.ArgumentNullException(nameof(toolUsage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSegment" /> class.
        /// </summary>
        public UsageSegment()
        {
        }
    }
}