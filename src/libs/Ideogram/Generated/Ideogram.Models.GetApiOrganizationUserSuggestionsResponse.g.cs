
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"user_suggestions":[{"display_handle":"john_doe","joined":false,"profile_pic":"https://example.com/avatars/user123.jpg","name":"John Doe"},{"display_handle":"john_doe","joined":false,"profile_pic":"https://example.com/avatars/user123.jpg","name":"John Doe"}]}
    /// </summary>
    public sealed partial class GetApiOrganizationUserSuggestionsResponse
    {
        /// <summary>
        /// List of user suggestions for the organization<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_suggestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.ApiOrganizationUserSuggestion> UserSuggestions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiOrganizationUserSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="userSuggestions">
        /// List of user suggestions for the organization<br/>
        /// Default Value: []
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