#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate images with Ideogram 4.5 from a text or structured prompt<br/>
        /// Generate one or more images with Ideogram 4.5. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; the<br/>
        /// server detects which was supplied.<br/>
        /// `magic_prompt` controls automatic prompt rewriting: `AUTO` (the<br/>
        /// default) and `ON` rewrite a natural-language prompt, a prompt that is<br/>
        /// already a valid structured JSON prompt is always consumed directly,<br/>
        /// and `OFF` disables rewriting entirely so the model receives your<br/>
        /// prompt verbatim.<br/>
        /// Ideogram 4.5 renders a fixed set of output sizes. When `resolution`<br/>
        /// is omitted, the server picks a supported size automatically based on<br/>
        /// the prompt.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogram45Response> PostGenerateImageV2Ideogram45Async(

            global::Ideogram.GenerateImageIdeogram45Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with Ideogram 4.5 from a text or structured prompt<br/>
        /// Generate one or more images with Ideogram 4.5. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; the<br/>
        /// server detects which was supplied.<br/>
        /// `magic_prompt` controls automatic prompt rewriting: `AUTO` (the<br/>
        /// default) and `ON` rewrite a natural-language prompt, a prompt that is<br/>
        /// already a valid structured JSON prompt is always consumed directly,<br/>
        /// and `OFF` disables rewriting entirely so the model receives your<br/>
        /// prompt verbatim.<br/>
        /// Ideogram 4.5 renders a fixed set of output sizes. When `resolution`<br/>
        /// is omitted, the server picks a supported size automatically based on<br/>
        /// the prompt.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogram45Response>> PostGenerateImageV2Ideogram45AsResponseAsync(

            global::Ideogram.GenerateImageIdeogram45Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with Ideogram 4.5 from a text or structured prompt<br/>
        /// Generate one or more images with Ideogram 4.5. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; the<br/>
        /// server detects which was supplied.<br/>
        /// `magic_prompt` controls automatic prompt rewriting: `AUTO` (the<br/>
        /// default) and `ON` rewrite a natural-language prompt, a prompt that is<br/>
        /// already a valid structured JSON prompt is always consumed directly,<br/>
        /// and `OFF` disables rewriting entirely so the model receives your<br/>
        /// prompt verbatim.<br/>
        /// Ideogram 4.5 renders a fixed set of output sizes. When `resolution`<br/>
        /// is omitted, the server picks a supported size automatically based on<br/>
        /// the prompt.<br/>
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
        /// Controls magic prompt (automatic prompt rewriting). `AUTO` (the<br/>
        /// default) and `ON` rewrite a natural-language prompt, while a<br/>
        /// prompt that is already a valid structured JSON prompt is always<br/>
        /// consumed directly. `OFF` disables rewriting entirely: the model<br/>
        /// receives your prompt verbatim.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="resolution">
        /// Exact output resolution, formatted as "WIDTHxHEIGHT". Ideogram 4.5 renders a fixed set of sizes across 1K and 2K tiers (for example 1024x1024, 2048x2048 or 1440x2880); an unsupported size is rejected with a 400. When omitted, the server picks a supported size automatically based on the prompt.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
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
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogram45Response> PostGenerateImageV2Ideogram45Async(
            string prompt,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? resolution = default,
            global::Ideogram.GenerateImageIdeogram45RequestRenderingSpeed? renderingSpeed = default,
            int? seed = default,
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