
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LayerizeTextRequest
    {
        /// <summary>
        /// The image to analyze for text detection. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The image to analyze for text detection. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// An optional text description of the image. If not provided, a description will be auto-generated from the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// The image to analyze for text detection. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </param>
        /// <param name="imagename">
        /// The image to analyze for text detection. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </param>
        /// <param name="prompt">
        /// An optional text description of the image. If not provided, a description will be auto-generated from the image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LayerizeTextRequest(
            byte[] image,
            string imagename,
            string? prompt,
            int? seed)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LayerizeTextRequest" /> class.
        /// </summary>
        public LayerizeTextRequest()
        {
        }
    }
}