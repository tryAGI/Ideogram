#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate transparent images with Ideogram 4.0<br/>
        /// Generate images on a transparent background with Ideogram 4.0, delivered<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV4TransparentResponse> PostGenerateImageV2IdeogramV4TransparentAsync(

            global::Ideogram.GenerateImageIdeogramV4TransparentRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate transparent images with Ideogram 4.0<br/>
        /// Generate images on a transparent background with Ideogram 4.0, delivered<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogramV4TransparentResponse>> PostGenerateImageV2IdeogramV4TransparentAsResponseAsync(

            global::Ideogram.GenerateImageIdeogramV4TransparentRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate transparent images with Ideogram 4.0<br/>
        /// Generate images on a transparent background with Ideogram 4.0, delivered<br/>
        /// as PNGs with alpha. Returns results directly by default; set `async` or<br/>
        /// supply a `webhook_url` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt. A structured JSON prompt is<br/>
        /// used as is and skips magic prompt, except that its background<br/>
        /// description is replaced with a transparent background.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before generation.<br/>
        /// `off` keeps your wording and only converts it into a structured<br/>
        /// prompt. A valid structured JSON prompt skips magic prompt unless<br/>
        /// `magic_prompt` is `on`.<br/>
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
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 4.0 magic prompt. `auto` lets the<br/>
        /// model select the most suitable ratio from the prompt; any other value<br/>
        /// pins the ratio. The non-auto values are the buckets the 4.0 model<br/>
        /// supports.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution tier. Each tier is a total pixel budget equal<br/>
        /// to a square of the named size (for example, `8k` delivers at most<br/>
        /// 8192x8192 pixels in total). Wide and tall aspect ratios keep the<br/>
        /// same budget, so one side may exceed the named size. Tiers above<br/>
        /// 2k are produced by upscaling after generation. Defaults to 1k.<br/>
        /// Default Value: 1k
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV4TransparentResponse> PostGenerateImageV2IdeogramV4TransparentAsync(
            string prompt,
            bool? dryRun = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? seed = default,
            int? numImages = default,
            global::Ideogram.IdeogramV4AspectRatio? aspectRatio = default,
            global::Ideogram.GenerateImageIdeogramV4TransparentRequestOutputResolution? outputResolution = default,
            global::Ideogram.GenerateImageIdeogramV4TransparentRequestRenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}