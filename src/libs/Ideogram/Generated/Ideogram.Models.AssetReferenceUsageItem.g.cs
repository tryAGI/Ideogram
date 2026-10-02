
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"collection_id":"collection_id","collection_path":"collection_path","asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"file_name":"file_name","download_url":"download_url","collection_name":"collection_name","request_count":1}
    /// </summary>
    public sealed partial class AssetReferenceUsageItem
    {
        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier AssetIdentifier { get; set; }

        /// <summary>
        /// Present when include_collections is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        public string? CollectionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        public string? CollectionName { get; set; }

        /// <summary>
        /// Readable collection names from accessible ancestors through this collection, separated by " / ".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_path")]
        public string? CollectionPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Signed image URL valid for 24 hours, issued only when the caller can read the asset. Refresh the listing to obtain a fresh URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Completed organization requests using the asset as an edit input within the requested range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReferenceUsageItem" /> class.
        /// </summary>
        /// <param name="assetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="requestCount">
        /// Completed organization requests using the asset as an edit input within the requested range.
        /// </param>
        /// <param name="collectionId">
        /// Present when include_collections is true.
        /// </param>
        /// <param name="collectionName"></param>
        /// <param name="collectionPath">
        /// Readable collection names from accessible ancestors through this collection, separated by " / ".
        /// </param>
        /// <param name="fileName"></param>
        /// <param name="downloadUrl">
        /// Signed image URL valid for 24 hours, issued only when the caller can read the asset. Refresh the listing to obtain a fresh URL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetReferenceUsageItem(
            global::Ideogram.AssetIdentifier assetIdentifier,
            long requestCount,
            string? collectionId,
            string? collectionName,
            string? collectionPath,
            string? fileName,
            string? downloadUrl)
        {
            this.AssetIdentifier = assetIdentifier ?? throw new global::System.ArgumentNullException(nameof(assetIdentifier));
            this.CollectionId = collectionId;
            this.CollectionName = collectionName;
            this.CollectionPath = collectionPath;
            this.FileName = fileName;
            this.DownloadUrl = downloadUrl;
            this.RequestCount = requestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetReferenceUsageItem" /> class.
        /// </summary>
        public AssetReferenceUsageItem()
        {
        }

    }
}