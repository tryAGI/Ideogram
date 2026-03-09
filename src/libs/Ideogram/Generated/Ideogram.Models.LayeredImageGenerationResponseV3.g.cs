
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response which contains information about the generated image, including the download link and other text layeres.<br/>
    /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.<br/>
    /// Example: {"data":[{"text_layers":[{"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5},{"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5}],"image_layers":[{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2},{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2}]},{"text_layers":[{"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5},{"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5}],"image_layers":[{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2},{"ref_id":"REF_0","x":7,"width":3,"y":9,"height":2}]}],"created":"2000-01-23T04:56:07\u002B00:00"}
    /// </summary>
    public sealed partial class LayeredImageGenerationResponseV3
    {
        /// <summary>
        /// The time the request was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// A list of ImageObjects that contain the generated image(s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.LayeredImageGenerationObjectV3> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayeredImageGenerationResponseV3" /> class.
        /// </summary>
        /// <param name="created">
        /// The time the request was created.
        /// </param>
        /// <param name="data">
        /// A list of ImageObjects that contain the generated image(s).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayeredImageGenerationResponseV3(
            global::System.DateTime created,
            global::System.Collections.Generic.IList<global::Ideogram.LayeredImageGenerationObjectV3> data)
        {
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayeredImageGenerationResponseV3" /> class.
        /// </summary>
        public LayeredImageGenerationResponseV3()
        {
        }
    }
}