
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"limit":1}
    /// </summary>
    public sealed partial class IntegrationAssetSearchRequest
    {
        /// <summary>
        /// Maximum number of assets to return, bounded by the configured runtime policy. The operation returns a single bounded browse result; text search and pagination are future extensions that add optional fields additively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAssetSearchRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of assets to return, bounded by the configured runtime policy. The operation returns a single bounded browse result; text search and pagination are future extensions that add optional fields additively.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationAssetSearchRequest(
            int limit)
        {
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAssetSearchRequest" /> class.
        /// </summary>
        public IntegrationAssetSearchRequest()
        {
        }

    }
}