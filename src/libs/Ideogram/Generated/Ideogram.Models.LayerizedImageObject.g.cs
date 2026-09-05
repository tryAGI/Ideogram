
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One layerized design. Image links are available for a limited period<br/>
    /// of time; if you would like to keep an image, you must download it.<br/>
    /// Example: {"seed":12345,"object_type":"layerized_image","resolution":"1024x1024","url":"https://openapi-generator.tech","base_image_url":"https://openapi-generator.tech","is_image_safe":true,"text_blocks":[{"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5},{"role":"heading","color":"#212121","font_alternatives":["font_alternatives","font_alternatives"],"font_size":2,"font_name":"font_name","line_height":7.0614014,"x":0,"width":1,"y":6,"angle":5.637377,"text":"Hello World","alignment":"left","formatting":["bold","bold"],"height":5}]}
    /// </summary>
    public sealed partial class LayerizedImageObject
    {
        /// <summary>
        /// Discriminates layerized results from other generation output types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.LayerizedImageObjectObjectTypeJsonConverter))]
        public global::Ideogram.LayerizedImageObjectObjectType ObjectType { get; set; }

        /// <summary>
        /// The direct link to the design image with its text intact. Empty when the image did not pass safety checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The direct link to the base image with all detected text removed. Empty when the image did not pass safety checks.
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
        /// Whether the image passed safety checks. If false, the image links are empty.
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
        public required global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock> TextBlocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedImageObject" /> class.
        /// </summary>
        /// <param name="resolution">
        /// The resolution of the design, formatted as "WIDTHxHEIGHT".<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="isImageSafe">
        /// Whether the image passed safety checks. If false, the image links are empty.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="textBlocks">
        /// Flat list of detected text regions in the design.
        /// </param>
        /// <param name="objectType">
        /// Discriminates layerized results from other generation output types.
        /// </param>
        /// <param name="url">
        /// The direct link to the design image with its text intact. Empty when the image did not pass safety checks.
        /// </param>
        /// <param name="baseImageUrl">
        /// The direct link to the base image with all detected text removed. Empty when the image did not pass safety checks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizedImageObject(
            string resolution,
            bool isImageSafe,
            int seed,
            global::System.Collections.Generic.IList<global::Ideogram.DetectedTextBlock> textBlocks,
            global::Ideogram.LayerizedImageObjectObjectType objectType,
            string? url,
            string? baseImageUrl)
        {
            this.ObjectType = objectType;
            this.Url = url;
            this.BaseImageUrl = baseImageUrl;
            this.Resolution = resolution ?? throw new global::System.ArgumentNullException(nameof(resolution));
            this.IsImageSafe = isImageSafe;
            this.Seed = seed;
            this.TextBlocks = textBlocks ?? throw new global::System.ArgumentNullException(nameof(textBlocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedImageObject" /> class.
        /// </summary>
        public LayerizedImageObject()
        {
        }

    }
}