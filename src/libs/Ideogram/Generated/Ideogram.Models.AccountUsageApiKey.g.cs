
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The API key the usage was billed to, in redacted form.
    /// </summary>
    public sealed partial class AccountUsageApiKey
    {
        /// <summary>
        /// The API key's id, as listed by `GET /v2/account/api-keys`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The first characters of the key followed by bullets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_key")]
        public string? RedactedKey { get; set; }

        /// <summary>
        /// The key's user-supplied label, when one is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The API key's id, as listed by `GET /v2/account/api-keys`.
        /// </param>
        /// <param name="redactedKey">
        /// The first characters of the key followed by bullets.
        /// </param>
        /// <param name="label">
        /// The key's user-supplied label, when one is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountUsageApiKey(
            string id,
            string? redactedKey,
            string? label)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RedactedKey = redactedKey;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountUsageApiKey" /> class.
        /// </summary>
        public AccountUsageApiKey()
        {
        }

    }
}