
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// One run of characters within a text block that shares a single colour. A block<br/>
    /// whose letters are individually coloured returns one span per letter; a block in a<br/>
    /// single colour returns one span covering all of it. Concatenating `text` across a<br/>
    /// block's spans in order reproduces the block's full text.
    /// </summary>
    public sealed partial class TextColorSpan
    {
        /// <summary>
        /// The characters in this run.<br/>
        /// Example: T
        /// </summary>
        /// <example>T</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Hex colour for this run.<br/>
        /// Example: #F4ACC4
        /// </summary>
        /// <example>#F4ACC4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextColorSpan" /> class.
        /// </summary>
        /// <param name="text">
        /// The characters in this run.<br/>
        /// Example: T
        /// </param>
        /// <param name="color">
        /// Hex colour for this run.<br/>
        /// Example: #F4ACC4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextColorSpan(
            string text,
            string color)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextColorSpan" /> class.
        /// </summary>
        public TextColorSpan()
        {
        }

    }
}