
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiOrganizationUserSuggestionsResponse
    {
        /// <summary>
        /// List of user suggestions for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_suggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ApiOrganizationUserSuggestion> UserSuggestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiOrganizationUserSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="userSuggestions">
        /// List of user suggestions for the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiOrganizationUserSuggestionsResponse(
            global::System.Collections.Generic.IList<global::Ideogram.ApiOrganizationUserSuggestion> userSuggestions)
        {
            this.UserSuggestions = userSuggestions ?? throw new global::System.ArgumentNullException(nameof(userSuggestions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiOrganizationUserSuggestionsResponse" /> class.
        /// </summary>
        public GetApiOrganizationUserSuggestionsResponse()
        {
        }
    }
}