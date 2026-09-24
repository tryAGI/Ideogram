
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/image/precise-edit/ideogram-4-5`.<br/>
    /// Synchronous requests (the default) include the edited images in `data`.<br/>
    /// Requests with `async` set to true omit `data`; poll for completion and<br/>
    /// results with `GET /v1/generations/{generation_id}` using the returned<br/>
    /// `generation_id`. The seed reports the value the request resolved to<br/>
    /// when the caller left it unset.<br/>
    /// Example: {"data":[{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true},{"seed":12345,"prompt":"prompt","resolution":"1024x1024","url":"https://openapi-generator.tech","is_image_safe":true}],"seed":0,"generation_id":"generation_id"}
    /// </summary>
    public sealed partial class PreciseEditImageIdeogram45Response
    {
        /// <summary>
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// The edited images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.GeneratedImageObject>? Data { get; set; }

        /// <summary>
        /// The seed the request was served with.
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
        /// URL-safe base64 ID of the accepted generation. Accepted by the<br/>
        /// `GET /v1/generations/{generation_id}` polling endpoint.
        /// </param>
        /// <param name="data">
        /// The edited images, in generation order. Present only for synchronous requests (`async` omitted or false).
        /// </param>
        /// <param name="seed">
        /// The seed the request was served with.
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