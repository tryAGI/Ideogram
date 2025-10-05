
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiKeysV2Response
    {
        /// <summary>
        /// List of API keys associated with the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.ApiProfileApiKey> ApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeysV2Response" /> class.
        /// </summary>
        /// <param name="apiKeys">
        /// List of API keys associated with the organization
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