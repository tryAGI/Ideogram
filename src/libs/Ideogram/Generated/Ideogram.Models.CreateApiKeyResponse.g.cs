
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateApiKeyResponse
    {
        /// <summary>
        /// The API key to use when making authenticated requests with the API. This key will only be shown once.<br/>
        /// Example: vkpDjaKdMNR8QJ83GjfNvFZJbnoi65XUp70MgZNtA2H9XE8yfDnmr_6BaRyQkF9hnJzu6mUPRLBmqlnZMwetJA
        /// </summary>
        /// <example>vkpDjaKdMNR8QJ83GjfNvFZJbnoi65XUp70MgZNtA2H9XE8yfDnmr_6BaRyQkF9hnJzu6mUPRLBmqlnZMwetJA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// The ID of the API key. A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// The time at which the API key was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key to use when making authenticated requests with the API. This key will only be shown once.<br/>
        /// Example: vkpDjaKdMNR8QJ83GjfNvFZJbnoi65XUp70MgZNtA2H9XE8yfDnmr_6BaRyQkF9hnJzu6mUPRLBmqlnZMwetJA
        /// </param>
        /// <param name="apiKeyId">
        /// The ID of the API key. A URL safe base64 encoded UUID<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg==
        /// </param>
        /// <param name="creationTime">
        /// The time at which the API key was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyResponse(
            string apiKey,
            string apiKeyId,
            global::System.DateTime creationTime)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.CreationTime = creationTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyResponse" /> class.
        /// </summary>
        public CreateApiKeyResponse()
        {
        }
    }
}