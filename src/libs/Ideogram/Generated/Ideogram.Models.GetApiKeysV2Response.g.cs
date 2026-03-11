
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"api_keys":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","status":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},{"creation_time":"2000-01-23T04:56:07\u002B00:00","redacted_api_key":"ATG56\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022\u2022","api_key_id":"JRPVD7jWR1aTBYiJ0UFVOg","status":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}]}
    /// </summary>
    public sealed partial class GetApiKeysV2Response
    {
        /// <summary>
        /// List of API keys associated with the organization<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey> ApiKeys { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeysV2Response" /> class.
        /// </summary>
        /// <param name="apiKeys">
        /// List of API keys associated with the organization<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeysV2Response(
            global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey> apiKeys)
        {
            this.ApiKeys = apiKeys ?? throw new global::System.ArgumentNullException(nameof(apiKeys));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeysV2Response" /> class.
        /// </summary>
        public GetApiKeysV2Response()
        {
        }
    }
}