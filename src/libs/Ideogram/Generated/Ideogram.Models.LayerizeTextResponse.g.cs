
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response containing detected text blocks and a text-erased base image.<br/>
    /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.<br/>
    /// Example: {"original_image_url":"https://openapi-generator.tech","seed":12345,"base_image_url":"https://openapi-generator.tech","text_blocks":[{"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5},{"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5}]}
    /// </summary>
    public sealed partial class LayerizeTextResponse
    {
        /// <summary>
        /// URL of the image with all detected text removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseImageUrl { get; set; }

        /// <summary>
        /// URL of the original image with text intact.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_image_url")]
        public string? OriginalImageUrl { get; set; }

        /// <summary>
        /// Flat list of detected text regions in the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock> TextBlocks { get; set; }

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
        /// Initializes a new instance of the <see cref="LayerizeTextResponse" /> class.
        /// </summary>
        /// <param name="baseImageUrl">
        /// URL of the image with all detected text removed.
        /// </param>
        /// <param name="textBlocks">
        /// Flat list of detected text regions in the image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="originalImageUrl">
        /// URL of the original image with text intact.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextResponse(
            string baseImageUrl,
            global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock> textBlocks,
            int seed,
            string? originalImageUrl)
        {
            this.BaseImageUrl = baseImageUrl ?? throw new global::System.ArgumentNullException(nameof(baseImageUrl));
            this.OriginalImageUrl = originalImageUrl;
            this.TextBlocks = textBlocks ?? throw new global::System.ArgumentNullException(nameof(textBlocks));
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextResponse" /> class.
        /// </summary>
        public LayerizeTextResponse()
        {
        }
    }
}