
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// An organization object<br/>
    /// Example: {"role":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","publishing_disabled":true,"organization_id":"organization_id","name":"name","avatar":{"avatar_url":"avatar_url"},"type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}
    /// </summary>
    public sealed partial class OrganizationObject
    {
        /// <summary>
        /// ID of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Name of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.OrganizationTypeJsonConverter))]
        public global::Ideogram.OrganizationType? Type { get; set; }

        /// <summary>
        /// Role of a user in an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.OrganizationRoleEnumJsonConverter))]
        public global::Ideogram.OrganizationRoleEnum? Role { get; set; }

        /// <summary>
        /// Example: {"avatar_url":"avatar_url"}
        /// </summary>
        /// <example>{"avatar_url":"avatar_url"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        public global::Ideogram.OrganizationAvatarObject? Avatar { get; set; }

        /// <summary>
        /// Whether publishing is disabled for this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishing_disabled")]
        public bool? PublishingDisabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationObject" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// ID of the organization
        /// </param>
        /// <param name="name">
        /// Name of the organization
        /// </param>
        /// <param name="type">
        /// The type of organization
        /// </param>
        /// <param name="role">
        /// Role of a user in an organization.
        /// </param>
        /// <param name="avatar">
        /// Example: {"avatar_url":"avatar_url"}
        /// </param>
        /// <param name="publishingDisabled">
        /// Whether publishing is disabled for this organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationObject(
            string organizationId,
            string name,
            global::Ideogram.OrganizationType? type,
            global::Ideogram.OrganizationRoleEnum? role,
            global::Ideogram.OrganizationAvatarObject? avatar,
            bool? publishingDisabled)
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Role = role;
            this.Avatar = avatar;
            this.PublishingDisabled = publishingDisabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationObject" /> class.
        /// </summary>
        public OrganizationObject()
        {
        }
    }
}