
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"file_name":"file_name","failure_reason":null}
    /// </summary>
    public sealed partial class DatasetUploadFailedAsset
    {
        /// <summary>
        /// Original filename of the failed image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Reason why an asset failed to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.DatasetAssetFailureReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.DatasetAssetFailureReason FailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUploadFailedAsset" /> class.
        /// </summary>
        /// <param name="fileName">
        /// Original filename of the failed image.
        /// </param>
        /// <param name="failureReason">
        /// Reason why an asset failed to upload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetUploadFailedAsset(
            global::Ideogram.DatasetAssetFailureReason failureReason,
            string? fileName)
        {
            this.FailureReason = failureReason;
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetUploadFailedAsset" /> class.
        /// </summary>
        public DatasetUploadFailedAsset()
        {
        }
    }
}