
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/image/precise-edit/ideogram-4-5`.<br/>
    /// Synchronous requests (the default) include the edited images in `data`.<br/>
    /// Asynchronous requests omit `data`; poll<br/>
    /// `GET /v2/generations/{generation_id}` with the returned<br/>
    /// `generation_id`.<br/>
    /// Example: {"data":[{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":0,"generation_id":"generation_id"}
    /// </summary>
    public sealed partial class PreciseEditImageIdeogram45Response
    {
        /// <summary>
        /// URL-safe base64 ID of the generation. Use it to poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// The edited images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? Data { get; set; }

        /// <summary>
        /// The seed that was used, including when you did not set one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreciseEditImageIdeogram45Response" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the generation. Use it to poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </param>
        /// <param name="data">
        /// The edited images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </param>
        /// <param name="seed">
        /// The seed that was used, including when you did not set one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreciseEditImageIdeogram45Response(
            string? generationId,
            global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? data,
            int? seed)
        {
            this.GenerationId = generationId;
            this.Data = data;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreciseEditImageIdeogram45Response" /> class.
        /// </summary>
        public PreciseEditImageIdeogram45Response()
        {
        }

    }
}