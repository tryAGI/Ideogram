
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A file in a dataset.<br/>
    /// Example: {"file_name":"file_name","file_size_bytes":6}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetFile(
            string? fileName,
            long? fileSizeBytes)
        {
            this.FileName = fileName;
            this.FileSizeBytes = fileSizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFile" /> class.
        /// </summary>
        public DatasetFile()
        {
        }
    }
}