
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Response returned by `POST /v2/design/layerize/ideogram-3`.<br/>
    /// Synchronous requests (the default) include the layerized design in<br/>
    /// `data`. Asynchronous requests omit `data`; poll<br/>
    /// `GET /v2/generations/{generation_id}` with the returned<br/>
    /// `generation_id`. `seed` is the seed that was used, including when you<br/>
    /// did not set one.
    /// </summary>
    public sealed partial class LayerizeDesignIdeogramV3Response
    {
        /// <summary>
        /// URL-safe base64 ID of the generation. Use it to poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// The layerized design. Present only for synchronous requests (`async` omitted or false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Ideogram.LayerizedImageObject>? Data { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
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
        /// Initializes a new instance of the <see cref="LayerizeDesignIdeogramV3Response" /> class.
        /// </summary>
        /// <param name="generationId">
        /// URL-safe base64 ID of the generation. Use it to poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="data">
        /// The layerized design. Present only for synchronous requests (`async` omitted or false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeDesignIdeogramV3Response(
            string generationId,
            int seed,
            global::System.Collections.Generic.IList<global::Ideogram.LayerizedImageObject>? data)
        {
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
            this.Data = data;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeDesignIdeogramV3Response" /> class.
        /// </summary>
        public LayerizeDesignIdeogramV3Response()
        {
        }

    }
}