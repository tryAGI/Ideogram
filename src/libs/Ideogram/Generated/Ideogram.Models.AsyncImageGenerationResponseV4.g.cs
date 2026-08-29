
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Acknowledgement returned by the async (webhook) generation endpoints. The<br/>
    /// request is accepted for asynchronous processing and the generated images<br/>
    /// are POSTed to the supplied `webhook_url` once ready; this body carries only<br/>
    /// the generation_id so the caller can correlate the eventual webhook delivery.<br/>
    /// Example: {"generation_id":"generation_id"}
    /// </summary>
    public sealed partial class AsyncImageGenerationResponseV4
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Matches the<br/>
        /// `generation_id` field delivered in the webhook payload, and the<br/>
        /// `generation_id` accepted by the generation polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncImageGenerationResponseV4" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the accepted generation. Matches the<br/>
        /// `generation_id` field delivered in the webhook payload, and the<br/>
        /// `generation_id` accepted by the generation polling endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncImageGenerationResponseV4(
            string generationId)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncImageGenerationResponseV4" /> class.
        /// </summary>
        public AsyncImageGenerationResponseV4()
        {
        }

    }
}