
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"invite_id":"invite_id"}
    /// </summary>
    public sealed partial class ResendOrganizationInviteRequest
    {
        /// <summary>
        /// Base64 URL-safe encoded ID of the invite to resend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InviteId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResendOrganizationInviteRequest" /> class.
        /// </summary>
        /// <param name="inviteId">
        /// Base64 URL-safe encoded ID of the invite to resend
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResendOrganizationInviteRequest(
            string inviteId)
        {
            this.InviteId = inviteId ?? throw new global::System.ArgumentNullException(nameof(inviteId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResendOrganizationInviteRequest" /> class.
        /// </summary>
        public ResendOrganizationInviteRequest()
        {
        }

    }
}