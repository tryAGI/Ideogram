
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/image/generate/ideogram-3-character`.<br/>
    /// Synchronous requests (the default) include the generated images in<br/>
    /// `data`. Asynchronous requests omit `data`; poll<br/>
    /// `GET /v2/generations/{generation_id}` with the returned<br/>
    /// `generation_id`. `seed` is the seed that was used, including when you<br/>
    /// did not set one.<br/>
    /// Example: {"data":[{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":12345,"generation_id":"generation_id"}
    /// </summary>
    public sealed partial class GenerateImageIdeogramV3CharacterResponse
    {
        /// <summary>
        /// URL-safe base64 ID of the generation. Use it to poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The generated images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? Data { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageIdeogramV3CharacterResponse" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the generation. Use it to poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="data">
        /// The generated images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageIdeogramV3CharacterResponse(
            string generationId,
            int seed,
            global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageIdeogramV3CharacterResponse" /> class.
        /// </summary>
        public GenerateImageIdeogramV3CharacterResponse()
        {
        }

    }
}