
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","label":"Live production environment","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","creator_display_label":"John Doe","status":null}
    /// </summary>
    public sealed partial class ApiProfileApiKey
    {
        /// <summary>
        /// Base64 encoded API key ID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: ATG56•••••••••••••
        /// </summary>
        /// <example>ATG56•••••••••••••</example>
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
        /// Status of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ApiKeyStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ApiKeyStatus Status { get; set; }

        /// <summary>
        /// An optional user-supplied label for managing the API key<br/>
        /// Example: Live production environment
        /// </summary>
        /// <example>Live production environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Name of the member who created the key, falling back to their display handle when no name is set. Null on keys created before creators were recorded, and on workspace types whose keys are shared rather than owned by one member.<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_display_label")]
        public string? CreatorDisplayLabel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiProfileApiKey" /> class.
        /// </summary>
        /// <param name="apiKeyId">
        /// Base64 encoded API key ID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg
        /// </param>
        /// <param name="redactedApiKey">
        /// A redacted text snippet of the API key. Contains the first 4 characters of the API key<br/>
        /// Example: ATG56•••••••••••••
        /// </param>
        /// <param name="creationTime">
        /// The date at which the API key was created
        /// </param>
        /// <param name="status">
        /// Status of the API key
        /// </param>
        /// <param name="label">
        /// An optional user-supplied label for managing the API key<br/>
        /// Example: Live production environment
        /// </param>
        /// <param name="creatorDisplayLabel">
        /// Name of the member who created the key, falling back to their display handle when no name is set. Null on keys created before creators were recorded, and on workspace types whose keys are shared rather than owned by one member.<br/>
        /// Example: John Doe
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiProfileApiKey(
            string apiKeyId,
            string redactedApiKey,
            global::System.DateTime creationTime,
            global::Ideogram.ApiKeyStatus status,
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
        /// Initializes a new instance of the <see cref="ApiProfileApiKey" /> class.
        /// </summary>
        public ApiProfileApiKey()
        {
        }

    }
}