
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"segment_start":"2023-08-09T00:00:00.0000000\u002B00:00","tool_usage":[{"user_email_address":"user@company.com","model_version":"V_0_3","full_tool_name":"Turbo Image Generation V3","amount":{"amount":1050,"currency_code":"USD"},"tool_type":"GENERATE","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg"},{"user_email_address":"user@company.com","model_version":"V_0_3","full_tool_name":"Turbo Image Generation V3","amount":{"amount":1050,"currency_code":"USD"},"tool_type":"GENERATE","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg"}],"segment_end":"2023-08-09T23:59:59.0000000\u002B00:00"}
    /// </summary>
    public sealed partial class UsageSegment
    {
        /// <summary>
        /// Start time of the usage segment<br/>
        /// Example: 2023-08-09T00:00:00.0000000+00:00
        /// </summary>
        /// <example>2023-08-09T00:00:00.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime SegmentStart { get; set; } = default!;

        /// <summary>
        /// End time of the usage segment<br/>
        /// Example: 2023-08-09T23:59:59.0000000+00:00
        /// </summary>
        /// <example>2023-08-09T23:59:59.0000000+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime SegmentEnd { get; set; } = default!;

        /// <summary>
        /// Tool-specific usage breakdown within this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.ToolUsage> ToolUsage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSegment" /> class.
        /// </summary>
        /// <param name="segmentStart">
        /// Start time of the usage segment<br/>
        /// Example: 2023-08-09T00:00:00.0000000+00:00
        /// </param>
        /// <param name="segmentEnd">
        /// End time of the usage segment<br/>
        /// Example: 2023-08-09T23:59:59.0000000+00:00
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