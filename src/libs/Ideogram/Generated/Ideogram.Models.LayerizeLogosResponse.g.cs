
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Results of image-reference recognition. The `base_image_url` points at the design<br/>
    /// with the detected reference images inpainted out. The `layers` array lists each<br/>
    /// matched reference and its bounding box on the original image; it is empty when<br/>
    /// no reference image was matched.<br/>
    /// Image links are available for a limited period of time; if you would like to keep<br/>
    /// the image, you must download it.<br/>
    /// Example: {"layers":[{"ref_id":"REF_0","x":4,"width":1,"y":7,"height":1},{"ref_id":"REF_0","x":4,"width":1,"y":7,"height":1}],"base_image_url":"https://openapi-generator.tech"}
    /// </summary>
    public sealed partial class LayerizeLogosResponse
    {
        /// <summary>
        /// URL of the design image with all detected reference images inpainted out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseImageUrl { get; set; }

        /// <summary>
        /// Matched reference images, each with its bounding box on the original design.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3> Layers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeLogosResponse" /> class.
        /// </summary>
        /// <param name="baseImageUrl">
        /// URL of the design image with all detected reference images inpainted out.
        /// </param>
        /// <param name="layers">
        /// Matched reference images, each with its bounding box on the original design.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeLogosResponse(
            string baseImageUrl,
            global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3> layers)
        {
            this.BaseImageUrl = baseImageUrl ?? throw new global::System.ArgumentNullException(nameof(baseImageUrl));
            this.Layers = layers ?? throw new global::System.ArgumentNullException(nameof(layers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeLogosResponse" /> class.
        /// </summary>
        public LayerizeLogosResponse()
        {
        }

    }
}