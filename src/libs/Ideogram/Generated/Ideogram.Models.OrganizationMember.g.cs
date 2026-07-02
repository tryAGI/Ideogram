
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"invite_id":"invite_id","display_handle":"john_doe","email_address":"john.doe@example.com","role":"OWNER","full_name":"full_name","invite_expiry_time":"2000-01-23T04:56:07\u002B00:00","avatar_url":"https://example.com/avatars/user123.jpg","user_id":"dXNlcl8xMjM","invite_status":"PENDING"}
    /// </summary>
    public sealed partial class OrganizationMember
    {
        /// <summary>
        /// Base64 encoded user ID. Null for a pending invite to an email that has no account yet.<br/>
        /// Example: dXNlcl8xMjM
        /// </summary>
        /// <example>dXNlcl8xMjM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The display handle/username of the member. Null for a pending invite to an email that has no account yet.<br/>
        /// Example: john_doe
        /// </summary>
        /// <example>john_doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_handle")]
        public string? DisplayHandle { get; set; }

        /// <summary>
        /// The email address of the member<br/>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// URL to the member's avatar image. Null for a pending invite to an email that has no account yet.<br/>
        /// Example: https://example.com/avatars/user123.jpg
        /// </summary>
        /// <example>https://example.com/avatars/user123.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// Role within an organization profile. ADMIN only exists for TEAM_API organizations.<br/>
        /// Example: OWNER
        /// </summary>
        /// <example>OWNER</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ApiProfileRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ApiProfileRole Role { get; set; }

        /// <summary>
        /// User's full name if entered through user profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// Invite status, e.g. PENDING. Only populated while the member is still a pending invite; null for active members.<br/>
        /// Example: PENDING
        /// </summary>
        /// <example>PENDING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_status")]
        public string? InviteStatus { get; set; }

        /// <summary>
        /// Base64 encoded invite ID. Only populated while the member is still a pending invite; null for active members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_id")]
        public string? InviteId { get; set; }

        /// <summary>
        /// When the pending invite expires. Only populated while the member is still a pending invite; null for active members.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invite_expiry_time")]
        public global::System.DateTime? InviteExpiryTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        /// <param name="emailAddress">
        /// The email address of the member<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="role">
        /// Role within an organization profile. ADMIN only exists for TEAM_API organizations.<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="userId">
        /// Base64 encoded user ID. Null for a pending invite to an email that has no account yet.<br/>
        /// Example: dXNlcl8xMjM
        /// </param>
        /// <param name="displayHandle">
        /// The display handle/username of the member. Null for a pending invite to an email that has no account yet.<br/>
        /// Example: john_doe
        /// </param>
        /// <param name="avatarUrl">
        /// URL to the member's avatar image. Null for a pending invite to an email that has no account yet.<br/>
        /// Example: https://example.com/avatars/user123.jpg
        /// </param>
        /// <param name="fullName">
        /// User's full name if entered through user profile.
        /// </param>
        /// <param name="inviteStatus">
        /// Invite status, e.g. PENDING. Only populated while the member is still a pending invite; null for active members.<br/>
        /// Example: PENDING
        /// </param>
        /// <param name="inviteId">
        /// Base64 encoded invite ID. Only populated while the member is still a pending invite; null for active members.
        /// </param>
        /// <param name="inviteExpiryTime">
        /// When the pending invite expires. Only populated while the member is still a pending invite; null for active members.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMember(
            string emailAddress,
            global::Ideogram.ApiProfileRole role,
            string? userId,
            string? displayHandle,
            string? avatarUrl,
            string? fullName,
            string? inviteStatus,
            string? inviteId,
            global::System.DateTime? inviteExpiryTime)
        {
            this.UserId = userId;
            this.DisplayHandle = displayHandle;
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.AvatarUrl = avatarUrl;
            this.Role = role;
            this.FullName = fullName;
            this.InviteStatus = inviteStatus;
            this.InviteId = inviteId;
            this.InviteExpiryTime = inviteExpiryTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        public OrganizationMember()
        {
        }

    }
}