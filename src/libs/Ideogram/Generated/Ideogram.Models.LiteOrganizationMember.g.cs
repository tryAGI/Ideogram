
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A lite representation of an organization member with optional fields for identification
    /// </summary>
    public sealed partial class LiteOrganizationMember
    {
        /// <summary>
        /// Base64 encoded user ID<br/>
        /// Example: dXNlcl8xMjM
        /// </summary>
        /// <example>dXNlcl8xMjM</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The display handle/username of the member<br/>
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
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteOrganizationMember" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteOrganizationMember(
            string? userId,
            string? displayHandle,
            string? emailAddress)
        {
            this.UserId = userId;
            this.DisplayHandle = displayHandle;
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteOrganizationMember" /> class.
        /// </summary>
        public LiteOrganizationMember()
        {
        }
    }
}