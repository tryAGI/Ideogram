#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with P-Image Ideogram asynchronously<br/>
        /// Accepts a P-Image Ideogram generation request for asynchronous processing<br/>
        /// and returns immediately with a generation_id. Poll<br/>
        /// `GET /v1/generations/{generation_id}` to retrieve the result. If a<br/>
        /// `webhook_url` is supplied, the generated images are additionally POSTed<br/>
        /// to it once ready, in a payload that mirrors the synchronous response with<br/>
        /// an added generation_id for correlation.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImagePImageIdeogramAsyncAsync(

            global::Ideogram.GenerateImageRequestPImageIdeogram request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with P-Image Ideogram asynchronously<br/>
        /// Accepts a P-Image Ideogram generation request for asynchronous processing<br/>
        /// and returns immediately with a generation_id. Poll<br/>
        /// `GET /v1/generations/{generation_id}` to retrieve the result. If a<br/>
        /// `webhook_url` is supplied, the generated images are additionally POSTed<br/>
        /// to it once ready, in a payload that mirrors the synchronous response with<br/>
        /// an added generation_id for correlation.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostGenerateImagePImageIdeogramAsyncAsResponseAsync(

            global::Ideogram.GenerateImageRequestPImageIdeogram request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with P-Image Ideogram asynchronously<br/>
        /// Accepts a P-Image Ideogram generation request for asynchronous processing<br/>
        /// and returns immediately with a generation_id. Poll<br/>
        /// `GET /v1/generations/{generation_id}` to retrieve the result. If a<br/>
        /// `webhook_url` is supplied, the generated images are additionally POSTed<br/>
        /// to it once ready, in a payload that mirrors the synchronous response with<br/>
        /// an added generation_id for correlation.<br/>
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
        /// The prompt for image generation. Accepts either natural language or<br/>
        /// a structured Ideogram 4.0 JSON prompt; the server detects which was supplied.
        /// </param>
        /// <param name="promptUpsampling">
        /// Controls magic-prompt (prompt upsampling). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request.
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `MEDIUM`.<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="resolution">
        /// The output-size tier. Defaults to `1K`.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. Defaults to `1x1`.<br/>
        /// Default Value: 1x1
        /// </param>
        /// <param name="customWidth">
        /// Optional. An exact output width in pixels, used together with<br/>
        /// `custom_height` for output sizes outside the preset tiers. Must be<br/>
        /// a positive multiple of 16 between 16 and 4096, and<br/>
        /// `custom_width` × `custom_height` must not exceed 4,194,304 pixels<br/>
        /// (2048×2048). Cannot be combined with `resolution` or<br/>
        /// `aspect_ratio`; the request is billed at the resolution tier<br/>
        /// matching its total pixel count.
        /// </param>
        /// <param name="customHeight">
        /// Optional. An exact output height in pixels, used together with<br/>
        /// `custom_width`. See `custom_width` for the accepted range and<br/>
        /// billing behavior.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostGenerateImagePImageIdeogramAsyncAsync(
            string prompt,
            string? webhookUrl = default,
            global::Ideogram.MagicPromptOption? promptUpsampling = default,
            int? seed = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.Quality? quality = default,
            global::Ideogram.PImageResolution? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            int? customWidth = default,
            int? customHeight = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}