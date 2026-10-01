
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Acknowledgement that the request was accepted. The generated video is not<br/>
    /// part of this response: poll `GET /v2/generations/{generation_id}` with<br/>
    /// the returned `generation_id`, or receive it at your `webhook_url`.<br/>
    /// Video links expire after a limited time, so download any video you<br/>
    /// want to keep.<br/>
    /// Example: {"generation_id":"generation_id","created":"2000-01-23T04:56:07\u002B00:00"}
    /// </summary>
    public sealed partial class GenerateVideoSeedDance25Response
    {
        /// <summary>
        /// The generation ID to poll with `GET /v2/generations/{generation_id}`.
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
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance25Response" /> class.
        /// </summary>
        /// <param name="generationId">
        /// The generation ID to poll with `GET /v2/generations/{generation_id}`.
        /// </param>
        /// <param name="created">
        /// The time the request was accepted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoSeedDance25Response(
            string generationId,
            global::System.DateTime created)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoSeedDance25Response" /> class.
        /// </summary>
        public GenerateVideoSeedDance25Response()
        {
        }

    }
}