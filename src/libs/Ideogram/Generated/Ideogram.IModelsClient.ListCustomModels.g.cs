#nullable enable

namespace Ideogram
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models<br/>
        /// Lists custom models for the authenticated user. Use the `scope` parameter to control which models are returned. `owned` (default) returns models created by the user. `shared` returns models shared with the user's organization via the model registry, excluding the user's own models.
        /// </summary>
        /// <param name="scope">
        /// Default Value: owned
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ListModelsResponse> ListCustomModelsAsync(
            global::Ideogram.ListCustomModelsScope? scope = default,
            global::System.Collections.Generic.IList<global::Ideogram.ModelStatus>? status = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}