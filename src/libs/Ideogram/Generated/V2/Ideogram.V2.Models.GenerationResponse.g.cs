
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// The current status and, when complete, result data for an asynchronous generation.
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
        /// Current status of the generation. `pending`: still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response includes `response_type` and `data`, and may include `usage_cost_usd_micros` when the request uses variable usage-based pricing. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.GenerationResponseStatus Status { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.GenerationResponseResponseTypeJsonConverter))]
        public global::Ideogram.V2.GenerationResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// The total variable usage-based cost charged for the completed request, in millionths of a US dollar. Present only when `status` is `completed` and the request uses variable usage-based pricing; omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_cost_usd_micros")]
        public long? UsageCostUsdMicros { get; set; }

        /// <summary>
        /// A short machine-readable reason the generation failed, for example<br/>
        /// `content_policy_violation`. Present only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public string? FailureReason { get; set; }

        /// <summary>
        /// A list of generated images or videos. Present when `status` is<br/>
        /// `completed`. Video entries carry an `object_type` of<br/>
        /// `video.generation`; layerized designs carry `layerized_image`;<br/>
        /// entries without an `object_type` are images.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.GenerationResponseDataInner>? Data { get; set; }

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
        /// Current status of the generation. `pending`: still in progress; the response contains only `generation_id`, `status`, and `created`. `completed`: finished successfully; the response includes `response_type` and `data`, and may include `usage_cost_usd_micros` when the request uses variable usage-based pricing. `failed`: generation did not succeed; the response contains only `generation_id`, `status`, and `created`.
        /// </param>
        /// <param name="created">
        /// The time the generation was created.
        /// </param>
        /// <param name="responseType">
        /// Present when `status` is `completed`; always "url" for this shape.
        /// </param>
        /// <param name="usageCostUsdMicros">
        /// The total variable usage-based cost charged for the completed request, in millionths of a US dollar. Present only when `status` is `completed` and the request uses variable usage-based pricing; omitted otherwise.
        /// </param>
        /// <param name="failureReason">
        /// A short machine-readable reason the generation failed, for example<br/>
        /// `content_policy_violation`. Present only when `status` is `failed`.
        /// </param>
        /// <param name="data">
        /// A list of generated images or videos. Present when `status` is<br/>
        /// `completed`. Video entries carry an `object_type` of<br/>
        /// `video.generation`; layerized designs carry `layerized_image`;<br/>
        /// entries without an `object_type` are images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationResponse(
            string generationId,
            global::Ideogram.V2.GenerationResponseStatus status,
            global::System.DateTime created,
            global::Ideogram.V2.GenerationResponseResponseType? responseType,
            long? usageCostUsdMicros,
            string? failureReason,
            global::System.Collections.Generic.IList<global::Ideogram.V2.GenerationResponseDataInner>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Status = status;
            this.Created = created;
            this.ResponseType = responseType;
            this.UsageCostUsdMicros = usageCostUsdMicros;
            this.FailureReason = failureReason;
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