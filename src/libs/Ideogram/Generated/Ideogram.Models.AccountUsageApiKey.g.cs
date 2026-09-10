
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The API key the usage was billed to, in redacted form.<br/>
    /// Example: {"redacted_key":"ATG5\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","id":"JRPVD7jWR1aTBYiJ0UFVOg","label":"Live production environment"}
    /// </summary>
    public sealed partial class AccountUsageApiKey
    {
        /// <summary>
        /// The API key's id, as listed by `GET /v2/account/api-keys`.<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg
        /// </summary>
        /// <example>JRPVD7jWR1aTBYiJ0UFVOg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The first characters of the key followed by bullets.<br/>
        /// Example: ATG5•••••••••••••
        /// </summary>
        /// <example>ATG5•••••••••••••</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_key")]
        public string? RedactedKey { get; set; }

        /// <summary>
        /// The key's user-supplied label, when one is set.<br/>
        /// Example: Live production environment
        /// </summary>
        /// <example>Live production environment</example>
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
        /// The API key's id, as listed by `GET /v2/account/api-keys`.<br/>
        /// Example: JRPVD7jWR1aTBYiJ0UFVOg
        /// </param>
        /// <param name="redactedKey">
        /// The first characters of the key followed by bullets.<br/>
        /// Example: ATG5•••••••••••••
        /// </param>
        /// <param name="label">
        /// The key's user-supplied label, when one is set.<br/>
        /// Example: Live production environment
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