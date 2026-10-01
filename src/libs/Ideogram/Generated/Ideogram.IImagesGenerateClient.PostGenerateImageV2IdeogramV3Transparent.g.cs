#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate transparent images with Ideogram 3.0<br/>
        /// Generate images on a transparent background with Ideogram 3.0, delivered<br/>
        /// as PNGs with alpha. Returns results directly by default; set `async` or<br/>
        /// supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV3TransparentResponse> PostGenerateImageV2IdeogramV3TransparentAsync(

            global::Ideogram.GenerateImageIdeogramV3TransparentRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate transparent images with Ideogram 3.0<br/>
        /// Generate images on a transparent background with Ideogram 3.0, delivered<br/>
        /// as PNGs with alpha. Returns results directly by default; set `async` or<br/>
        /// supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogramV3TransparentResponse>> PostGenerateImageV2IdeogramV3TransparentAsResponseAsync(

            global::Ideogram.GenerateImageIdeogramV3TransparentRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate transparent images with Ideogram 3.0<br/>
        /// Generate images on a transparent background with Ideogram 3.0, delivered<br/>
        /// as PNGs with alpha. Returns results directly by default; set `async` or<br/>
        /// supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from.
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from the images. The prompt takes precedence over the negative prompt.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="upscaleFactor">
        /// Optional enhancement factor applied after generation. `x1` (the default) delivers the base render.<br/>
        /// Default Value: x1
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 3.x or 2.x generation. `auto` lets the<br/>
        /// model select a ratio from the prompt; any other value pins the ratio.<br/>
        /// Cannot be combined with `resolution`. Omitting the field is not `auto`:<br/>
        /// it uses `1x1`.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Run copyright detection on the generated images. Adds latency; flagged images are returned with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </param>
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
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. The output images are added to it when the request completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV3TransparentResponse> PostGenerateImageV2IdeogramV3TransparentAsync(
            string prompt,
            bool? dryRun = default,
            string? negativePrompt = default,
            int? seed = default,
            global::Ideogram.GenerateImageIdeogramV3TransparentRequestUpscaleFactor? upscaleFactor = default,
            global::Ideogram.IdeogramV3AspectRatio? aspectRatio = default,
            global::Ideogram.GenerateImageIdeogramV3TransparentRequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}