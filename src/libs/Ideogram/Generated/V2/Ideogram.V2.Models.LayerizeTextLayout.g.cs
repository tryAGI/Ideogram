
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeTextLayout
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayoutAlignmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V2.LayerizeTextLayoutAlignment Alignment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayoutVerticalAlignmentJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayoutVerticalAlignment? VerticalAlignment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_height")]
        public double? LineHeight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("letter_spacing_em")]
        public double? LetterSpacingEm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_transform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayoutTextTransformJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayoutTextTransform? TextTransform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_indent_px")]
        public double? TextIndentPx { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resize_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.LayerizeTextLayoutResizeModeJsonConverter))]
        public global::Ideogram.V2.LayerizeTextLayoutResizeMode? ResizeMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayout" /> class.
        /// </summary>
        /// <param name="alignment"></param>
        /// <param name="verticalAlignment"></param>
        /// <param name="lineHeight"></param>
        /// <param name="letterSpacingEm"></param>
        /// <param name="textTransform"></param>
        /// <param name="textIndentPx"></param>
        /// <param name="resizeMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextLayout(
            global::Ideogram.V2.LayerizeTextLayoutAlignment alignment,
            global::Ideogram.V2.LayerizeTextLayoutVerticalAlignment? verticalAlignment,
            double? lineHeight,
            double? letterSpacingEm,
            global::Ideogram.V2.LayerizeTextLayoutTextTransform? textTransform,
            double? textIndentPx,
            global::Ideogram.V2.LayerizeTextLayoutResizeMode? resizeMode)
        {
            this.Alignment = alignment;
            this.VerticalAlignment = verticalAlignment;
            this.LineHeight = lineHeight;
            this.LetterSpacingEm = letterSpacingEm;
            this.TextTransform = textTransform;
            this.TextIndentPx = textIndentPx;
            this.ResizeMode = resizeMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextLayout" /> class.
        /// </summary>
        public LayerizeTextLayout()
        {
        }

    }
}