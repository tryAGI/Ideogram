#nullable enable

namespace Ideogram
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Search assets from an enabled integration type
        /// </summary>
        /// <param name="integrationType">
        /// A provider-neutral integration operation family.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.IntegrationAssetSearchResponse> PostIntegrationAssetsSearchAsync(
            global::Ideogram.IntegrationType integrationType,

            global::Ideogram.IntegrationAssetSearchRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search assets from an enabled integration type
        /// </summary>
        /// <param name="integrationType">
        /// A provider-neutral integration operation family.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.IntegrationAssetSearchResponse>> PostIntegrationAssetsSearchAsResponseAsync(
            global::Ideogram.IntegrationType integrationType,

            global::Ideogram.IntegrationAssetSearchRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search assets from an enabled integration type
        /// </summary>
        /// <param name="integrationType">
        /// A provider-neutral integration operation family.
        /// </param>
        /// <param name="limit">
        /// Maximum number of assets to return, bounded by the configured runtime policy. The operation returns a single bounded browse result; text search and pagination are future extensions that add optional fields additively.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.IntegrationAssetSearchResponse> PostIntegrationAssetsSearchAsync(
            global::Ideogram.IntegrationType integrationType,
            int limit,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}