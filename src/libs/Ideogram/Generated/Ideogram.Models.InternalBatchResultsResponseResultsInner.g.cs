
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalBatchResultsResponseResultsInner
    {
        /// <summary>
        /// The prompt used for generation.<br/>
        /// Example: a cat
        /// </summary>
        /// <example>a cat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The URL of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchResultsResponseResultsInner" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used for generation.<br/>
        /// Example: a cat
        /// </param>
        /// <param name="imageUrl">
        /// The URL of the generated image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalBatchResultsResponseResultsInner(
            string prompt,
            string imageUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchResultsResponseResultsInner" /> class.
        /// </summary>
        public InternalBatchResultsResponseResultsInner()
        {
        }
    }
}