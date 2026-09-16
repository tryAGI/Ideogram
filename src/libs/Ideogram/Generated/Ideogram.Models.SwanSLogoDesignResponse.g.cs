
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"generation_id":"generation_id"}
    /// </summary>
    public sealed partial class SwanSLogoDesignResponse
    {
        /// <summary>
        /// URL-safe base64 ID accepted by GET /v1/generations/{generation_id}.
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
        /// Initializes a new instance of the <see cref="SwanSLogoDesignResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID accepted by GET /v1/generations/{generation_id}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SwanSLogoDesignResponse(
            string generationId)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwanSLogoDesignResponse" /> class.
        /// </summary>
        public SwanSLogoDesignResponse()
        {
        }

    }
}