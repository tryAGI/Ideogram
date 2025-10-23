
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMember
    {
        /// <summary>
        /// Base64 encoded user ID<br/>
        /// Example: dXNlcl8xMjM
        /// </summary>
        /// <example>dXNlcl8xMjM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The display handle/username of the member<br/>
        /// Example: john_doe
        /// </summary>
        /// <example>john_doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayHandle { get; set; }

        /// <summary>
        /// The email address of the member<br/>
        /// Example: john.doe@example.com
        /// </summary>
        /// <example>john.doe@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmailAddress { get; set; }

        /// <summary>
        /// URL to the member's avatar image<br/>
        /// Example: https://example.com/avatars/user123.jpg
        /// </summary>
        /// <example>https://example.com/avatars/user123.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Role within an enterprise organization profile<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        /// <param name="userId">
        /// Base64 encoded user ID<br/>
        /// Example: dXNlcl8xMjM
        /// </param>
        /// <param name="displayHandle">
        /// The display handle/username of the member<br/>
        /// Example: john_doe
        /// </param>
        /// <param name="emailAddress">
        /// The email address of the member<br/>
        /// Example: john.doe@example.com
        /// </param>
        /// <param name="avatarUrl">
        /// URL to the member's avatar image<br/>
        /// Example: https://example.com/avatars/user123.jpg
        /// </param>
        /// <param name="role">
        /// Role within an enterprise organization profile<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="fullName">
        /// User's full name if entered through user profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMember(
            string userId,
            string displayHandle,
            string emailAddress,
            string avatarUrl,
            global::Ideogram.ApiProfileRole role,
            string? fullName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.DisplayHandle = displayHandle ?? throw new global::System.ArgumentNullException(nameof(displayHandle));
            this.EmailAddress = emailAddress ?? throw new global::System.ArgumentNullException(nameof(emailAddress));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Role = role;
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMember" /> class.
        /// </summary>
        public OrganizationMember()
        {
        }
    }
}