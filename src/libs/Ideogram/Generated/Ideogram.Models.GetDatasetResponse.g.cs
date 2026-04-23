
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Detailed view of a dataset, including its files.<br/>
    /// Example: {"file_count":0,"files":[{"file_name":"file_name","file_size_bytes":6},{"file_name":"file_name","file_size_bytes":6}],"dataset":{"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}},"custom_model_id":"custom_model_id"}
    /// </summary>
    public sealed partial class GetDatasetResponse
    {
        /// <summary>
        /// A dataset for organizing training images.<br/>
        /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}}
        /// </summary>
        /// <example>{"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.Dataset Dataset { get; set; }

        /// <summary>
        /// Total number of files in the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileCount { get; set; }

        /// <summary>
        /// List of files in the dataset.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.DatasetFile> Files { get; set; }

        /// <summary>
        /// ID of the custom model trained from this dataset, if one exists. Null if no model has been trained yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_id")]
        public string? CustomModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetResponse" /> class.
        /// </summary>
        /// <param name="dataset">
        /// A dataset for organizing training images.<br/>
        /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}}
        /// </param>
        /// <param name="fileCount">
        /// Total number of files in the dataset.
        /// </param>
        /// <param name="files">
        /// List of files in the dataset.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="customModelId">
        /// ID of the custom model trained from this dataset, if one exists. Null if no model has been trained yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDatasetResponse(
            global::Ideogram.Dataset dataset,
            int fileCount,
            global::System.Collections.Generic.IList<global::Ideogram.DatasetFile> files,
            string? customModelId)
        {
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.FileCount = fileCount;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.CustomModelId = customModelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDatasetResponse" /> class.
        /// </summary>
        public GetDatasetResponse()
        {
        }
    }
}