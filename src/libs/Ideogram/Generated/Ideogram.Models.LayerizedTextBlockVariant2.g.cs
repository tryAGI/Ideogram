
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizedTextBlockVariant2
    {
        /// <summary>
        /// Identifier of this block's layer in the page at `html_url`; pass it to the page's editing API.<br/>
        /// Example: text-0
        /// </summary>
        /// <example>text-0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayerId { get; set; }

        /// <summary>
        /// The block's colour runs in reading order. Present, with at least one<br/>
        /// run, whenever `color` is set; concatenating the runs' `text` reproduces<br/>
        /// the block's `text`. `color` reports the dominant colour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Ideogram.TextColorSpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedTextBlockVariant2" /> class.
        /// </summary>
        /// <param name="layerId">
        /// Identifier of this block's layer in the page at `html_url`; pass it to the page's editing API.<br/>
        /// Example: text-0
        /// </param>
        /// <param name="spans">
        /// The block's colour runs in reading order. Present, with at least one<br/>
        /// run, whenever `color` is set; concatenating the runs' `text` reproduces<br/>
        /// the block's `text`. `color` reports the dominant colour.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizedTextBlockVariant2(
            string layerId,
            global::System.Collections.Generic.IList<global::Ideogram.TextColorSpan>? spans)
        {
            this.LayerId = layerId ?? throw new global::System.ArgumentNullException(nameof(layerId));
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedTextBlockVariant2" /> class.
        /// </summary>
        public LayerizedTextBlockVariant2()
        {
        }

    }
}