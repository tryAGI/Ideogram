#nullable enable

namespace Ideogram
{
    public partial interface IMiniAppsClient
    {
        /// <summary>
        /// Unpublish a mini-app catalog entry<br/>
        /// Archives a mini-app by slug while preserving its deployment details and administrator-managed settings. Publishing the same slug again does not reactivate it; only an administrator can restore an archived app.
        /// </summary>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task UnpublishMiniAppAsync(
            string slug,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unpublish a mini-app catalog entry<br/>
        /// Archives a mini-app by slug while preserving its deployment details and administrator-managed settings. Publishing the same slug again does not reactivate it; only an administrator can restore an archived app.
        /// </summary>
        /// <param name="slug">
        /// Unique, stable, URL-safe mini-app identifier.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse> UnpublishMiniAppAsResponseAsync(
            string slug,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}