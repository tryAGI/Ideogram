#nullable enable

namespace Ideogram
{
    public partial interface IGenerationsClient
    {
        /// <summary>
        /// Poll a generation<br/>
        /// Retrieves the current status of an asynchronous generation, and its<br/>
        /// results once complete. Use the `generation_id` returned by any `/v2`<br/>
        /// endpoint that runs asynchronously: every video and tool endpoint, and<br/>
        /// any image endpoint called with `async` or a `webhook_url`.<br/>
        /// While the generation is `pending` or has `failed`, the response<br/>
        /// contains only `generation_id`, `status`, and `created` (plus<br/>
        /// `failure_reason` once failed). Once `status` is `completed`, the<br/>
        /// response includes `response_type` and `data`. Each `data` item carries<br/>
        /// an `object_type` that identifies its shape, so image and video results<br/>
        /// can be told apart. `usage_cost_usd_micros` reports the amount billed<br/>
        /// when the request uses variable usage-based pricing.<br/>
        /// Polling is rate limited per organization; a 429 response carries a<br/>
        /// `Retry-After` header with the number of seconds to wait.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerationResponse> GetGenerationV2Async(
            string generationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll a generation<br/>
        /// Retrieves the current status of an asynchronous generation, and its<br/>
        /// results once complete. Use the `generation_id` returned by any `/v2`<br/>
        /// endpoint that runs asynchronously: every video and tool endpoint, and<br/>
        /// any image endpoint called with `async` or a `webhook_url`.<br/>
        /// While the generation is `pending` or has `failed`, the response<br/>
        /// contains only `generation_id`, `status`, and `created` (plus<br/>
        /// `failure_reason` once failed). Once `status` is `completed`, the<br/>
        /// response includes `response_type` and `data`. Each `data` item carries<br/>
        /// an `object_type` that identifies its shape, so image and video results<br/>
        /// can be told apart. `usage_cost_usd_micros` reports the amount billed<br/>
        /// when the request uses variable usage-based pricing.<br/>
        /// Polling is rate limited per organization; a 429 response carries a<br/>
        /// `Retry-After` header with the number of seconds to wait.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerationResponse>> GetGenerationV2AsResponseAsync(
            string generationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}