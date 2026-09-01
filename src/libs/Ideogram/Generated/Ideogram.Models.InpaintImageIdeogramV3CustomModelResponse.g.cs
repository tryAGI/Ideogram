
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by<br/>
    /// `POST /v2/images/inpaint/ideogram-v3-custom-model`. Synchronous<br/>
    /// requests include the repainted images in `data`; asynchronous requests<br/>
    /// omit `data` and can be polled with<br/>
    /// `GET /v1/generations/{generation_id}`.<br/>
    /// Example: {"data":[{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":12345,"generation_id":"generation_id","width":0,"height":6}
    /// </summary>
    public sealed partial class InpaintImageIdeogramV3CustomModelResponse
    {
        /// <summary>
        /// URL-safe base64 ID accepted by the generation polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The repainted images, in generation order. Present only for synchronous requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.InpaintedImageObject>? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="InpaintImageIdeogramV3CustomModelResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID accepted by the generation polling endpoint.
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
        /// The repainted images, in generation order. Present only for synchronous requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InpaintImageIdeogramV3CustomModelResponse(
            string generationId,
            int seed,
            int width,
            int height,
            global::System.Collections.Generic.IList<global::Ideogram.InpaintedImageObject>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data;
            this.Seed = seed;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InpaintImageIdeogramV3CustomModelResponse" /> class.
        /// </summary>
        public InpaintImageIdeogramV3CustomModelResponse()
        {
        }

    }
}