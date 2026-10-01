
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Acknowledgement that the request was accepted. Poll<br/>
    /// `GET /v2/generations/{generation_id}` with the returned `generation_id`<br/>
    /// for the result.<br/>
    /// Example: {"generation_id":"generation_id"}
    /// </summary>
    public sealed partial class RemoveObjectFromV2AssetsResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v2/generations/{generation_id}` polling endpoint.
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
        /// Initializes a new instance of the <see cref="RemoveObjectFromV2AssetsResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v2/generations/{generation_id}` polling endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RemoveObjectFromV2AssetsResponse(
            string generationId)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectFromV2AssetsResponse" /> class.
        /// </summary>
        public RemoveObjectFromV2AssetsResponse()
        {
        }

    }
}