#nullable enable

namespace Ideogram
{
    public partial interface IImagesUpscaleClient
    {
        /// <summary>
        /// Upscale an image with Gemini 3 Pro, by asset id or by uploaded bytes<br/>
        /// Regenerate the source image at a higher resolution tier (1K, 2K, or<br/>
        /// 4K) while preserving its content, composition, and style. Supply the<br/>
        /// source either as an `image_asset_identifier` reference (an image<br/>
        /// already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only) — callers are never required to upload the asset<br/>
        /// first. If both are supplied, the reference wins and the bytes are<br/>
        /// ignored. Uploaded bytes are used for this request only and are not<br/>
        /// stored as an asset; upscales of a referenced asset keep a visible<br/>
        /// link to their source image.<br/>
        /// An optional `prompt` adds short guidance for the enhancement; the<br/>
        /// image is otherwise upscaled as-is. The source must be smaller than<br/>
        /// the requested `resolution_tier`.<br/>
        /// By default the request blocks until the upscaled image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.UpscaleImageGemini3ProResponse> PostUpscaleImageGemini3ProAsync(

            global::Ideogram.UpscaleImageGemini3ProRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale an image with Gemini 3 Pro, by asset id or by uploaded bytes<br/>
        /// Regenerate the source image at a higher resolution tier (1K, 2K, or<br/>
        /// 4K) while preserving its content, composition, and style. Supply the<br/>
        /// source either as an `image_asset_identifier` reference (an image<br/>
        /// already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only) — callers are never required to upload the asset<br/>
        /// first. If both are supplied, the reference wins and the bytes are<br/>
        /// ignored. Uploaded bytes are used for this request only and are not<br/>
        /// stored as an asset; upscales of a referenced asset keep a visible<br/>
        /// link to their source image.<br/>
        /// An optional `prompt` adds short guidance for the enhancement; the<br/>
        /// image is otherwise upscaled as-is. The source must be smaller than<br/>
        /// the requested `resolution_tier`.<br/>
        /// By default the request blocks until the upscaled image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.UpscaleImageGemini3ProResponse>> PostUpscaleImageGemini3ProAsResponseAsync(

            global::Ideogram.UpscaleImageGemini3ProRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale an image with Gemini 3 Pro, by asset id or by uploaded bytes<br/>
        /// Regenerate the source image at a higher resolution tier (1K, 2K, or<br/>
        /// 4K) while preserving its content, composition, and style. Supply the<br/>
        /// source either as an `image_asset_identifier` reference (an image<br/>
        /// already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only) — callers are never required to upload the asset<br/>
        /// first. If both are supplied, the reference wins and the bytes are<br/>
        /// ignored. Uploaded bytes are used for this request only and are not<br/>
        /// stored as an asset; upscales of a referenced asset keep a visible<br/>
        /// link to their source image.<br/>
        /// An optional `prompt` adds short guidance for the enhancement; the<br/>
        /// image is otherwise upscaled as-is. The source must be smaller than<br/>
        /// the requested `resolution_tier`.<br/>
        /// By default the request blocks until the upscaled image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to upscale (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="imagename">
        /// The source image to upscale (max size 50MB), as raw bytes; only common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied. The bytes are used for this request only and are not stored as an asset.
        /// </param>
        /// <param name="prompt">
        /// Optional short guidance for the enhancement, appended to the model's upscaling instruction. When omitted, the image is upscaled as-is.
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. The model sizes its output by tier at the source image's aspect ratio; exact pixel dimensions cannot be requested. Rejected when the source is already at or above the requested tier. Defaults to "2K".<br/>
        /// Default Value: 2K
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="async">
        /// When false (the default), the request blocks until the upscaled image is ready and returns it in `data`. When true, the request returns as soon as it is accepted; poll for completion and results with `GET /v1/generations/{generation_id}` using the returned `generation_id`.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.UpscaleImageGemini3ProResponse> PostUpscaleImageGemini3ProAsync(
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            string? prompt = default,
            global::Ideogram.UpscaleImageGemini3ProRequestResolutionTier? resolutionTier = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}