
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A text layer for a layered image generation.<br/>
    /// Example: {"font_candidates":["font_candidates","font_candidates"],"line_height":2.302136,"color":"#FF0000","font_size":5,"x":0,"width":1,"y":6,"angle":0,"text":"text","font_file":"font_file","alignment":"center","height":5}
    /// </summary>
    public sealed partial class TextLayerV3
    {
        /// <summary>
        /// The text of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The x coordinate of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int X { get; set; } = default!;

        /// <summary>
        /// The y coordinate of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Y { get; set; } = default!;

        /// <summary>
        /// The width of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Width { get; set; } = default!;

        /// <summary>
        /// The height of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Height { get; set; } = default!;

        /// <summary>
        /// The font file of the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string FontFile { get; set; } = default!;

        /// <summary>
        /// A list of alternate matching font files for the layer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_candidates")]
        public global::System.Collections.Generic.IList<string>? FontCandidates { get; set; }

        /// <summary>
        /// The font size in points.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_size")]
        public int? FontSize { get; set; }

        /// <summary>
        /// The line height multiplier (e.g., 1.2).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_height")]
        public float? LineHeight { get; set; }

        /// <summary>
        /// The hex color of the text in the layer (e.g. "#FF0000" for red).<br/>
        /// Example: #FF0000
        /// </summary>
        /// <example>#FF0000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The text alignment of the layer.<br/>
        /// Example: center
        /// </summary>
        /// <example>center</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TextLayerV3AlignmentJsonConverter))]
        public global::Ideogram.TextLayerV3Alignment? Alignment { get; set; }

        /// <summary>
        /// The angle rotation of the text in the layer, measured clockwise.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("angle")]
        public float? Angle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayerV3" /> class.
        /// </summary>
        /// <param name="text">
        /// The text of the layer.
        /// </param>
        /// <param name="x">
        /// The x coordinate of the layer.
        /// </param>
        /// <param name="y">
        /// The y coordinate of the layer.
        /// </param>
        /// <param name="width">
        /// The width of the layer.
        /// </param>
        /// <param name="height">
        /// The height of the layer.
        /// </param>
        /// <param name="fontFile">
        /// The font file of the layer.
        /// </param>
        /// <param name="fontCandidates">
        /// A list of alternate matching font files for the layer.
        /// </param>
        /// <param name="fontSize">
        /// The font size in points.
        /// </param>
        /// <param name="lineHeight">
        /// The line height multiplier (e.g., 1.2).
        /// </param>
        /// <param name="color">
        /// The hex color of the text in the layer (e.g. "#FF0000" for red).<br/>
        /// Example: #FF0000
        /// </param>
        /// <param name="alignment">
        /// The text alignment of the layer.<br/>
        /// Example: center
        /// </param>
        /// <param name="angle">
        /// The angle rotation of the text in the layer, measured clockwise.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextLayerV3(
            string text,
            int x,
            int y,
            int width,
            int height,
            string fontFile,
            global::System.Collections.Generic.IList<string>? fontCandidates,
            int? fontSize,
            float? lineHeight,
            string? color,
            global::Ideogram.TextLayerV3Alignment? alignment,
            float? angle)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.FontFile = fontFile ?? throw new global::System.ArgumentNullException(nameof(fontFile));
            this.FontCandidates = fontCandidates;
            this.FontSize = fontSize;
            this.LineHeight = lineHeight;
            this.Color = color;
            this.Alignment = alignment;
            this.Angle = angle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayerV3" /> class.
        /// </summary>
        public TextLayerV3()
        {
        }
    }
}