
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiOrganizationUserSuggestion
    {
        /// <summary>
        /// The display handle of the user<br/>
        /// Example: john_doe
        /// </summary>
        /// <example>john_doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayHandle { get; set; }

        /// <summary>
        /// Whether the user has already joined the organization<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Joined { get; set; }

        /// <summary>
        /// URL to the user's profile picture<br/>
        /// Example: https://example.com/avatars/user123.jpg
        /// </summary>
        /// <example>https://example.com/avatars/user123.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_pic")]
        public string? ProfilePic { get; set; }

        /// <summary>
        /// The full name of the user<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationUserSuggestion" /> class.
        /// </summary>
        /// <param name="displayHandle">
        /// The display handle of the user<br/>
        /// Example: john_doe
        /// </param>
        /// <param name="joined">
        /// Whether the user has already joined the organization<br/>
        /// Example: false
        /// </param>
        /// <param name="profilePic">
        /// URL to the user's profile picture<br/>
        /// Example: https://example.com/avatars/user123.jpg
        /// </param>
        /// <param name="name">
        /// The full name of the user<br/>
        /// Example: John Doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiOrganizationUserSuggestion(
            string displayHandle,
            bool joined,
            string? profilePic,
            string? name)
        {
            this.DisplayHandle = displayHandle ?? throw new global::System.ArgumentNullException(nameof(displayHandle));
            this.Joined = joined;
            this.ProfilePic = profilePic;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiOrganizationUserSuggestion" /> class.
        /// </summary>
        public ApiOrganizationUserSuggestion()
        {
        }
    }
}