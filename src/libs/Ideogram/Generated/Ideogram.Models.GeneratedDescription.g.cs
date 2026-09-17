
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"text":"text"}
    /// </summary>
    public sealed partial class GeneratedDescription
    {
        /// <summary>
        /// The generated description for the provided image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedDescription" /> class.
        /// </summary>
        /// <param name="text">
        /// The generated description for the provided image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedDescription(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedDescription" /> class.
        /// </summary>
        public GeneratedDescription()
        {
        }

    }
}