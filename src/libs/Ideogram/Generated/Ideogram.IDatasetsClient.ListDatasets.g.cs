#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets<br/>
        /// Lists all datasets for the authenticated user
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ListDatasetsResponse> ListDatasetsAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}