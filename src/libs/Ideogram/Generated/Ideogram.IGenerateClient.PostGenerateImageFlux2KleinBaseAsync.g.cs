#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with FLUX.2-Klein (undistilled base) asynchronously via webhook<br/>
        /// Accepts an undistilled-base FLUX.2-Klein generation request for asynchronous processing and<br/>
        /// returns immediately with a generation_id. The generated images are POSTed to<br/>
        /// the supplied `webhook_url` once ready, in a payload that mirrors the<br/>
        /// synchronous response with an added generation_id for correlation.<br/>
        /// See [Webhooks](/ideogram-api/webhooks) for the delivery payload and how to verify webhook signatures.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageFlux2KleinBaseAsyncAsync(
            string webhookUrl,

            global::Ideogram.GenerateImageRequestFlux2KleinBase request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with FLUX.2-Klein (undistilled base) asynchronously via webhook<br/>
        /// Accepts an undistilled-base FLUX.2-Klein generation request for asynchronous processing and<br/>
        /// returns immediately with a generation_id. The generated images are POSTed to<br/>
        /// the supplied `webhook_url` once ready, in a payload that mirrors the<br/>
        /// synchronous response with an added generation_id for correlation.<br/>
        /// See [Webhooks](/ideogram-api/webhooks) for the delivery payload and how to verify webhook signatures.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostGenerateImageFlux2KleinBaseAsyncAsResponseAsync(
            string webhookUrl,

            global::Ideogram.GenerateImageRequestFlux2KleinBase request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with FLUX.2-Klein (undistilled base) asynchronously via webhook<br/>
        /// Accepts an undistilled-base FLUX.2-Klein generation request for asynchronous processing and<br/>
        /// returns immediately with a generation_id. The generated images are POSTed to<br/>
        /// the supplied `webhook_url` once ready, in a payload that mirrors the<br/>
        /// synchronous response with an added generation_id for correlation.<br/>
        /// See [Webhooks](/ideogram-api/webhooks) for the delivery payload and how to verify webhook signatures.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
        /// <param name="prompt">
        /// A natural-language prompt for image generation.<br/>
        /// Example: A photo of a tabby cat sleeping on a couch, soft daylight.
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
        /// Example: 50
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
        /// FLUX.2-Klein base model; the fine-tune's LoRA checkpoint is layered<br/>
        /// on the base. When omitted, the FLUX.2-Klein base is used with no LoRA.<br/>
        /// Example: model/my-flux-klein-base-lora/version/0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageFlux2KleinBaseAsyncAsync(
            string webhookUrl,
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