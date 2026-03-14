
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"successful_assets":[{"asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"file_name":"file_name"},{"asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"file_name":"file_name"}],"total_count":0,"failed_assets":[{"file_name":"file_name","failure_reason":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"},{"file_name":"file_name","failure_reason":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464"}],"success_count":6,"failure_count":1}
    /// </summary>
    public sealed partial class UploadDatasetAssetsResponse
    {
        /// <summary>
        /// Total number of images processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Number of images successfully uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SuccessCount { get; set; }

        /// <summary>
        /// Number of images that failed to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailureCount { get; set; }

        /// <summary>
        /// Details of successfully uploaded assets.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_assets")]
        public global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadSucceededAsset>? SuccessfulAssets { get; set; }

        /// <summary>
        /// Details of assets that failed to upload.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_assets")]
        public global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadFailedAsset>? FailedAssets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetAssetsResponse" /> class.
        /// </summary>
        /// <param name="totalCount">
        /// Total number of images processed.
        /// </param>
        /// <param name="successCount">
        /// Number of images successfully uploaded.
        /// </param>
        /// <param name="failureCount">
        /// Number of images that failed to upload.
        /// </param>
        /// <param name="successfulAssets">
        /// Details of successfully uploaded assets.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="failedAssets">
        /// Details of assets that failed to upload.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDatasetAssetsResponse(
            int totalCount,
            int successCount,
            int failureCount,
            global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadSucceededAsset>? successfulAssets,
            global::System.Collections.Generic.IList<global::Ideogram.DatasetUploadFailedAsset>? failedAssets)
        {
            this.TotalCount = totalCount;
            this.SuccessCount = successCount;
            this.FailureCount = failureCount;
            this.SuccessfulAssets = successfulAssets;
            this.FailedAssets = failedAssets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetAssetsResponse" /> class.
        /// </summary>
        public UploadDatasetAssetsResponse()
        {
        }
    }
}