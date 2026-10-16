
#nullable enable

namespace Ideogram
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccountApiKey
    {
        /// <summary>
        /// Base64 encoded API key ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedApiKey { get; set; }

        /// <summary>
        /// The date at which the API key was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AccountApiKeyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AccountApiKeyStatus Status { get; set; }

        /// <summary>
        /// An optional user-supplied label for managing the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Name of the member who created the key, falling back to their display handle when no name is set. Null on keys created before creators were recorded, and on workspace types whose keys are shared rather than owned by one member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_display_label")]
        public string? CreatorDisplayLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApiKey" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// Base64 encoded API key ID
        /// </param>
        /// <param name="redactedApiKey">
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key
        /// </param>
        /// <param name="creationTime">
        /// The date at which the API key was created
        /// </param>
        /// <param name="status"></param>
        /// <param name="label">
        /// An optional user-supplied label for managing the API key
        /// </param>
        /// <param name="creatorDisplayLabel">
        /// Name of the member who created the key, falling back to their display handle when no name is set. Null on keys created before creators were recorded, and on workspace types whose keys are shared rather than owned by one member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountApiKey(
            string apiKeyId,
            string redactedApiKey,
            global::System.DateTime creationTime,
            global::Ideogram.AccountApiKeyStatus status,
            string? label,
            string? creatorDisplayLabel)
        {
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.RedactedApiKey = redactedApiKey ?? throw new global::System.ArgumentNullException(nameof(redactedApiKey));
            this.CreationTime = creationTime;
            this.Status = status;
            this.Label = label;
            this.CreatorDisplayLabel = creatorDisplayLabel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApiKey" /> class.
        /// </summary>
        public AccountApiKey()
        {
        }

    }
}