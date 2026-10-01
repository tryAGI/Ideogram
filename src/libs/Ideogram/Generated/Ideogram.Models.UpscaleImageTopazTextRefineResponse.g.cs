
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Synchronous requests (the default) include the upscaled image in `data`.<br/>
    /// Async requests omit `data`; poll `GET /v2/generations/{generation_id}`<br/>
    /// with the returned `generation_id`. `seed` is the seed actually used,<br/>
    /// and `width` and `height` are the output dimensions.<br/>
    /// Example: {"data":[{"seed":12345,"resolution":"2048x2048","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"resolution":"2048x2048","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":12345,"generation_id":"generation_id","width":0,"height":6}
    /// </summary>
    public sealed partial class UpscaleImageTopazTextRefineResponse
    {
        /// <summary>
        /// The generation ID to poll with `GET /v2/generations/{generation_id}`.
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
        /// Initializes a new instance of the <see cref="UpscaleImageTopazTextRefineResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// The generation ID to poll with `GET /v2/generations/{generation_id}`.
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
        public UpscaleImageTopazTextRefineResponse(
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
        /// Initializes a new instance of the <see cref="UpscaleImageTopazTextRefineResponse" /> class.
        /// </summary>
        public UpscaleImageTopazTextRefineResponse()
        {
        }

    }
}