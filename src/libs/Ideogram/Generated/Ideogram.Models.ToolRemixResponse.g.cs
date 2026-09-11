
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/tool/remix`. Synchronous<br/>
    /// requests (the default) include the remixed images in `data`.<br/>
    /// Requests with `async` set to true omit `data`; poll for completion<br/>
    /// and results with `GET /v1/generations/{generation_id}` using the<br/>
    /// returned `generation_id`. The seed reports the server-assigned value<br/>
    /// attached to the request; AUTO remixes are not reproducible because the<br/>
    /// selected model may synthesize an unseeded instruction prompt.<br/>
    /// Example: {"data":[{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":"","generation_id":"generation_id"}
    /// </summary>
    public sealed partial class ToolRemixResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The remixed images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? Data { get; set; }

        /// <summary>
        /// Server-assigned value attached to the request for tracing. This value does not make AUTO remixes reproducible because the selected model may synthesize an unseeded instruction prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRemixResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </param>
        /// <param name="seed">
        /// Server-assigned value attached to the request for tracing. This value does not make AUTO remixes reproducible because the selected model may synthesize an unseeded instruction prompt.
        /// </param>
        /// <param name="data">
        /// The remixed images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRemixResponse(
            string generationId,
            int seed,
            global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRemixResponse" /> class.
        /// </summary>
        public ToolRemixResponse()
        {
        }

    }
}