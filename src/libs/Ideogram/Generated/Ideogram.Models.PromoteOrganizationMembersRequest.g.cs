
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"members":[{"display_handle":"john_doe","email_address":"john.doe@example.com","user_id":"dXNlcl8xMjM"},{"display_handle":"john_doe","email_address":"john.doe@example.com","user_id":"dXNlcl8xMjM"}]}
    /// </summary>
    public sealed partial class PromoteOrganizationMembersRequest
    {
        /// <summary>
        /// List of organization members to promote to OWNER role<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember> Members { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteOrganizationMembersRequest" /> class.
        /// </summary>
        /// <param name="members">
        /// List of organization members to promote to OWNER role<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteOrganizationMembersRequest(
            global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember> members)
        {
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteOrganizationMembersRequest" /> class.
        /// </summary>
        public PromoteOrganizationMembersRequest()
        {
        }
    }
}