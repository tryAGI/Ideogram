
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"members":[{"invite_id":"invite_id","display_handle":"john_doe","email_address":"john.doe@example.com","role":"OWNER","full_name":"full_name","invite_expiry_time":"2000-01-23T04:56:07\u002B00:00","avatar_url":"https://example.com/avatars/user123.jpg","user_id":"dXNlcl8xMjM","invite_status":"PENDING"},{"invite_id":"invite_id","display_handle":"john_doe","email_address":"john.doe@example.com","role":"OWNER","full_name":"full_name","invite_expiry_time":"2000-01-23T04:56:07\u002B00:00","avatar_url":"https://example.com/avatars/user123.jpg","user_id":"dXNlcl8xMjM","invite_status":"PENDING"}]}
    /// </summary>
    public sealed partial class GetOrganizationMembersResponse
    {
        /// <summary>
        /// List of organization members<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.OrganizationMember> Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponse" /> class.
        /// </summary>
        /// <param name="members">
        /// List of organization members<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationMembersResponse(
            global::System.Collections.Generic.IList<global::Ideogram.OrganizationMember> members)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponse" /> class.
        /// </summary>
        public GetOrganizationMembersResponse()
        {
        }

    }
}