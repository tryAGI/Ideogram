#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with the distilled few-step Ideogram model (low speed tier)<br/>
        /// Generates images synchronously using the distilled few-step Ideogram<br/>
        /// model at the low speed tier — fast and low-cost, with a modest quality<br/>
        /// trade-off. The speed tier controls the number of diffusion steps and the<br/>
        /// per-image price.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImagePImageLowAsync(

            global::Ideogram.GenerateImageRequestPImage request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with the distilled few-step Ideogram model (low speed tier)<br/>
        /// Generates images synchronously using the distilled few-step Ideogram<br/>
        /// model at the low speed tier — fast and low-cost, with a modest quality<br/>
        /// trade-off. The speed tier controls the number of diffusion steps and the<br/>
        /// per-image price.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostGenerateImagePImageLowAsResponseAsync(

            global::Ideogram.GenerateImageRequestPImage request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with the distilled few-step Ideogram model (low speed tier)<br/>
        /// Generates images synchronously using the distilled few-step Ideogram<br/>
        /// model at the low speed tier — fast and low-cost, with a modest quality<br/>
        /// trade-off. The speed tier controls the number of diffusion steps and the<br/>
        /// per-image price.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for image generation. Accepts either natural language or<br/>
        /// a structured prompt that conforms to the Ideogram 4.0 JSON contract;<br/>
        /// the server detects which was supplied. See `prompt_upsampling` for<br/>
        /// how magic-prompt is applied.
        /// </param>
        /// <param name="promptUpsampling">
        /// Controls magic-prompt (prompt upsampling). `AUTO` (default) applies<br/>
        /// magic-prompt to a natural-language `prompt` or a non-Ideogram 4.0 JSON<br/>
        /// `prompt`, and skips it when `prompt` is already a structured Ideogram<br/>
        /// 4.0 JSON prompt. `ON` always applies magic-prompt, even to an Ideogram<br/>
        /// 4.0 JSON prompt; `OFF` never applies it. Defaults to `AUTO`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored only when magic-prompt runs (a<br/>
        /// natural-language `prompt` with `prompt_upsampling` AUTO or ON).
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImagePImageLowAsync(
            string prompt,
            global::Ideogram.MagicPromptOption? promptUpsampling = default,
            int? seed = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4? resolution = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}