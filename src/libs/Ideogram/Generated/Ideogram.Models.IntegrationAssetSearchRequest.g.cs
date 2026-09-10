
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"query":"query","limit":1}
    /// </summary>
    public sealed partial class IntegrationAssetSearchRequest
    {
        /// <summary>
        /// Maximum number of assets to return, bounded by the configured runtime policy. The operation returns a single bounded result; pagination is a future extension that adds optional fields additively.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// Optional keyed lookup. For integrations whose upstream is a keyed catalog, this is the item key (for example a product style code); integrations without keyed lookup ignore it. Omitted means browse.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAssetSearchRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of assets to return, bounded by the configured runtime policy. The operation returns a single bounded result; pagination is a future extension that adds optional fields additively.
        /// </param>
        /// <param name="query">
        /// Optional keyed lookup. For integrations whose upstream is a keyed catalog, this is the item key (for example a product style code); integrations without keyed lookup ignore it. Omitted means browse.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationAssetSearchRequest(
            int limit,
            string? query)
        {
            this.Limit = limit;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAssetSearchRequest" /> class.
        /// </summary>
        public IntegrationAssetSearchRequest()
        {
        }

    }
}