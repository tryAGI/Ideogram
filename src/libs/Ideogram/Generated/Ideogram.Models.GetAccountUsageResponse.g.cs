
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAccountUsageResponse
    {
        /// <summary>
        /// Dense, chronological buckets covering the requested range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buckets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AccountUsageBucket> Buckets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountUsageResponse" /> class.
        /// </summary>
        /// <param name="buckets">
        /// Dense, chronological buckets covering the requested range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAccountUsageResponse(
            global::System.Collections.Generic.IList<global::Ideogram.AccountUsageBucket> buckets)
        {
            this.Buckets = buckets ?? throw new global::System.ArgumentNullException(nameof(buckets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAccountUsageResponse" /> class.
        /// </summary>
        public GetAccountUsageResponse()
        {
        }

    }
}