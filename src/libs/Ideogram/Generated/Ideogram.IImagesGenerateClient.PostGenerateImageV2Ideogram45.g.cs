#nullable enable

namespace Ideogram
{
    public partial interface IImagesGenerateClient
    {
        /// <summary>
        /// Generate images with Ideogram 4.5, from a prompt or by transforming source images<br/>
        /// Generate one or more images with Ideogram 4.5. Supplying source<br/>
        /// images turns the request into an image-to-image transform: the model<br/>
        /// conditions on the sources, the prompt becomes optional guidance, and<br/>
        /// `size` may be "auto" to derive the output from the first source.<br/>
        /// Provide sources either as `image_asset_identifiers` references or as<br/>
        /// raw `images` bytes (multipart requests only); if both are supplied,<br/>
        /// the references win and the bytes are ignored. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; the<br/>
        /// server detects which was supplied.<br/>
        /// `magic_prompt` controls automatic prompt rewriting: `auto` (the<br/>
        /// default) and `on` rewrite a natural-language prompt, a prompt that is<br/>
        /// already a valid structured JSON prompt is always consumed directly,<br/>
        /// and `off` disables rewriting entirely so the model receives your<br/>
        /// prompt verbatim.<br/>
        /// Ideogram 4.5 renders a fixed set of output sizes. When `size`<br/>
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
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageIdeogram45Response> PostGenerateImageV2Ideogram45Async(

            global::Ideogram.GenerateImageIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with Ideogram 4.5, from a prompt or by transforming source images<br/>
        /// Generate one or more images with Ideogram 4.5. Supplying source<br/>
        /// images turns the request into an image-to-image transform: the model<br/>
        /// conditions on the sources, the prompt becomes optional guidance, and<br/>
        /// `size` may be "auto" to derive the output from the first source.<br/>
        /// Provide sources either as `image_asset_identifiers` references or as<br/>
        /// raw `images` bytes (multipart requests only); if both are supplied,<br/>
        /// the references win and the bytes are ignored. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; the<br/>
        /// server detects which was supplied.<br/>
        /// `magic_prompt` controls automatic prompt rewriting: `auto` (the<br/>
        /// default) and `on` rewrite a natural-language prompt, a prompt that is<br/>
        /// already a valid structured JSON prompt is always consumed directly,<br/>
        /// and `off` disables rewriting entirely so the model receives your<br/>
        /// prompt verbatim.<br/>
        /// Ideogram 4.5 renders a fixed set of output sizes. When `size`<br/>
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
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GenerateImageIdeogram45Response>> PostGenerateImageV2Ideogram45AsResponseAsync(

            global::Ideogram.GenerateImageIdeogram45Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate images with Ideogram 4.5, from a prompt or by transforming source images<br/>
        /// Generate one or more images with Ideogram 4.5. Supplying source<br/>
        /// images turns the request into an image-to-image transform: the model<br/>
        /// conditions on the sources, the prompt becomes optional guidance, and<br/>
        /// `size` may be "auto" to derive the output from the first source.<br/>
        /// Provide sources either as `image_asset_identifiers` references or as<br/>
        /// raw `images` bytes (multipart requests only); if both are supplied,<br/>
        /// the references win and the bytes are ignored. The `prompt` accepts<br/>
        /// either natural language or a structured Ideogram 4.0 JSON prompt; the<br/>
        /// server detects which was supplied.<br/>
        /// `magic_prompt` controls automatic prompt rewriting: `auto` (the<br/>
        /// default) and `on` rewrite a natural-language prompt, a prompt that is<br/>
        /// already a valid structured JSON prompt is always consumed directly,<br/>
        /// and `off` disables rewriting entirely so the model receives your<br/>
        /// prompt verbatim.<br/>
        /// Ideogram 4.5 renders a fixed set of output sizes. When `size`<br/>
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
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to generate images from, or the edit instruction to<br/>
        /// apply when source images are supplied. Accepts either natural<br/>
        /// language or a structured Ideogram 4.0 JSON prompt; the server<br/>
        /// detects which was supplied.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls how a natural-language prompt is prepared. `auto` (the<br/>
        /// default) and `on` rewrite and expand the prompt before<br/>
        /// generation. `off` keeps your wording and only converts the prompt<br/>
        /// into the structured format the model consumes. A prompt that is<br/>
        /// already a valid structured JSON prompt skips magic prompt<br/>
        /// entirely unless `magic_prompt` is `on`. With source images the<br/>
        /// prompt is an edit instruction, and every mode converts it into<br/>
        /// the structured edit contract the model consumes.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="imageAssetIdentifiers">
        /// Existing upload or generated image assets to transform, by reference. Takes priority over `images` if both are supplied. The first source is the primary image; any further sources are additional references. Supplying sources turns the request into an image-to-image transform.
        /// </param>
        /// <param name="images">
        /// The source images to transform (max 5, max size 25MB per image), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifiers` is also supplied.
        /// </param>
        /// <param name="mask">
        /// An optional mask confining the edit to part of the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as the first source image, and must contain both black and white areas. Requires source images uploaded as raw `images` bytes; masks cannot be combined with `image_asset_identifiers`. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three other source images. Supplying a mask fixes the output to the first source's own size, so `size` is rejected alongside it.
        /// </param>
        /// <param name="maskname">
        /// An optional mask confining the edit to part of the first source image, as raw bytes (multipart requests only; JPEG, PNG, or WEBP, max 25MB). Black marks the area to edit and white the area to preserve; values in between are rounded to whichever is nearer. The mask must have the same width and height as the first source image, and must contain both black and white areas. Requires source images uploaded as raw `images` bytes; masks cannot be combined with `image_asset_identifiers`. The mask is supplied to the model as an additional reference image, so a masked request may carry at most three other source images. Supplying a mask fixes the output to the first source's own size, so `size` is rejected alongside it.
        /// </param>
        /// <param name="size">
        /// The output size: "auto" or an exact "WIDTHxHEIGHT".<br/>
        /// Without source images, an exact size must be one of the supported<br/>
        /// 1K/2K presets (for example 1024x1024, 2048x2048 or 1440x2880);<br/>
        /// "auto" or omitted lets the server pick a supported size based on<br/>
        /// the prompt.<br/>
        /// With source images, "auto" (the default) returns the output at the<br/>
        /// first source image's own width and height. A source too large for<br/>
        /// the model is scaled down to fit while keeping its exact proportion,<br/>
        /// and a source whose aspect ratio is outside 1:6 to 6:1 is rejected,<br/>
        /// because serving it would mean reshaping an image you did not ask to<br/>
        /// reshape — name an exact size if that is what you want.<br/>
        /// An exact size must have both dimensions multiples of 32 and at least<br/>
        /// 256px, the total size at most 2048x2048 pixels, and the aspect ratio<br/>
        /// at most 6:1. Naming one reshapes the source to it.<br/>
        /// Pricing is tiered by the resolved output pixels: up to 1024x1024<br/>
        /// bills as 1K, above that as 2K.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: default
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
            bool? dryRun = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? imageAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            byte[]? mask = default,
            string? maskname = default,
            string? size = default,
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