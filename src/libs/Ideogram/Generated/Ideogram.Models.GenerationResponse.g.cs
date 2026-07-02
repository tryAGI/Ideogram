
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The current status and, when complete, result data for an asynchronous generation.<br/>
    /// Example: {"generation_id":"bzue-VZtSlSMAneIbfCo2A","status":"completed","created":"2000-01-23T04:56:07\u002B00:00","response_type":"url","data":[{"prompt":"prompt","resolution":"2048x2048","seed":12345,"is_image_safe":true,"url":"https://ideogram.ai/api/images/ephemeral/xtdZiqPwRxqY1Y7NExFmzB.png?exp=1743867804\u0026sig=e13e12677633f646d8531a153d20e2d3698dca9ee7661ee5ba4f3b64e7ec3f89"}]}
    /// </summary>
    public sealed partial class GenerationResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Current status of the generation. `pending`: still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response also includes `response_type` and `data`. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerationResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.GenerationResponseStatus Status { get; set; }

        /// <summary>
        /// The time the generation was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Present when `status` is `completed`; always "url" for this shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerationResponseResponseTypeJsonConverter))]
        public global::Ideogram.GenerationResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// A list of generated images. Present when `status` is `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObject>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the generation.
        /// </param>
        /// <param name="status">
        /// Current status of the generation. `pending`: still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response also includes `response_type` and `data`. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </param>
        /// <param name="created">
        /// The time the generation was created.
        /// </param>
        /// <param name="responseType">
        /// Present when `status` is `completed`; always "url" for this shape.
        /// </param>
        /// <param name="data">
        /// A list of generated images. Present when `status` is `completed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponse(
            string generationId,
            global::Ideogram.GenerationResponseStatus status,
            global::System.DateTime created,
            global::Ideogram.GenerationResponseResponseType? responseType,
            global::System.Collections.Generic.IList<global::Ideogram.ImageGenerationObject>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Status = status;
            this.Created = created;
            this.ResponseType = responseType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationResponse" /> class.
        /// </summary>
        public GenerationResponse()
        {
        }

    }
}