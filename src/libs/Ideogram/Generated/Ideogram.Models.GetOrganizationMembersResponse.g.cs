
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"members":[{"display_handle":"john_doe","email_address":"john.doe@example.com","role":"OWNER","full_name":"full_name","avatar_url":"https://example.com/avatars/user123.jpg","user_id":"dXNlcl8xMjM"},{"display_handle":"john_doe","email_address":"john.doe@example.com","role":"OWNER","full_name":"full_name","avatar_url":"https://example.com/avatars/user123.jpg","user_id":"dXNlcl8xMjM"}]}
    /// </summary>
    public sealed partial class GetOrganizationMembersResponse
    {
        /// <summary>
        /// List of organization members
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.OrganizationMember> Members { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationMembersResponse" /> class.
        /// </summary>
        /// <param name="members">
        /// List of organization members
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