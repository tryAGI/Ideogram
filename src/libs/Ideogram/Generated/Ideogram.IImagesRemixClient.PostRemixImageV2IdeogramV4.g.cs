#nullable enable

namespace Ideogram
{
    public partial interface IImagesRemixClient
    {
        /// <summary>
        /// Remix an existing image with Ideogram 4.0, guided by a prompt<br/>
        /// Transform an existing image with Ideogram 4.0, guided by a text<br/>
        /// prompt. Supply the source either as an `image_asset_identifier`<br/>
        /// reference (an image already stored with Ideogram) or as raw `image`<br/>
        /// bytes (multipart requests only). Supplying both is rejected rather<br/>
        /// than one being ignored. `image_weight` controls how closely the<br/>
        /// result follows the source; when omitted the server picks a value from<br/>
        /// your prompt.<br/>
        /// Omit `resolution` to keep the source image's shape.<br/>
        /// The prompt is always interpreted by an instruction-editing model, so<br/>
        /// there is no `magic_prompt` option. Remixes are not reproducible, so<br/>
        /// no seed is accepted; the response reports the seed the request<br/>
        /// resolved to.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV4Response> PostRemixImageV2IdeogramV4Async(

            global::Ideogram.RemixImageIdeogramV4Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix an existing image with Ideogram 4.0, guided by a prompt<br/>
        /// Transform an existing image with Ideogram 4.0, guided by a text<br/>
        /// prompt. Supply the source either as an `image_asset_identifier`<br/>
        /// reference (an image already stored with Ideogram) or as raw `image`<br/>
        /// bytes (multipart requests only). Supplying both is rejected rather<br/>
        /// than one being ignored. `image_weight` controls how closely the<br/>
        /// result follows the source; when omitted the server picks a value from<br/>
        /// your prompt.<br/>
        /// Omit `resolution` to keep the source image's shape.<br/>
        /// The prompt is always interpreted by an instruction-editing model, so<br/>
        /// there is no `magic_prompt` option. Remixes are not reproducible, so<br/>
        /// no seed is accepted; the response reports the seed the request<br/>
        /// resolved to.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemixImageIdeogramV4Response>> PostRemixImageV2IdeogramV4AsResponseAsync(

            global::Ideogram.RemixImageIdeogramV4Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix an existing image with Ideogram 4.0, guided by a prompt<br/>
        /// Transform an existing image with Ideogram 4.0, guided by a text<br/>
        /// prompt. Supply the source either as an `image_asset_identifier`<br/>
        /// reference (an image already stored with Ideogram) or as raw `image`<br/>
        /// bytes (multipart requests only). Supplying both is rejected rather<br/>
        /// than one being ignored. `image_weight` controls how closely the<br/>
        /// result follows the source; when omitted the server picks a value from<br/>
        /// your prompt.<br/>
        /// Omit `resolution` to keep the source image's shape.<br/>
        /// The prompt is always interpreted by an instruction-editing model, so<br/>
        /// there is no `magic_prompt` option. Remixes are not reproducible, so<br/>
        /// no seed is accepted; the response reports the seed the request<br/>
        /// resolved to.<br/>
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
        /// The prompt that guides the remix.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The existing upload or generated image to transform. Supply this or `image`, never both. Omit `resolution` to keep its shape.
        /// </param>
        /// <param name="image">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are stored as a new image asset in your account, since the remix keeps a durable link to its source image.
        /// </param>
        /// <param name="imagename">
        /// The image to transform (max size 50MB), as raw bytes; only JPEG, PNG and WEBP are supported. Multipart requests only. Supply this or `image_asset_identifier`, never both. The bytes are stored as a new image asset in your account, since the remix keeps a durable link to its source image.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How closely the result should follow the source image, from 1 to 100. When omitted the server chooses a value from your prompt, which is the usual case.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="resolution">
        /// Optional. When supplied, the images are generated at this<br/>
        /// resolution. When omitted, the source image's shape is kept.
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
        global::System.Threading.Tasks.Task<global::Ideogram.RemixImageIdeogramV4Response> PostRemixImageV2IdeogramV4Async(
            string prompt,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? imageWeight = default,
            int? numImages = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RemixImageIdeogramV4RequestRenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}