
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetAssetsRequest
    {
        /// <summary>
        /// Image files (JPEG, PNG, WebP), .txt caption sidecar files, and/or ZIP archives containing images and captions. Caption .txt files are matched to images by filename stem (e.g. sunset.txt provides the caption for sunset.jpg). Captions are optional!
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetAssetsRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Image files (JPEG, PNG, WebP), .txt caption sidecar files, and/or ZIP archives containing images and captions. Caption .txt files are matched to images by filename stem (e.g. sunset.txt provides the caption for sunset.jpg). Captions are optional!
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDatasetAssetsRequest(
            global::System.Collections.Generic.IList<byte[]> files)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetAssetsRequest" /> class.
        /// </summary>
        public UploadDatasetAssetsRequest()
        {
        }
    }
}