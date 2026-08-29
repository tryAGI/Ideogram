
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A single text block within a container, representing one logical unit of text (e.g., a headline, a paragraph, a list entry).<br/>
    /// Example: {"font_candidates":["font_candidates","font_candidates"],"spans":[{"color":"#212121","text":"text","font_fx":["bold","italic"]},{"color":"#212121","text":"text","font_fx":["bold","italic"]}],"text_shadows":[{"color":"color","blur":0.2027123,"offset_x":9.301444,"offset_y":3.6160767},{"color":"color","blur":0.2027123,"offset_x":9.301444,"offset_y":3.6160767}],"font_size":5,"vertical_alignment":"top","text_transform":"none","glyph_type":"bullet","line_height":2.302136,"x":0,"width":1,"style_class":"body","y":6,"angle":0,"alignment":"center","font_file":"font_file","letter_spacing":7.0614014,"height":5}
    /// </summary>
    public sealed partial class TextItemV3
    {
        /// <summary>
        /// The x coordinate of the item in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y coordinate of the item in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// The width of the item in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The height of the item in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// The text alignment of the item.<br/>
        /// Example: center
        /// </summary>
        /// <example>center</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextItemV3AlignmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.TextItemV3Alignment Alignment { get; set; }

        /// <summary>
        /// The angle rotation of the text, measured clockwise in degrees.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("angle")]
        public float? Angle { get; set; }

        /// <summary>
        /// Typographic classification of the text.<br/>
        /// Example: body
        /// </summary>
        /// <example>body</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextItemV3StyleClassJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.TextItemV3StyleClass StyleClass { get; set; }

        /// <summary>
        /// The type of list marker glyph, if any. Null for non-list items.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("glyph_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextItemV3GlyphTypeJsonConverter))]
        public global::Ideogram.TextItemV3GlyphType? GlyphType { get; set; }

        /// <summary>
        /// The matched font file for this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file")]
        public string? FontFile { get; set; }

        /// <summary>
        /// A list of alternate matching font files for this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_candidates")]
        public global::System.Collections.Generic.IList<string>? FontCandidates { get; set; }

        /// <summary>
        /// The font size in points. Null for non-editable items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public int? FontSize { get; set; }

        /// <summary>
        /// The line height multiplier (e.g., 1.2). Null for non-editable items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_height")]
        public float? LineHeight { get; set; }

        /// <summary>
        /// Letter spacing in em units (e.g. 0.05 = 5% of em). V4 vector-text only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("letter_spacing")]
        public float? LetterSpacing { get; set; }

        /// <summary>
        /// Case folding applied at render time. V4 vector-text only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_transform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextItemV3TextTransformJsonConverter))]
        public global::Ideogram.TextItemV3TextTransform? TextTransform { get; set; }

        /// <summary>
        /// Vertical anchor (top|middle|bottom) for the rendered text within<br/>
        /// its bounding box. Maps to SVG `dominant-baseline`. V4 vector-text<br/>
        /// only. Distinct from horizontal `alignment` (left|center|right).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextItemV3VerticalAlignmentJsonConverter))]
        public global::Ideogram.TextItemV3VerticalAlignment? VerticalAlignment { get; set; }

        /// <summary>
        /// Stacked CSS text shadows, composed back-to-front. Phase-1 ships at<br/>
        /// most one entry; phase-2 unlocks multi-stack. V4 vector-text only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_shadows")]
        public global::System.Collections.Generic.IList<global::Ideogram.LayeredAssetTextShadow>? TextShadows { get; set; }

        /// <summary>
        /// Ordered list of text spans. Concatenating span text values produces the full item text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3> Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItemV3" /> class.
        /// </summary>
        /// <param name="x">
        /// The x coordinate of the item in pixels.
        /// </param>
        /// <param name="y">
        /// The y coordinate of the item in pixels.
        /// </param>
        /// <param name="width">
        /// The width of the item in pixels.
        /// </param>
        /// <param name="height">
        /// The height of the item in pixels.
        /// </param>
        /// <param name="alignment">
        /// The text alignment of the item.<br/>
        /// Example: center
        /// </param>
        /// <param name="styleClass">
        /// Typographic classification of the text.<br/>
        /// Example: body
        /// </param>
        /// <param name="spans">
        /// Ordered list of text spans. Concatenating span text values produces the full item text.
        /// </param>
        /// <param name="angle">
        /// The angle rotation of the text, measured clockwise in degrees.<br/>
        /// Example: 0
        /// </param>
        /// <param name="glyphType">
        /// The type of list marker glyph, if any. Null for non-list items.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fontFile">
        /// The matched font file for this item.
        /// </param>
        /// <param name="fontCandidates">
        /// A list of alternate matching font files for this item.
        /// </param>
        /// <param name="fontSize">
        /// The font size in points. Null for non-editable items.
        /// </param>
        /// <param name="lineHeight">
        /// The line height multiplier (e.g., 1.2). Null for non-editable items.
        /// </param>
        /// <param name="letterSpacing">
        /// Letter spacing in em units (e.g. 0.05 = 5% of em). V4 vector-text only.
        /// </param>
        /// <param name="textTransform">
        /// Case folding applied at render time. V4 vector-text only.
        /// </param>
        /// <param name="verticalAlignment">
        /// Vertical anchor (top|middle|bottom) for the rendered text within<br/>
        /// its bounding box. Maps to SVG `dominant-baseline`. V4 vector-text<br/>
        /// only. Distinct from horizontal `alignment` (left|center|right).
        /// </param>
        /// <param name="textShadows">
        /// Stacked CSS text shadows, composed back-to-front. Phase-1 ships at<br/>
        /// most one entry; phase-2 unlocks multi-stack. V4 vector-text only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextItemV3(
            int x,
            int y,
            int width,
            int height,
            global::Ideogram.TextItemV3Alignment alignment,
            global::Ideogram.TextItemV3StyleClass styleClass,
            global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3> spans,
            float? angle,
            global::Ideogram.TextItemV3GlyphType? glyphType,
            string? fontFile,
            global::System.Collections.Generic.IList<string>? fontCandidates,
            int? fontSize,
            float? lineHeight,
            float? letterSpacing,
            global::Ideogram.TextItemV3TextTransform? textTransform,
            global::Ideogram.TextItemV3VerticalAlignment? verticalAlignment,
            global::System.Collections.Generic.IList<global::Ideogram.LayeredAssetTextShadow>? textShadows)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Alignment = alignment;
            this.Angle = angle;
            this.StyleClass = styleClass;
            this.GlyphType = glyphType;
            this.FontFile = fontFile;
            this.FontCandidates = fontCandidates;
            this.FontSize = fontSize;
            this.LineHeight = lineHeight;
            this.LetterSpacing = letterSpacing;
            this.TextTransform = textTransform;
            this.VerticalAlignment = verticalAlignment;
            this.TextShadows = textShadows;
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItemV3" /> class.
        /// </summary>
        public TextItemV3()
        {
        }

    }
}