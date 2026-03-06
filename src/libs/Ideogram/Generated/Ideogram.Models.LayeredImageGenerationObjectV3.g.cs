
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"text_layers":[{"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5},{"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5}],"image_layers":[{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2},{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2}]}
    /// </summary>
    public sealed partial class LayeredImageGenerationObjectV3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_layers")]
        public global::System.Collections.Generic.IList<global::Ideogram.TextLayerV3>? TextLayers { get; set; }

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
        /// <param name="textLayers"></param>
        /// <param name="imageLayers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayeredImageGenerationObjectV3(
            global::System.Collections.Generic.IList<global::Ideogram.TextLayerV3>? textLayers,
            global::System.Collections.Generic.IList<global::Ideogram.ImageLayerV3>? imageLayers)
        {
            this.TextLayers = textLayers;
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