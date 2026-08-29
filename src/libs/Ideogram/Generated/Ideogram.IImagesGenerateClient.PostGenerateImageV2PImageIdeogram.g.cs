#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate images with P-Image Ideogram from a text or structured prompt<br/>
        /// Generate one or more images with P-Image Ideogram, a fast model with<br/>
        /// selectable quality and resolution tiers. The `prompt` accepts either<br/>
        /// natural language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImagePImageIdeogramResponse> PostGenerateImageV2PImageIdeogramAsync(

            global::Ideogram.GenerateImagePImageIdeogramRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with P-Image Ideogram from a text or structured prompt<br/>
        /// Generate one or more images with P-Image Ideogram, a fast model with<br/>
        /// selectable quality and resolution tiers. The `prompt` accepts either<br/>
        /// natural language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImagePImageIdeogramResponse>> PostGenerateImageV2PImageIdeogramAsResponseAsync(

            global::Ideogram.GenerateImagePImageIdeogramRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with P-Image Ideogram from a text or structured prompt<br/>
        /// Generate one or more images with P-Image Ideogram, a fast model with<br/>
        /// selectable quality and resolution tiers. The `prompt` accepts either<br/>
        /// natural language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately after the<br/>
        /// request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate images from. Accepts either natural<br/>
        /// language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). `OFF` disables magic prompt entirely. Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
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
        /// The generation quality level. Defaults to `MEDIUM`.<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="resolution">
        /// The output-size tier; the server defaults to `1K` when omitted. Cannot be combined with `custom_width`/`custom_height`.
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
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images come back with `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the images are ready and returns them in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? seed = default,
            int? numImages = default,
            global::Ideogram.Quality? quality = default,
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