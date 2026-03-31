
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequestV4
    {
        /// <summary>
        /// The text prompt for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt for image generation.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestV4(
            string prompt,
            int? seed)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4" /> class.
        /// </summary>
        public GenerateImageRequestV4()
        {
        }
    }
}