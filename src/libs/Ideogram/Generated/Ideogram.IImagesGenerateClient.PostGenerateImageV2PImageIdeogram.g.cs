#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate with P-Image Ideogram<br/>
        /// Generate images with P-Image Ideogram, a fast model with selectable<br/>
        /// quality and resolution tiers. Returns results directly by default; set<br/>
        /// `async` or supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImagePImageIdeogramResponse> PostGenerateImageV2PImageIdeogramAsync(

            global::Ideogram.GenerateImagePImageIdeogramRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with P-Image Ideogram<br/>
        /// Generate images with P-Image Ideogram, a fast model with selectable<br/>
        /// quality and resolution tiers. Returns results directly by default; set<br/>
        /// `async` or supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImagePImageIdeogramResponse>> PostGenerateImageV2PImageIdeogramAsResponseAsync(

            global::Ideogram.GenerateImagePImageIdeogramRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with P-Image Ideogram<br/>
        /// Generate images with P-Image Ideogram, a fast model with selectable<br/>
        /// quality and resolution tiers. Returns results directly by default; set<br/>
        /// `async` or supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). `off` disables magic prompt entirely. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `medium`.<br/>
        /// Default Value: medium
        /// </param>
        /// <param name="resolution">
        /// The output size tier. Defaults to `1k`. Cannot be combined with `custom_width`/`custom_height`.
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. Defaults to `1x1`.<br/>
        /// Default Value: 1x1
        /// </param>
        /// <param name="customWidth">
        /// Optional. An exact output width in pixels, used together with<br/>
        /// `custom_height` for output sizes outside the preset tiers. Must<br/>
        /// be a positive multiple of 16 between 16 and 4096, and<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImagePImageIdeogramResponse> PostGenerateImageV2PImageIdeogramAsync(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? seed = default,
            int? numImages = default,
            global::Ideogram.GenerationQuality? quality = default,
            global::Ideogram.GenerateImagePImageIdeogramRequestResolution? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            int? customWidth = default,
            int? customHeight = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}