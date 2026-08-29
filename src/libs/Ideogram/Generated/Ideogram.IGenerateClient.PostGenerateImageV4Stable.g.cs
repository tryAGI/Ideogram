#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 4.0 (stable model)<br/>
        /// Generates images synchronously using a pinned stable build of the<br/>
        /// Ideogram 4.0 model. This endpoint is intentionally minimal: it accepts<br/>
        /// only a prompt (and optional seed), pins the underlying model URI, and<br/>
        /// lets the server pick the output resolution automatically.<br/>
        /// Images links are available for a limited period of time; if you would<br/>
        /// like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4StableAsync(

            global::Ideogram.GenerateImageRequestV4Stable request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0 (stable model)<br/>
        /// Generates images synchronously using a pinned stable build of the<br/>
        /// Ideogram 4.0 model. This endpoint is intentionally minimal: it accepts<br/>
        /// only a prompt (and optional seed), pins the underlying model URI, and<br/>
        /// lets the server pick the output resolution automatically.<br/>
        /// Images links are available for a limited period of time; if you would<br/>
        /// like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostGenerateImageV4StableAsResponseAsync(

            global::Ideogram.GenerateImageRequestV4Stable request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0 (stable model)<br/>
        /// Generates images synchronously using a pinned stable build of the<br/>
        /// Ideogram 4.0 model. This endpoint is intentionally minimal: it accepts<br/>
        /// only a prompt (and optional seed), pins the underlying model URI, and<br/>
        /// lets the server pick the output resolution automatically.<br/>
        /// Images links are available for a limited period of time; if you would<br/>
        /// like to keep the image, you must download it.
        /// </summary>
        /// <param name="textPrompt">
        /// A natural-language prompt for image generation. When supplied,<br/>
        /// magic-prompt is enabled automatically. Mutually exclusive with<br/>
        /// `json_prompt`.
        /// </param>
        /// <param name="jsonPrompt">
        /// A structured prompt that conforms to the Ideogram 4.0 JSON<br/>
        /// contract. When supplied, magic-prompt is disabled and the<br/>
        /// structured prompt is consumed by the diffusion model directly.<br/>
        /// Mutually exclusive with `text_prompt`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="resolution">
        /// Optional. When supplied, the image is generated at this<br/>
        /// resolution. When omitted, the server picks an aspect ratio<br/>
        /// automatically based on the prompt.
        /// </param>
        /// <param name="version">
        /// Optional. Selects a specific pinned stable build. When omitted,<br/>
        /// the default stable model URI is used. When set to `stable_may29`,<br/>
        /// the request is routed to the May 29th stable build.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4StableAsync(
            string? textPrompt = default,
            global::Ideogram.V4JsonPrompt? jsonPrompt = default,
            int? seed = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.GenerateImageRequestV4StableVersion? version = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}