
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Acknowledgement returned by the Seedance 2.0 video generation<br/>
    /// endpoints. Video generation always runs asynchronously, so the<br/>
    /// generated videos are never part of this response: poll for them with<br/>
    /// `GET /v1/generations/{generation_id}` using the returned<br/>
    /// `generation_id`, or receive them at the `webhook_url` you supplied.<br/>
    /// Example: {"generation_id":"generation_id","created":"2000-01-23T04:56:07\u002B00:00"}
    /// </summary>
    public sealed partial class GenerateVideoSeedDance2Response
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The time the request was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance2Response" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </param>
        /// <param name="created">
        /// The time the request was accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoSeedDance2Response(
            string generationId,
            global::System.DateTime created)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance2Response" /> class.
        /// </summary>
        public GenerateVideoSeedDance2Response()
        {
        }

    }
}