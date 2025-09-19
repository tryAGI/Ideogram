#nullable enable

namespace Ideogram
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get Batch Magic Prompt Job Results if available.<br/>
        /// Gets the results of a batch magic prompt job if available.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InternalBatchResultsResponse> GetMaybeBatchResultsAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}