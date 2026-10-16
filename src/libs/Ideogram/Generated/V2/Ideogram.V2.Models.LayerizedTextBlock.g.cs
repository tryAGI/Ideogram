
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    /// A single detected text region with its position, content, font information, and styling.
    /// </summary>
    public sealed partial class LayerizedTextBlock
    {
        /// <summary>
        /// X coordinate in pixels from the top-left corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// Y coordinate in pixels from the top-left corner.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Width of the text region in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Height of the text region in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// The detected text content. Line breaks are represented as \n.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Detected text alignment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizedTextBlockAlignmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizedTextBlockAlignment Alignment { get; set; }

        /// <summary>
        /// Rotation angle in degrees (clockwise). Defaults to 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("angle")]
        public string? Angle { get; set; }

        /// <summary>
        /// Best-matching font name from the font library.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name")]
        public string? FontName { get; set; }

        /// <summary>
        /// Alternative font matches, ranked by similarity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_alternatives")]
        public global::System.Collections.Generic.IList<string>? FontAlternatives { get; set; }

        /// <summary>
        /// Detected font size in points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public int? FontSize { get; set; }

        /// <summary>
        /// Line height multiplier (e.g., 1.2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_height")]
        public string? LineHeight { get; set; }

        /// <summary>
        /// Detected text color in hex format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Detected text formatting effects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedTextBlockFormattingItems> Formatting { get; set; }

        /// <summary>
        /// Inferred typographic role of this text block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Ideogram.V2.LayerizedTextBlockRole? Role { get; set; }

        /// <summary>
        /// Identifier of this block's layer in the page at `html_url`; pass it to the page's editing API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LayerId { get; set; }

        /// <summary>
        /// The block's colour runs in reading order. Present, with at least one<br/>
        /// run, whenever `color` is set; concatenating the runs' `text` reproduces<br/>
        /// the block's `text`. `color` reports the dominant colour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.TextColorSpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedTextBlock" /> class.
        /// </summary>
        /// <param name="x">
        /// X coordinate in pixels from the top-left corner.
        /// </param>
        /// <param name="y">
        /// Y coordinate in pixels from the top-left corner.
        /// </param>
        /// <param name="width">
        /// Width of the text region in pixels.
        /// </param>
        /// <param name="height">
        /// Height of the text region in pixels.
        /// </param>
        /// <param name="text">
        /// The detected text content. Line breaks are represented as \n.
        /// </param>
        /// <param name="alignment">
        /// Detected text alignment.
        /// </param>
        /// <param name="formatting">
        /// Detected text formatting effects.
        /// </param>
        /// <param name="layerId">
        /// Identifier of this block's layer in the page at `html_url`; pass it to the page's editing API.
        /// </param>
        /// <param name="angle">
        /// Rotation angle in degrees (clockwise). Defaults to 0.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="fontName">
        /// Best-matching font name from the font library.
        /// </param>
        /// <param name="fontAlternatives">
        /// Alternative font matches, ranked by similarity.
        /// </param>
        /// <param name="fontSize">
        /// Detected font size in points.
        /// </param>
        /// <param name="lineHeight">
        /// Line height multiplier (e.g., 1.2).
        /// </param>
        /// <param name="color">
        /// Detected text color in hex format.
        /// </param>
        /// <param name="role">
        /// Inferred typographic role of this text block.
        /// </param>
        /// <param name="spans">
        /// The block's colour runs in reading order. Present, with at least one<br/>
        /// run, whenever `color` is set; concatenating the runs' `text` reproduces<br/>
        /// the block's `text`. `color` reports the dominant colour.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizedTextBlock(
            int x,
            int y,
            int width,
            int height,
            string text,
            global::Ideogram.V2.LayerizedTextBlockAlignment alignment,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizedTextBlockFormattingItems> formatting,
            string layerId,
            string? angle,
            string? fontName,
            global::System.Collections.Generic.IList<string>? fontAlternatives,
            int? fontSize,
            string? lineHeight,
            string? color,
            global::Ideogram.V2.LayerizedTextBlockRole? role,
            global::System.Collections.Generic.IList<global::Ideogram.V2.TextColorSpan>? spans)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Alignment = alignment;
            this.Angle = angle;
            this.FontName = fontName;
            this.FontAlternatives = fontAlternatives;
            this.FontSize = fontSize;
            this.LineHeight = lineHeight;
            this.Color = color;
            this.Formatting = formatting ?? throw new global::System.ArgumentNullException(nameof(formatting));
            this.Role = role;
            this.LayerId = layerId ?? throw new global::System.ArgumentNullException(nameof(layerId));
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizedTextBlock" /> class.
        /// </summary>
        public LayerizedTextBlock()
        {
        }

    }
}