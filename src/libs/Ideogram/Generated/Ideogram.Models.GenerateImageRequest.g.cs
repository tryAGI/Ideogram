
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ImageRequest ImageRequest { get; set; }

        /// <summary>
        /// A list of base64 encoded binary embeddings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_ref_embeddings")]
        public global::System.Collections.Generic.IList<string>? StyleRefEmbeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        /// <param name="imageRequest"></param>
        /// <param name="styleRefEmbeddings">
        /// A list of base64 encoded binary embeddings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequest(
            global::Ideogram.ImageRequest imageRequest,
            global::System.Collections.Generic.IList<string>? styleRefEmbeddings)
        {
            this.ImageRequest = imageRequest ?? throw new global::System.ArgumentNullException(nameof(imageRequest));
            this.StyleRefEmbeddings = styleRefEmbeddings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequest" /> class.
        /// </summary>
        public GenerateImageRequest()
        {
        }
    }
}