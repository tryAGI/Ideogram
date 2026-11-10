
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LayerizeTextSpan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeTextSpanFormattingItems>? Formatting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextSpan" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="color"></param>
        /// <param name="formatting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextSpan(
            string text,
            string? color,
            global::System.Collections.Generic.IList<global::Ideogram.V2.LayerizeTextSpanFormattingItems>? formatting)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Color = color;
            this.Formatting = formatting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextSpan" /> class.
        /// </summary>
        public LayerizeTextSpan()
        {
        }

    }
}