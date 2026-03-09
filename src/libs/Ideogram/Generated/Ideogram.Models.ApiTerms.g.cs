
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"terms_url":"terms_url","terms_id":"terms_id"}
    /// </summary>
    public sealed partial class ApiTerms
    {
        /// <summary>
        /// The ID of the terms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string TermsId { get; set; } = default!;

        /// <summary>
        /// The URL where the terms are hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string TermsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTerms" /> class.
        /// </summary>
        /// <param name="termsId">
        /// The ID of the terms.
        /// </param>
        /// <param name="termsUrl">
        /// The URL where the terms are hosted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiTerms(
            string termsId,
            string termsUrl)
        {
            this.TermsId = termsId ?? throw new global::System.ArgumentNullException(nameof(termsId));
            this.TermsUrl = termsUrl ?? throw new global::System.ArgumentNullException(nameof(termsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiTerms" /> class.
        /// </summary>
        public ApiTerms()
        {
        }
    }
}