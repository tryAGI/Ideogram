#nullable enable

namespace Ideogram
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Magic Prompt Job Status and TFRecord URL if available<br/>
        /// Gets the status of a batch magic prompt job and the TFRecord URL if available.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InternalBatchStatusResponse> GetBatchStatusAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}