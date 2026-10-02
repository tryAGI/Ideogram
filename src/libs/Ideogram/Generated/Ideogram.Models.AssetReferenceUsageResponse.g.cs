
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"next_cursor":"next_cursor","assets":[{"collection_id":"collection_id","collection_path":"collection_path","asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"file_name":"file_name","download_url":"download_url","collection_name":"collection_name","request_count":1},{"collection_id":"collection_id","collection_path":"collection_path","asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"file_name":"file_name","download_url":"download_url","collection_name":"collection_name","request_count":1}]}
    /// </summary>
    public sealed partial class AssetReferenceUsageResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.AssetReferenceUsageItem> Assets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReferenceUsageResponse" /> class.
        /// </summary>
        /// <param name="assets"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetReferenceUsageResponse(
            global::System.Collections.Generic.IList<global::Ideogram.AssetReferenceUsageItem> assets,
            string? nextCursor)
        {
            this.Assets = assets ?? throw new global::System.ArgumentNullException(nameof(assets));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReferenceUsageResponse" /> class.
        /// </summary>
        public AssetReferenceUsageResponse()
        {
        }

    }
}