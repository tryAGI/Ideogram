
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"asset_identifier":{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"},"file_name":"file_name"}
    /// </summary>
    public sealed partial class DatasetUploadSucceededAsset
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
        /// Original filename of the uploaded image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUploadSucceededAsset" /> class.
        /// </summary>
        /// <param name="assetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="fileName">
        /// Original filename of the uploaded image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetUploadSucceededAsset(
            global::Ideogram.AssetIdentifier assetIdentifier,
            string? fileName)
        {
            this.AssetIdentifier = assetIdentifier ?? throw new global::System.ArgumentNullException(nameof(assetIdentifier));
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUploadSucceededAsset" /> class.
        /// </summary>
        public DatasetUploadSucceededAsset()
        {
        }
    }
}