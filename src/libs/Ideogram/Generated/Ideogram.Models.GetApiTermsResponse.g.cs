
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"api_terms":{"terms_url":"terms_url","terms_id":"terms_id"}}
    /// </summary>
    public sealed partial class GetApiTermsResponse
    {
        /// <summary>
        /// Example: {"terms_url":"terms_url","terms_id":"terms_id"}
        /// </summary>
        /// <example>{"terms_url":"terms_url","terms_id":"terms_id"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Ideogram.ApiTerms ApiTerms { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        /// <param name="apiTerms">
        /// Example: {"terms_url":"terms_url","terms_id":"terms_id"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiTermsResponse(
            global::Ideogram.ApiTerms apiTerms)
        {
            this.ApiTerms = apiTerms ?? throw new global::System.ArgumentNullException(nameof(apiTerms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        public GetApiTermsResponse()
        {
        }
    }
}