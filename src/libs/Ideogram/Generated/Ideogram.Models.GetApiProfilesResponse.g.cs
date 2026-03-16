
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"profiles":[{"is_metronome_2_user":true,"role":"OWNER","avatar_url":"https://example.com/avatar.jpg","organization_id":"b3JnYW5pemF0aW9uXzEyMw","name":"Gamma","type":"INDIVIDUAL","api_keys":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","status":null}],"max_num_inflight_requests_permitted":10},{"is_metronome_2_user":true,"role":"OWNER","avatar_url":"https://example.com/avatar.jpg","organization_id":"b3JnYW5pemF0aW9uXzEyMw","name":"Gamma","type":"INDIVIDUAL","api_keys":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","status":null}],"max_num_inflight_requests_permitted":10}]}
    /// </summary>
    public sealed partial class GetApiProfilesResponse
    {
        /// <summary>
        /// List of user's API profiles<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ApiProfile> Profiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiProfilesResponse" /> class.
        /// </summary>
        /// <param name="profiles">
        /// List of user's API profiles<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiProfilesResponse(
            global::System.Collections.Generic.IList<global::Ideogram.ApiProfile> profiles)
        {
            this.Profiles = profiles ?? throw new global::System.ArgumentNullException(nameof(profiles));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiProfilesResponse" /> class.
        /// </summary>
        public GetApiProfilesResponse()
        {
        }
    }
}