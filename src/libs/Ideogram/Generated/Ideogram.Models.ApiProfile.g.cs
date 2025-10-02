
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiProfile
    {
        /// <summary>
        /// Type of API profile<br/>
        /// Example: INDIVIDUAL
        /// </summary>
        /// <example>INDIVIDUAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ApiProfileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ApiProfileType Type { get; set; }

        /// <summary>
        /// The display name of the profile<br/>
        /// Example: Gamma
        /// </summary>
        /// <example>Gamma</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL to the profile avatar<br/>
        /// Example: https://example.com/avatar.jpg
        /// </summary>
        /// <example>https://example.com/avatar.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Base64 encoded organization ID (only for ENTERPRISE profiles)<br/>
        /// Example: b3JnYW5pemF0aW9uXzEyMw
        /// </summary>
        /// <example>b3JnYW5pemF0aW9uXzEyMw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

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
        /// List of API keys associated with this profile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey> ApiKeys { get; set; }

        /// <summary>
        /// Whether the user is on Metronome 2.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_metronome_2_user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsMetronome2User { get; set; }

        /// <summary>
        /// The maximum number of inflight requests permitted for the profile<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_num_inflight_requests_permitted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxNumInflightRequestsPermitted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfile" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of API profile<br/>
        /// Example: INDIVIDUAL
        /// </param>
        /// <param name="name">
        /// The display name of the profile<br/>
        /// Example: Gamma
        /// </param>
        /// <param name="avatarUrl">
        /// URL to the profile avatar<br/>
        /// Example: https://example.com/avatar.jpg
        /// </param>
        /// <param name="organizationId">
        /// Base64 encoded organization ID (only for ENTERPRISE profiles)<br/>
        /// Example: b3JnYW5pemF0aW9uXzEyMw
        /// </param>
        /// <param name="role">
        /// Role within an enterprise organization profile<br/>
        /// Example: OWNER
        /// </param>
        /// <param name="apiKeys">
        /// List of API keys associated with this profile
        /// </param>
        /// <param name="isMetronome2User">
        /// Whether the user is on Metronome 2.0
        /// </param>
        /// <param name="maxNumInflightRequestsPermitted">
        /// The maximum number of inflight requests permitted for the profile<br/>
        /// Example: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProfile(
            global::Ideogram.ApiProfileType type,
            string name,
            string avatarUrl,
            string organizationId,
            global::Ideogram.ApiProfileRole role,
            global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey> apiKeys,
            bool isMetronome2User,
            int maxNumInflightRequestsPermitted)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.Role = role;
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
            this.IsMetronome2User = isMetronome2User;
            this.MaxNumInflightRequestsPermitted = maxNumInflightRequestsPermitted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfile" /> class.
        /// </summary>
        public ApiProfile()
        {
        }
    }
}