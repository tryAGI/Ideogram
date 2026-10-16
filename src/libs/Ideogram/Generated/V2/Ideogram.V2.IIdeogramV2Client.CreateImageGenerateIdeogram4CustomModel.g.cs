#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Generate with a custom Ideogram 4.0 model<br/>
        /// Generate images with a custom Ideogram 4.0 model that you or your<br/>
        /// organization can access, selected by `custom_model_uri`. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageIdeogramV4CustomModelResponse> CreateImageGenerateIdeogram4CustomModelAsync(

            global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with a custom Ideogram 4.0 model<br/>
        /// Generate images with a custom Ideogram 4.0 model that you or your<br/>
        /// organization can access, selected by `custom_model_uri`. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.GenerateImageIdeogramV4CustomModelResponse>> CreateImageGenerateIdeogram4CustomModelAsResponseAsync(

            global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with a custom Ideogram 4.0 model<br/>
        /// Generate images with a custom Ideogram 4.0 model that you or your<br/>
        /// organization can access, selected by `custom_model_uri`. Returns results<br/>
        /// directly by default; set `async` or supply a `webhook_url` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, in natural language or as a<br/>
        /// structured Ideogram 4.0 JSON prompt. A structured JSON prompt is<br/>
        /// used as is and skips magic prompt unless `magic_prompt` is `on`.
        /// </param>
        /// <param name="customModelUri">
        /// The custom model URI, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. You or your organization must have access to the model. The model determines which rendering speeds are supported.
        /// </param>
        /// <param name="transparentBackground">
        /// Remove the background after generation and return transparent PNG images. Included in the custom model generation price at no extra charge. When false, the model's automatic background removal behavior still applies.<br/>
        /// Default Value: false
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
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="resolution">
        /// Optional. When supplied, the images are generated at this<br/>
        /// resolution. When omitted, an aspect ratio is picked automatically<br/>
        /// based on the prompt.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, a speed supported by the custom model is used.
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.GenerateImageIdeogramV4CustomModelResponse> CreateImageGenerateIdeogram4CustomModelAsync(
            string prompt,
            string customModelUri,
            bool? dryRun = default,
            bool? transparentBackground = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? seed = default,
            int? numImages = default,
            global::Ideogram.V2.ResolutionV4? resolution = default,
            global::Ideogram.V2.GenerateImageIdeogramV4CustomModelRequestRenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}