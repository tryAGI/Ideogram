
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsageInfoResponse
    {
        /// <summary>
        /// List of usage segments with tool-specific breakdowns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.UsageSegment> UsageSegments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageInfoResponse" /> class.
        /// </summary>
        /// <param name="usageSegments">
        /// List of usage segments with tool-specific breakdowns
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageInfoResponse(
            global::System.Collections.Generic.IList<global::Ideogram.UsageSegment> usageSegments)
        {
            this.UsageSegments = usageSegments ?? throw new global::System.ArgumentNullException(nameof(usageSegments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageInfoResponse" /> class.
        /// </summary>
        public GetUsageInfoResponse()
        {
        }
    }
}