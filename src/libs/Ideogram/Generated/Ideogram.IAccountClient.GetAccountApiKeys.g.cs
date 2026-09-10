#nullable enable

namespace Ideogram
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// List your organization's API keys<br/>
        /// Lists the API keys in your organization. Key material is redacted —<br/>
        /// the full key is only shown once, when it is created. Disabled and<br/>
        /// archived keys are included (see each key's `status`) so historical<br/>
        /// usage can always be matched to the key that generated it.<br/>
        /// Requires an API key whose owner is an organization admin. Keys owned<br/>
        /// by other members receive a 404.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ListAccountApiKeysResponse> GetAccountApiKeysAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List your organization's API keys<br/>
        /// Lists the API keys in your organization. Key material is redacted —<br/>
        /// the full key is only shown once, when it is created. Disabled and<br/>
        /// archived keys are included (see each key's `status`) so historical<br/>
        /// usage can always be matched to the key that generated it.<br/>
        /// Requires an API key whose owner is an organization admin. Keys owned<br/>
        /// by other members receive a 404.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ListAccountApiKeysResponse>> GetAccountApiKeysAsResponseAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}