#nullable enable

namespace Ideogram
{
    public partial interface IMiniAppsClient
    {
        /// <summary>
        /// Get the public mini-app marketing projection<br/>
        /// Returns the public-safe mini-app metadata used to build marketing pages. The response includes only active marketing entries that have website metadata and can be published unchanged as the marketing registry.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Ideogram.MiniAppMarketingProjectionEntry>> GetMiniAppMarketingProjectionAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the public mini-app marketing projection<br/>
        /// Returns the public-safe mini-app metadata used to build marketing pages. The response includes only active marketing entries that have website metadata and can be published unchanged as the marketing registry.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Ideogram.MiniAppMarketingProjectionEntry>>> GetMiniAppMarketingProjectionAsResponseAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}