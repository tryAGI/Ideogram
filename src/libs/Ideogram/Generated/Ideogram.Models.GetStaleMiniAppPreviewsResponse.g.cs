
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Preview entries older than the requested cutoff.<br/>
    /// Example: {"preview_ids":[null,null]}
    /// </summary>
    public sealed partial class GetStaleMiniAppPreviewsResponse
    {
        /// <summary>
        /// Unique identifiers of the stale preview entries, sorted lexicographically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PreviewIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStaleMiniAppPreviewsResponse" /> class.
        /// </summary>
        /// <param name="previewIds">
        /// Unique identifiers of the stale preview entries, sorted lexicographically.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStaleMiniAppPreviewsResponse(
            global::System.Collections.Generic.IList<string> previewIds)
        {
            this.PreviewIds = previewIds ?? throw new global::System.ArgumentNullException(nameof(previewIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStaleMiniAppPreviewsResponse" /> class.
        /// </summary>
        public GetStaleMiniAppPreviewsResponse()
        {
        }

    }
}