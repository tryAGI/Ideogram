
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"has_accepted_terms":true,"api_terms":{"terms_url":"terms_url","terms_id":"terms_id"}}
    /// </summary>
    public sealed partial class GetApiTermsResponse
    {
        /// <summary>
        /// Example: {"terms_url":"terms_url","terms_id":"terms_id"}
        /// </summary>
        /// <example>{"terms_url":"terms_url","terms_id":"terms_id"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ApiTerms ApiTerms { get; set; }

        /// <summary>
        /// Whether the requesting user has accepted the latest API terms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_accepted_terms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAcceptedTerms { get; set; }

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
        /// <param name="hasAcceptedTerms">
        /// Whether the requesting user has accepted the latest API terms.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiTermsResponse(
            global::Ideogram.ApiTerms apiTerms,
            bool hasAcceptedTerms)
        {
            this.ApiTerms = apiTerms ?? throw new global::System.ArgumentNullException(nameof(apiTerms));
            this.HasAcceptedTerms = hasAcceptedTerms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        public GetApiTermsResponse()
        {
        }

    }
}