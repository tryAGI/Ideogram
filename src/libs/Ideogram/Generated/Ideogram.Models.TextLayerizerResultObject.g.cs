
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One layerized design. Links are available for a limited period of time;<br/>
    /// if you would like to keep a file, you must download it.
    /// </summary>
    public sealed partial class TextLayerizerResultObject
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextLayerizerResultObjectObjectTypeJsonConverter))]
        public global::Ideogram.TextLayerizerResultObjectObjectType ObjectType { get; set; }

        /// <summary>
        /// Signed link to the design image with its text intact. Empty when the image did not pass safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Signed link to the base image with all detected text removed. Empty when the image did not pass safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_image_url")]
        public string? BaseImageUrl { get; set; }

        /// <summary>
        /// The resolution of the design, formatted as "WIDTHxHEIGHT".<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Resolution { get; set; }

        /// <summary>
        /// Whether the image passed safety checks. If false, the links are empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_image_safe")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsImageSafe { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// Flat list of detected text regions in the design.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.LayerizedTextBlock> TextBlocks { get; set; }

        /// <summary>
        /// Signed link to a self-contained HTML page displaying the editable<br/>
        /// design, including curved text, gradients, outlines, and shadows. The<br/>
        /// renderer, images, and fonts are embedded in the page, so it keeps<br/>
        /// working offline once downloaded; the link itself expires after 24<br/>
        /// hours. Uploaded `font_candidate_files` are embedded as supplied, so<br/>
        /// redistributing the page is subject to those fonts' licenses. Empty<br/>
        /// when the image did not pass safety checks or the page could not be<br/>
        /// built.<br/>
        /// The page exposes one editing API for every text layer, whether it<br/>
        /// is drawn as HTML or on a canvas. Each layer is addressed by its<br/>
        /// `text_blocks[].layer_id`. Scripts in the page can call<br/>
        /// `window.layerize` (`ready`, `getTextLayers()`, `setText(id, text)`,<br/>
        /// `update(id, patch)`, `toJSON()`, `toPNG()`); a parent page that<br/>
        /// embeds it in an iframe sends `postMessage` requests such as<br/>
        /// `{"type": "layerize:set-text", "id": "text-0", "text": "Hello"}`<br/>
        /// and receives `layerize:ready`, `layerize:updated`, and<br/>
        /// `layerize:error` replies. The page is served sandboxed with an<br/>
        /// opaque origin, so it cannot read cookies or storage of the site<br/>
        /// that embeds it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayerizerResultObject" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the design, formatted as "WIDTHxHEIGHT".<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="isImageSafe">
        /// Whether the image passed safety checks. If false, the links are empty.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="textBlocks">
        /// Flat list of detected text regions in the design.
        /// </param>
        /// <param name="objectType"></param>
        /// <param name="url">
        /// Signed link to the design image with its text intact. Empty when the image did not pass safety checks.
        /// </param>
        /// <param name="baseImageUrl">
        /// Signed link to the base image with all detected text removed. Empty when the image did not pass safety checks.
        /// </param>
        /// <param name="htmlUrl">
        /// Signed link to a self-contained HTML page displaying the editable<br/>
        /// design, including curved text, gradients, outlines, and shadows. The<br/>
        /// renderer, images, and fonts are embedded in the page, so it keeps<br/>
        /// working offline once downloaded; the link itself expires after 24<br/>
        /// hours. Uploaded `font_candidate_files` are embedded as supplied, so<br/>
        /// redistributing the page is subject to those fonts' licenses. Empty<br/>
        /// when the image did not pass safety checks or the page could not be<br/>
        /// built.<br/>
        /// The page exposes one editing API for every text layer, whether it<br/>
        /// is drawn as HTML or on a canvas. Each layer is addressed by its<br/>
        /// `text_blocks[].layer_id`. Scripts in the page can call<br/>
        /// `window.layerize` (`ready`, `getTextLayers()`, `setText(id, text)`,<br/>
        /// `update(id, patch)`, `toJSON()`, `toPNG()`); a parent page that<br/>
        /// embeds it in an iframe sends `postMessage` requests such as<br/>
        /// `{"type": "layerize:set-text", "id": "text-0", "text": "Hello"}`<br/>
        /// and receives `layerize:ready`, `layerize:updated`, and<br/>
        /// `layerize:error` replies. The page is served sandboxed with an<br/>
        /// opaque origin, so it cannot read cookies or storage of the site<br/>
        /// that embeds it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextLayerizerResultObject(
            string resolution,
            bool isImageSafe,
            int seed,
            global::System.Collections.Generic.IList<global::Ideogram.LayerizedTextBlock> textBlocks,
            global::Ideogram.TextLayerizerResultObjectObjectType objectType,
            string? url,
            string? baseImageUrl,
            string? htmlUrl)
        {
            this.ObjectType = objectType;
            this.Url = url;
            this.BaseImageUrl = baseImageUrl;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
            this.TextBlocks = textBlocks ?? throw new global::System.ArgumentNullException(nameof(textBlocks));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayerizerResultObject" /> class.
        /// </summary>
        public TextLayerizerResultObject()
        {
        }

    }
}