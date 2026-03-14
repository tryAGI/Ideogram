
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A spatial grouping of related text items that form a cohesive visual unit (e.g., a title group, a list, a card).<br/>
    /// Example: {"id":"id","items":[{"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"font_size":5,"glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","height":5},{"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"font_size":5,"glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","height":5}]}
    /// </summary>
    public sealed partial class TextContainerV3
    {
        /// <summary>
        /// Unique container identifier (e.g., "container_01").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Ordered list of text items in this container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.TextItemV3> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContainerV3" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique container identifier (e.g., "container_01").
        /// </param>
        /// <param name="items">
        /// Ordered list of text items in this container.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextContainerV3(
            string id,
            global::System.Collections.Generic.IList<global::Ideogram.TextItemV3> items)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContainerV3" /> class.
        /// </summary>
        public TextContainerV3()
        {
        }
    }
}