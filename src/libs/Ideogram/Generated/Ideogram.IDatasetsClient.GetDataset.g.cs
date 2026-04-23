#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get a dataset<br/>
        /// Returns a dataset by ID, including the total number of files and a list of each file's name and size in bytes.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetDatasetResponse> GetDatasetAsync(
            string datasetId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}