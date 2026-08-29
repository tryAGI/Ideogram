
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProvenanceVerifyRequest
    {
        /// <summary>
        /// The image file to verify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Content { get; set; }

        /// <summary>
        /// The image file to verify.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Contentname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceVerifyRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The image file to verify.
        /// </param>
        /// <param name="contentname">
        /// The image file to verify.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProvenanceVerifyRequest(
            byte[] content,
            string contentname)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Contentname = contentname ?? throw new global::System.ArgumentNullException(nameof(contentname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvenanceVerifyRequest" /> class.
        /// </summary>
        public ProvenanceVerifyRequest()
        {
        }

    }
}