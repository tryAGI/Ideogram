#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with ERNIE-Image-Turbo<br/>
        /// Generates images synchronously using the ERNIE-Image-Turbo model. Width<br/>
        /// and height must each be a positive multiple of 16 and the total area<br/>
        /// must not exceed 1,075,200 pixels (896×1200); the server validates these<br/>
        /// against the model's resolution constraints.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponse> PostGenerateImageErnieAsync(

            global::Ideogram.GenerateImageRequestErnie request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with ERNIE-Image-Turbo<br/>
        /// Generates images synchronously using the ERNIE-Image-Turbo model. Width<br/>
        /// and height must each be a positive multiple of 16 and the total area<br/>
        /// must not exceed 1,075,200 pixels (896×1200); the server validates these<br/>
        /// against the model's resolution constraints.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponse>> PostGenerateImageErnieAsResponseAsync(

            global::Ideogram.GenerateImageRequestErnie request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with ERNIE-Image-Turbo<br/>
        /// Generates images synchronously using the ERNIE-Image-Turbo model. Width<br/>
        /// and height must each be a positive multiple of 16 and the total area<br/>
        /// must not exceed 1,075,200 pixels (896×1200); the server validates these<br/>
        /// against the model's resolution constraints.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt for image generation.<br/>
        /// Example: A poster with bold typography reading "GRAND OPENING", art deco style.
        /// </param>
        /// <param name="systemPrompt">
        /// An optional system prompt applied alongside the prompt — use it for<br/>
        /// standing instructions such as style constraints or "do not render<br/>
        /// text". When omitted, no system prompt is applied. If you trained a<br/>
        /// LoRA with a system prompt, supply the same one here for best results.<br/>
        /// Example: Do not include any text in the image.
        /// </param>
        /// <param name="width">
        /// Output width in pixels; must be a positive multiple of 16.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="height">
        /// Output height in pixels; must be a positive multiple of 16.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="numInferenceSteps">
        /// Optional diffusion step count. When omitted, the server uses the<br/>
        /// model's default. Higher values trade latency for quality.<br/>
        /// Example: 8
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the URI must resolve to a registered fine-tune of the<br/>
        /// ERNIE base model; the fine-tune's LoRA checkpoint is layered on the<br/>
        /// base. When omitted, the ERNIE base is used with no LoRA.<br/>
        /// Example: model/my-ernie-lora/version/0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponse> PostGenerateImageErnieAsync(
            string prompt,
            string? systemPrompt = default,
            int? width = default,
            int? height = default,
            int? numInferenceSteps = default,
            int? seed = default,
            int? numImages = default,
            string? customModelUri = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}