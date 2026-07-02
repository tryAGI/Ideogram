#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Poll a generation<br/>
        /// Retrieves the current status of an asynchronous generation, and its results once complete. Use the `generation_id` returned by the async generation endpoint. While the generation is `pending` or has `failed`, the response contains only `generation_id`, `status`, and `created`; the `response_type` and `data` fields are present only once `status` is `completed`.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerationResponse> GetGenerationAsync(
            string generationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll a generation<br/>
        /// Retrieves the current status of an asynchronous generation, and its results once complete. Use the `generation_id` returned by the async generation endpoint. While the generation is `pending` or has `failed`, the response contains only `generation_id`, `status`, and `created`; the `response_type` and `data` fields are present only once `status` is `completed`.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerationResponse>> GetGenerationAsResponseAsync(
            string generationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}