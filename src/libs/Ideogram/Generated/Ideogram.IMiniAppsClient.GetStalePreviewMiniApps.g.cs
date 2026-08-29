#nullable enable

namespace Ideogram
{
    public partial interface IMiniAppsClient
    {
        /// <summary>
        /// Get stale mini-app preview entries<br/>
        /// Returns preview ids whose most recent successful publish is older than the cutoff. This read-only endpoint does not delete preview entries.
        /// </summary>
        /// <param name="cutoff"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetStaleMiniAppPreviewsResponse> GetStalePreviewMiniAppsAsync(
            global::System.DateTime cutoff,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get stale mini-app preview entries<br/>
        /// Returns preview ids whose most recent successful publish is older than the cutoff. This read-only endpoint does not delete preview entries.
        /// </summary>
        /// <param name="cutoff"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GetStaleMiniAppPreviewsResponse>> GetStalePreviewMiniAppsAsResponseAsync(
            global::System.DateTime cutoff,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}