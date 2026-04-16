
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A dataset for organizing training images.<br/>
    /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","user_id":"user_id","dataset_id":"dataset_id","name":"name","cover_asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}}
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// Unique identifier for the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Display name of the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of the user who owns this dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// When the dataset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_asset_identifier")]
        public global::Ideogram.AssetIdentifier? CoverAssetIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// Unique identifier for the dataset.
        /// </param>
        /// <param name="name">
        /// Display name of the dataset.
        /// </param>
        /// <param name="userId">
        /// ID of the user who owns this dataset.
        /// </param>
        /// <param name="creationTime">
        /// When the dataset was created.
        /// </param>
        /// <param name="coverAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Dataset(
            string datasetId,
            string name,
            string userId,
            global::System.DateTime creationTime,
            global::Ideogram.AssetIdentifier? coverAssetIdentifier)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreationTime = creationTime;
            this.CoverAssetIdentifier = coverAssetIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}