
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"text_containers":[{"id":"id","items":[{"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"font_size":5,"glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","height":5},{"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"font_size":5,"glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","height":5}]},{"id":"id","items":[{"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"font_size":5,"glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","height":5},{"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"font_size":5,"glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","height":5}]}],"image_layers":[{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2},{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2}],"url":"https://openapi-generator.tech","text_html":"text_html"}
    /// </summary>
    public sealed partial class LayeredImageGenerationObjectV3
    {
        /// <summary>
        /// The direct link to the text-erased base image. This is the background image with text removed, suitable for re-compositing with the text layers. Falls back to the cover image if the text-erased image is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Hierarchical text container data as a list of TextContainerV3 objects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_containers")]
        public global::System.Collections.Generic.IList<global::Ideogram.TextContainerV3>? TextContainers { get; set; }

        /// <summary>
        /// Rendered HTML string for text overlays with inline CSS for absolute positioning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_html")]
        public string? TextHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_layers")]
        public global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3>? ImageLayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayeredImageGenerationObjectV3" /> class.
        /// </summary>
        /// <param name="url">
        /// The direct link to the text-erased base image. This is the background image with text removed, suitable for re-compositing with the text layers. Falls back to the cover image if the text-erased image is unavailable.
        /// </param>
        /// <param name="textContainers">
        /// Hierarchical text container data as a list of TextContainerV3 objects.
        /// </param>
        /// <param name="textHtml">
        /// Rendered HTML string for text overlays with inline CSS for absolute positioning.
        /// </param>
        /// <param name="imageLayers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayeredImageGenerationObjectV3(
            string? url,
            global::System.Collections.Generic.IList<global::Ideogram.TextContainerV3>? textContainers,
            string? textHtml,
            global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3>? imageLayers)
        {
            this.Url = url;
            this.TextContainers = textContainers;
            this.TextHtml = textHtml;
            this.ImageLayers = imageLayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayeredImageGenerationObjectV3" /> class.
        /// </summary>
        public LayeredImageGenerationObjectV3()
        {
        }
    }
}