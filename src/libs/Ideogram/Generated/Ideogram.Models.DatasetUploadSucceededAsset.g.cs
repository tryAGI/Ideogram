
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"asset_identifier":"","file_name":"file_name"}
    /// </summary>
    public sealed partial class DatasetUploadSucceededAsset
    {
        /// <summary>
        /// The uploaded image's asset identifier. For a caption sidecar entry, points to the image the caption was applied to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AssetIdentifier AssetIdentifier { get; set; }

        /// <summary>
        /// Original filename of the uploaded file. For a caption sidecar (.txt or .json) this is the sidecar's filename. A single image therefore yields one entry for the image plus one per caption file.
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
        /// The uploaded image's asset identifier. For a caption sidecar entry, points to the image the caption was applied to.
        /// </param>
        /// <param name="fileName">
        /// Original filename of the uploaded file. For a caption sidecar (.txt or .json) this is the sidecar's filename. A single image therefore yields one entry for the image plus one per caption file.
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