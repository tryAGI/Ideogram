#nullable enable

namespace Ideogram
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List enabled integration types<br/>
        /// Lists the distinct integration types enabled for the authenticated organization. The response does not expose configured integration rows, provider details, configuration, or credentials.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetIntegrationsResponse> GetIntegrationsAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List enabled integration types<br/>
        /// Lists the distinct integration types enabled for the authenticated organization. The response does not expose configured integration rows, provider details, configuration, or credentials.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GetIntegrationsResponse>> GetIntegrationsAsResponseAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}