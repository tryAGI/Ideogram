
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"api_keys":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","label":"Live production environment","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","creator_display_label":"John Doe","status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","label":"Live production environment","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","creator_display_label":"John Doe","status":null}]}
    /// </summary>
    public sealed partial class ListAccountApiKeysResponse
    {
        /// <summary>
        /// All API keys in the organization, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AccountApiKey> ApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccountApiKeysResponse" /> class.
        /// </summary>
        /// <param name="apiKeys">
        /// All API keys in the organization, newest first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccountApiKeysResponse(
            global::System.Collections.Generic.IList<global::Ideogram.AccountApiKey> apiKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccountApiKeysResponse" /> class.
        /// </summary>
        public ListAccountApiKeysResponse()
        {
        }

    }
}