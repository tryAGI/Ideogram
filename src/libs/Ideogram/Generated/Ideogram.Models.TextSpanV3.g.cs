
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// An atomic text segment within a text item, carrying text content and visual styling.<br/>
    /// Example: {"color":"#212121","text":"text","font_fx":["bold","italic"]}
    /// </summary>
    public sealed partial class TextSpanV3
    {
        /// <summary>
        /// The text content for this segment. Line breaks within the span are represented as \n.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Ordered list of style effects applied to this text span.<br/>
        /// This is the primary style field for layered text.<br/>
        /// Example: [bold, italic]
        /// </summary>
        /// <example>[bold, italic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_fx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3FontFxItem> FontFx { get; set; }

        /// <summary>
        /// The hex color of the text (e.g. "#FF0000" for red).<br/>
        /// Example: #212121
        /// </summary>
        /// <example>#212121</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextSpanV3" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content for this segment. Line breaks within the span are represented as \n.
        /// </param>
        /// <param name="fontFx">
        /// Ordered list of style effects applied to this text span.<br/>
        /// This is the primary style field for layered text.<br/>
        /// Example: [bold, italic]
        /// </param>
        /// <param name="color">
        /// The hex color of the text (e.g. "#FF0000" for red).<br/>
        /// Example: #212121
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextSpanV3(
            string text,
            global::System.Collections.Generic.IList<global::Ideogram.TextSpanV3FontFxItem> fontFx,
            string color)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.FontFx = fontFx ?? throw new global::System.ArgumentNullException(nameof(fontFx));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextSpanV3" /> class.
        /// </summary>
        public TextSpanV3()
        {
        }
    }
}