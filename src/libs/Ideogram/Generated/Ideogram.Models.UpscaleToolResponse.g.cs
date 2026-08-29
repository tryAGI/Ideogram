
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/tools/upscale`. Synchronous requests<br/>
    /// (the default) include the upscaled image in `data`. Requests with<br/>
    /// `async` set to true omit `data`; poll for completion and results with<br/>
    /// `GET /v1/generations/{generation_id}` using the returned<br/>
    /// `generation_id`. The seed reports the value the request resolved to<br/>
    /// when the caller left it unset; width and height report the output<br/>
    /// dimensions.<br/>
    /// Example: {"data":[{"seed":12345,"resolution":"2048x2048","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"resolution":"2048x2048","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":12345,"generation_id":"generation_id","width":0,"height":6}
    /// </summary>
    public sealed partial class UpscaleToolResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The upscaled image. Present only for synchronous requests (`async` omitted or false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.UpscaleImageObject>? Data { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// The output width in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The output height in pixels.
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
        /// Initializes a new instance of the <see cref="UpscaleToolResponse" /> class.
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
        /// The output width in pixels.
        /// </param>
        /// <param name="height">
        /// The output height in pixels.
        /// </param>
        /// <param name="data">
        /// The upscaled image. Present only for synchronous requests (`async` omitted or false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpscaleToolResponse(
            string generationId,
            int seed,
            int width,
            int height,
            global::System.Collections.Generic.IList<global::Ideogram.UpscaleImageObject>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data;
            this.Seed = seed;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpscaleToolResponse" /> class.
        /// </summary>
        public UpscaleToolResponse()
        {
        }

    }
}