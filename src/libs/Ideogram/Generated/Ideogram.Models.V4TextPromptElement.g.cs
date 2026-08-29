
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A text element to render in the V4 prompt layout.
    /// </summary>
    public sealed partial class V4TextPromptElement
    {
        /// <summary>
        /// Discriminator. Must be `text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.V4TextPromptElementTypeJsonConverter))]
        public global::Ideogram.V4TextPromptElementType Type { get; set; }

        /// <summary>
        /// Bounding box for an element, expressed as four integers in `[0, 1000]`<br/>
        /// with `[y_min, x_min, y_max, x_max]` semantics (row-first). Values are<br/>
        /// normalized so the canvas is `1000 x 1000` regardless of the final<br/>
        /// resolution.<br/>
        /// Example: [0, 0, 1000, 1000]
        /// </summary>
        /// <example>[0, 0, 1000, 1000]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox")]
        public global::System.Collections.Generic.IList<int>? Bbox { get; set; }

        /// <summary>
        /// The literal text to render in the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Description of the text element (style, role, placement notes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Desc { get; set; }

        /// <summary>
        /// Optional list of hex color strings (e.g. "#FFD700") that bias the<br/>
        /// Ideogram 4.0 output toward this palette. Applied as a soft color bias,<br/>
        /// not an exact per-pixel lock.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        public global::System.Collections.Generic.IList<string>? ColorPalette { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V4TextPromptElement" /> class.
        /// </summary>
        /// <param name="text">
        /// The literal text to render in the image.
        /// </param>
        /// <param name="desc">
        /// Description of the text element (style, role, placement notes).
        /// </param>
        /// <param name="type">
        /// Discriminator. Must be `text`.
        /// </param>
        /// <param name="bbox">
        /// Bounding box for an element, expressed as four integers in `[0, 1000]`<br/>
        /// with `[y_min, x_min, y_max, x_max]` semantics (row-first). Values are<br/>
        /// normalized so the canvas is `1000 x 1000` regardless of the final<br/>
        /// resolution.<br/>
        /// Example: [0, 0, 1000, 1000]
        /// </param>
        /// <param name="colorPalette">
        /// Optional list of hex color strings (e.g. "#FFD700") that bias the<br/>
        /// Ideogram 4.0 output toward this palette. Applied as a soft color bias,<br/>
        /// not an exact per-pixel lock.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V4TextPromptElement(
            string text,
            string desc,
            global::Ideogram.V4TextPromptElementType type,
            global::System.Collections.Generic.IList<int>? bbox,
            global::System.Collections.Generic.IList<string>? colorPalette)
        {
            this.Type = type;
            this.Bbox = bbox;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Desc = desc ?? throw new global::System.ArgumentNullException(nameof(desc));
            this.ColorPalette = colorPalette;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V4TextPromptElement" /> class.
        /// </summary>
        public V4TextPromptElement()
        {
        }

    }
}