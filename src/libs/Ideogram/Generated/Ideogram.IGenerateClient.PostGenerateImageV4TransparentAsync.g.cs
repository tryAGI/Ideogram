#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 4.0 (Transparent Background) asynchronously<br/>
        /// Accepts an Ideogram 4.0 transparent-background generation request for<br/>
        /// asynchronous processing and returns immediately with a generation_id.<br/>
        /// Poll `GET /v1/generations/{generation_id}` to retrieve the result. If a<br/>
        /// `webhook_url` is supplied, the generated images are additionally POSTed<br/>
        /// to it once ready, in a payload that mirrors the synchronous response<br/>
        /// with an added generation_id for correlation.<br/>
        /// See the synchronous `/v1/ideogram-v4/generate-transparent` endpoint for<br/>
        /// the request semantics, including `output_resolution` tiers.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageV4TransparentAsyncAsync(

            global::Ideogram.GenerateTransparentImageRequestV4 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0 (Transparent Background) asynchronously<br/>
        /// Accepts an Ideogram 4.0 transparent-background generation request for<br/>
        /// asynchronous processing and returns immediately with a generation_id.<br/>
        /// Poll `GET /v1/generations/{generation_id}` to retrieve the result. If a<br/>
        /// `webhook_url` is supplied, the generated images are additionally POSTed<br/>
        /// to it once ready, in a payload that mirrors the synchronous response<br/>
        /// with an added generation_id for correlation.<br/>
        /// See the synchronous `/v1/ideogram-v4/generate-transparent` endpoint for<br/>
        /// the request semantics, including `output_resolution` tiers.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostGenerateImageV4TransparentAsyncAsResponseAsync(

            global::Ideogram.GenerateTransparentImageRequestV4 request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0 (Transparent Background) asynchronously<br/>
        /// Accepts an Ideogram 4.0 transparent-background generation request for<br/>
        /// asynchronous processing and returns immediately with a generation_id.<br/>
        /// Poll `GET /v1/generations/{generation_id}` to retrieve the result. If a<br/>
        /// `webhook_url` is supplied, the generated images are additionally POSTed<br/>
        /// to it once ready, in a payload that mirrors the synchronous response<br/>
        /// with an added generation_id for correlation.<br/>
        /// See the synchronous `/v1/ideogram-v4/generate-transparent` endpoint for<br/>
        /// the request semantics, including `output_resolution` tiers.<br/>
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
        /// <param name="textPrompt">
        /// A natural-language prompt for image generation. When supplied,<br/>
        /// magic-prompt is enabled automatically. Mutually exclusive with<br/>
        /// `json_prompt`.
        /// </param>
        /// <param name="jsonPrompt">
        /// A structured prompt that conforms to the Ideogram 4.0 JSON<br/>
        /// contract. When supplied, magic-prompt is disabled and the<br/>
        /// structured prompt is consumed by the diffusion model directly,<br/>
        /// except that `compositional_deconstruction.background` is replaced<br/>
        /// with a transparent-background directive. Mutually exclusive with<br/>
        /// `text_prompt`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored when `text_prompt` is supplied. Ignored<br/>
        /// when `json_prompt` is supplied.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 4.0 magic prompt. `AUTO` lets the<br/>
        /// model select the most suitable ratio from the prompt; any other value<br/>
        /// pins the ratio. The non-AUTO values are the buckets the 4.0 model<br/>
        /// supports.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution tier for the generated image. Tiers are<br/>
        /// total-pixel budgets matching a square of the named size (for example,<br/>
        /// `8K` delivers at most 8192x8192 total pixels); wide and tall aspect<br/>
        /// ratios keep the same pixel budget, so a single dimension may exceed<br/>
        /// the named size. Defaults to 1K.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. Defaults to DEFAULT.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImageV4TransparentAsyncAsync(
            string? webhookUrl = default,
            string? textPrompt = default,
            global::Ideogram.V4JsonPrompt? jsonPrompt = default,
            int? seed = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.AspectRatioV4? aspectRatio = default,
            global::Ideogram.OutputResolution? outputResolution = default,
            global::Ideogram.RenderingSpeedV4? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}