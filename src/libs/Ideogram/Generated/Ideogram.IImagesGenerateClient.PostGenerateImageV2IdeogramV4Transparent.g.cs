#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate transparent-background images with Ideogram 4.0<br/>
        /// Generate one or more images on a transparent background with<br/>
        /// Ideogram 4.0, delivered as PNGs with alpha. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; a<br/>
        /// structured prompt is consumed directly and skips magic prompt, except<br/>
        /// that its background description is replaced with a<br/>
        /// transparent-background directive.<br/>
        /// `magic_prompt` controls how a natural-language prompt is prepared:<br/>
        /// `AUTO`/`ON` rewrite and expand the prompt before generation, while<br/>
        /// `OFF` keeps your wording and only converts the prompt into the<br/>
        /// structured format the model consumes.<br/>
        /// `output_resolution` selects the output tier (1K to 8K); tiers above<br/>
        /// 2K are produced by upscaling after generation.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV4TransparentResponse> PostGenerateImageV2IdeogramV4TransparentAsync(

            global::Ideogram.GenerateImageIdeogramV4TransparentRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate transparent-background images with Ideogram 4.0<br/>
        /// Generate one or more images on a transparent background with<br/>
        /// Ideogram 4.0, delivered as PNGs with alpha. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; a<br/>
        /// structured prompt is consumed directly and skips magic prompt, except<br/>
        /// that its background description is replaced with a<br/>
        /// transparent-background directive.<br/>
        /// `magic_prompt` controls how a natural-language prompt is prepared:<br/>
        /// `AUTO`/`ON` rewrite and expand the prompt before generation, while<br/>
        /// `OFF` keeps your wording and only converts the prompt into the<br/>
        /// structured format the model consumes.<br/>
        /// `output_resolution` selects the output tier (1K to 8K); tiers above<br/>
        /// 2K are produced by upscaling after generation.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogramV4TransparentResponse>> PostGenerateImageV2IdeogramV4TransparentAsResponseAsync(

            global::Ideogram.GenerateImageIdeogramV4TransparentRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate transparent-background images with Ideogram 4.0<br/>
        /// Generate one or more images on a transparent background with<br/>
        /// Ideogram 4.0, delivered as PNGs with alpha. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; a<br/>
        /// structured prompt is consumed directly and skips magic prompt, except<br/>
        /// that its background description is replaced with a<br/>
        /// transparent-background directive.<br/>
        /// `magic_prompt` controls how a natural-language prompt is prepared:<br/>
        /// `AUTO`/`ON` rewrite and expand the prompt before generation, while<br/>
        /// `OFF` keeps your wording and only converts the prompt into the<br/>
        /// structured format the model consumes.<br/>
        /// `output_resolution` selects the output tier (1K to 8K); tiers above<br/>
        /// 2K are produced by upscaling after generation.<br/>
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
        /// detects which was supplied. A structured JSON prompt is consumed<br/>
        /// by the model directly and skips magic prompt, except that its<br/>
        /// background description is replaced with a transparent-background<br/>
        /// directive.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `AUTO` (the<br/>
        /// default) and `ON` rewrite and expand the prompt before<br/>
        /// generation. `OFF` keeps your wording and only converts the prompt<br/>
        /// into the structured format the model consumes. A prompt that is<br/>
        /// already a valid structured JSON prompt skips magic prompt<br/>
        /// entirely unless `magic_prompt` is `ON`.<br/>
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
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 4.0 magic prompt. `AUTO` lets the<br/>
        /// model select the most suitable ratio from the prompt; any other value<br/>
        /// pins the ratio. The non-AUTO values are the buckets the 4.0 model<br/>
        /// supports.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution tier for the generated images. Tiers are<br/>
        /// total-pixel budgets matching a square of the named size (for<br/>
        /// example, `8K` delivers at most 8192x8192 total pixels); wide and<br/>
        /// tall aspect ratios keep the same pixel budget, so a single<br/>
        /// dimension may exceed the named size. Defaults to 1K.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogramV4TransparentResponse> PostGenerateImageV2IdeogramV4TransparentAsync(
            string prompt,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? seed = default,
            int? numImages = default,
            global::Ideogram.AspectRatioV4? aspectRatio = default,
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