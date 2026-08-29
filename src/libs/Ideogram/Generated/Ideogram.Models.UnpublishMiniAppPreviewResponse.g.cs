
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Confirmation of an unpublished mini-app preview entry.<br/>
    /// Example: {"preview_id":"preview_id"}
    /// </summary>
    public sealed partial class UnpublishMiniAppPreviewResponse
    {
        /// <summary>
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviewId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnpublishMiniAppPreviewResponse" /> class.
        /// </summary>
        /// <param name="previewId">
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnpublishMiniAppPreviewResponse(
            string previewId)
        {
            this.PreviewId = previewId ?? throw new global::System.ArgumentNullException(nameof(previewId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnpublishMiniAppPreviewResponse" /> class.
        /// </summary>
        public UnpublishMiniAppPreviewResponse()
        {
        }

    }
}