#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets<br/>
        /// Lists datasets for the authenticated user, most recently updated first. Supports an optional case-insensitive name search.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ListDatasetsResponse> ListDatasetsAsync(
            string? search = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List datasets<br/>
        /// Lists datasets for the authenticated user, most recently updated first. Supports an optional case-insensitive name search.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ListDatasetsResponse>> ListDatasetsAsResponseAsync(
            string? search = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}