#nullable enable

namespace Ideogram
{
    public partial interface IMiniAppsClient
    {
        /// <summary>
        /// Unpublish a mini-app preview entry<br/>
        /// Deletes a mini-app preview entry by its preview id. Repeated requests succeed when the entry is already absent, so preview teardown can retry safely.
        /// </summary>
        /// <param name="previewId">
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.UnpublishMiniAppPreviewResponse> UnpublishPreviewMiniAppAsync(
            string previewId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unpublish a mini-app preview entry<br/>
        /// Deletes a mini-app preview entry by its preview id. Repeated requests succeed when the entry is already absent, so preview teardown can retry safely.
        /// </summary>
        /// <param name="previewId">
        /// Unique, URL-safe preview identifier composed by the deploy pipeline.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.UnpublishMiniAppPreviewResponse>> UnpublishPreviewMiniAppAsResponseAsync(
            string previewId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}