
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"validation_state":"TRUSTED","provider":"provider","generation_id":"generation_id","system_version":"system_version","provenance_detected":true,"created_at":"created_at"}
    /// </summary>
    public sealed partial class ProvenanceVerifyResponse
    {
        /// <summary>
        /// Whether an Ideogram provenance manifest was found in the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provenance_detected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ProvenanceDetected { get; set; }

        /// <summary>
        /// Validation outcome for the detected manifest. `VALID` and `TRUSTED`<br/>
        /// both mean the content is unmodified since it was signed; `INVALID`<br/>
        /// means the content or its manifest was altered after signing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ProvenanceVerifyResponseValidationStateJsonConverter))]
        public global::Ideogram.ProvenanceVerifyResponseValidationState? ValidationState { get; set; }

        /// <summary>
        /// Name of the provider that created the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Version of the generation system that created the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_version")]
        public string? SystemVersion { get; set; }

        /// <summary>
        /// Creation time of the content, as an ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier of the generation, as a base64 URL-safe string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceVerifyResponse" /> class.
        /// </summary>
        /// <param name="provenanceDetected">
        /// Whether an Ideogram provenance manifest was found in the content.
        /// </param>
        /// <param name="validationState">
        /// Validation outcome for the detected manifest. `VALID` and `TRUSTED`<br/>
        /// both mean the content is unmodified since it was signed; `INVALID`<br/>
        /// means the content or its manifest was altered after signing.
        /// </param>
        /// <param name="provider">
        /// Name of the provider that created the content.
        /// </param>
        /// <param name="systemVersion">
        /// Version of the generation system that created the content.
        /// </param>
        /// <param name="createdAt">
        /// Creation time of the content, as an ISO 8601 timestamp.
        /// </param>
        /// <param name="generationId">
        /// Unique identifier of the generation, as a base64 URL-safe string.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvenanceVerifyResponse(
            bool provenanceDetected,
            global::Ideogram.ProvenanceVerifyResponseValidationState? validationState,
            string? provider,
            string? systemVersion,
            string? createdAt,
            string? generationId)
        {
            this.ProvenanceDetected = provenanceDetected;
            this.ValidationState = validationState;
            this.Provider = provider;
            this.SystemVersion = systemVersion;
            this.CreatedAt = createdAt;
            this.GenerationId = generationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceVerifyResponse" /> class.
        /// </summary>
        public ProvenanceVerifyResponse()
        {
        }

    }
}