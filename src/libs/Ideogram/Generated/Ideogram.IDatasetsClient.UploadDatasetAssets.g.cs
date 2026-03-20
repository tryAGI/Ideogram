#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Upload assets to a dataset<br/>
        /// Upload image assets to a dataset for model training. Accepts individual images (JPEG, PNG, WebP), optional .txt caption sidecar files, and/or ZIP archives containing images and captions.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.UploadDatasetAssetsResponse> UploadDatasetAssetsAsync(
            string datasetId,

            global::Ideogram.UploadDatasetAssetsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload assets to a dataset<br/>
        /// Upload image assets to a dataset for model training. Accepts individual images (JPEG, PNG, WebP), optional .txt caption sidecar files, and/or ZIP archives containing images and captions.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="files">
        /// Image files (JPEG, PNG, WebP), .txt caption sidecar files, and/or ZIP archives containing images and captions. Caption .txt files are matched to images by filename stem (e.g. sunset.txt provides the caption for sunset.jpg).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.UploadDatasetAssetsResponse> UploadDatasetAssetsAsync(
            string datasetId,
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}