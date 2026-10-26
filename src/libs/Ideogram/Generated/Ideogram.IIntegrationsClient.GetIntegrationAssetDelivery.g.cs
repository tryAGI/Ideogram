#nullable enable

namespace Ideogram
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Fetch the media bytes for an integration asset<br/>
        /// Redeems the short-lived signed delivery reference returned by an integration asset search and streams the asset's media bytes. The signed reference is the sole authorization for this endpoint; it is rejected once it expires or when the integration it names has changed.
        /// </summary>
        /// <param name="externalRef"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetIntegrationAssetDeliveryAsync(
            string externalRef,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch the media bytes for an integration asset<br/>
        /// Redeems the short-lived signed delivery reference returned by an integration asset search and streams the asset's media bytes. The signed reference is the sole authorization for this endpoint; it is rejected once it expires or when the integration it names has changed.
        /// </summary>
        /// <param name="externalRef"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetIntegrationAssetDeliveryAsStreamAsync(
            string externalRef,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch the media bytes for an integration asset<br/>
        /// Redeems the short-lived signed delivery reference returned by an integration asset search and streams the asset's media bytes. The signed reference is the sole authorization for this endpoint; it is rejected once it expires or when the integration it names has changed.
        /// </summary>
        /// <param name="externalRef"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::System.IO.Stream>> GetIntegrationAssetDeliveryAsStreamAsResponseAsync(
            string externalRef,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fetch the media bytes for an integration asset<br/>
        /// Redeems the short-lived signed delivery reference returned by an integration asset search and streams the asset's media bytes. The signed reference is the sole authorization for this endpoint; it is rejected once it expires or when the integration it names has changed.
        /// </summary>
        /// <param name="externalRef"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<byte[]>> GetIntegrationAssetDeliveryAsResponseAsync(
            string externalRef,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}