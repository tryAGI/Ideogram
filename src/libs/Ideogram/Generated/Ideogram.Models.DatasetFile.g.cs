
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A file in a dataset.<br/>
    /// Example: {"file_name":"file_name","caption":"caption","file_size_bytes":6}
    /// </summary>
    public sealed partial class DatasetFile
    {
        /// <summary>
        /// Filename of the file in the dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// Size of the file in bytes, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size_bytes")]
        public long? FileSizeBytes { get; set; }

        /// <summary>
        /// Caption applied to the file, if any. A v4 structured caption is returned as a JSON-encoded string; a plain-text caption (from a .txt sidecar) is returned unchanged. Only present when the file has a caption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public string? Caption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFile" /> class.
        /// </summary>
        /// <param name="fileName">
        /// Filename of the file in the dataset.
        /// </param>
        /// <param name="fileSizeBytes">
        /// Size of the file in bytes, if available.
        /// </param>
        /// <param name="caption">
        /// Caption applied to the file, if any. A v4 structured caption is returned as a JSON-encoded string; a plain-text caption (from a .txt sidecar) is returned unchanged. Only present when the file has a caption.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetFile(
            string? fileName,
            long? fileSizeBytes,
            string? caption)
        {
            this.FileName = fileName;
            this.FileSizeBytes = fileSizeBytes;
            this.Caption = caption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFile" /> class.
        /// </summary>
        public DatasetFile()
        {
        }

    }
}