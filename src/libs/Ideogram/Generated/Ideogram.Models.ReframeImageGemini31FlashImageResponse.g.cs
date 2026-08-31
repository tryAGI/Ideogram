
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Acknowledges an accepted asynchronous Reframe request. Poll<br/>
    /// `GET /v1/generations/{generation_id}` for completion and output<br/>
    /// images. The seed, width, and height report the values the request<br/>
    /// resolved to when the caller left them unset.<br/>
    /// Example: {"seed":12345,"generation_id":"generation_id","width":0,"height":6}
    /// </summary>
    public sealed partial class ReframeImageGemini31FlashImageResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// The resolved 1K output width in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The resolved 1K output height in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeImageGemini31FlashImageResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="width">
        /// The resolved 1K output width in pixels.
        /// </param>
        /// <param name="height">
        /// The resolved 1K output height in pixels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReframeImageGemini31FlashImageResponse(
            string generationId,
            int seed,
            int width,
            int height)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Seed = seed;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReframeImageGemini31FlashImageResponse" /> class.
        /// </summary>
        public ReframeImageGemini31FlashImageResponse()
        {
        }

    }
}