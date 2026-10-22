
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerateSvgResponse
    {
        /// <summary>
        /// URL-safe base64 generation ID. Poll the shared generations endpoint for SVG results.
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
        /// Initializes a new instance of the <see cref="GenerateSvgResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 generation ID. Poll the shared generations endpoint for SVG results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateSvgResponse(
            string generationId)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateSvgResponse" /> class.
        /// </summary>
        public GenerateSvgResponse()
        {
        }

    }
}