#nullable enable

namespace Ideogram
{
    public partial interface IImagesUpscaleClient
    {
        /// <summary>
        /// Upscale an image with Topaz Text Refine, by asset id or by uploaded bytes<br/>
        /// Upscale one image to 2x, 4x, or 8x its original resolution, up to a<br/>
        /// maximum output of 8192px per side. Supply the source either as an<br/>
        /// `image_asset_identifier` reference (an image already stored with<br/>
        /// Ideogram) or as raw `image` bytes (multipart requests only) — callers<br/>
        /// are never required to upload the asset first. If both are supplied,<br/>
        /// the reference wins and the bytes are ignored. Uploaded bytes are used<br/>
        /// for this request only and are not stored as an asset; upscales of a<br/>
        /// referenced asset keep a visible link to their source image.<br/>
        /// Upscaling takes no prompt: the model enhances the source image as-is.<br/>
        /// By default the request blocks until the upscaled image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.UpscaleImageTopazTextRefineResponse> PostUpscaleImageTopazTextRefineAsync(

            global::Ideogram.UpscaleImageTopazTextRefineRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale an image with Topaz Text Refine, by asset id or by uploaded bytes<br/>
        /// Upscale one image to 2x, 4x, or 8x its original resolution, up to a<br/>
        /// maximum output of 8192px per side. Supply the source either as an<br/>
        /// `image_asset_identifier` reference (an image already stored with<br/>
        /// Ideogram) or as raw `image` bytes (multipart requests only) — callers<br/>
        /// are never required to upload the asset first. If both are supplied,<br/>
        /// the reference wins and the bytes are ignored. Uploaded bytes are used<br/>
        /// for this request only and are not stored as an asset; upscales of a<br/>
        /// referenced asset keep a visible link to their source image.<br/>
        /// Upscaling takes no prompt: the model enhances the source image as-is.<br/>
        /// By default the request blocks until the upscaled image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.UpscaleImageTopazTextRefineResponse>> PostUpscaleImageTopazTextRefineAsResponseAsync(

            global::Ideogram.UpscaleImageTopazTextRefineRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upscale an image with Topaz Text Refine, by asset id or by uploaded bytes<br/>
        /// Upscale one image to 2x, 4x, or 8x its original resolution, up to a<br/>
        /// maximum output of 8192px per side. Supply the source either as an<br/>
        /// `image_asset_identifier` reference (an image already stored with<br/>
        /// Ideogram) or as raw `image` bytes (multipart requests only) — callers<br/>
        /// are never required to upload the asset first. If both are supplied,<br/>
        /// the reference wins and the bytes are ignored. Uploaded bytes are used<br/>
        /// for this request only and are not stored as an asset; upscales of a<br/>
        /// referenced asset keep a visible link to their source image.<br/>
        /// Upscaling takes no prompt: the model enhances the source image as-is.<br/>
        /// By default the request blocks until the upscaled image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll for completion and results with<br/>
        /// `GET /v1/generations/{generation_id}` using the returned<br/>
        /// `generation_id`.<br/>
        /// Supplying a `webhook_url` makes the request asynchronous whatever<br/>
        /// `async` says: the response returns as soon as the request is accepted,<br/>
        /// and the finished result is POSTed to that URL.
        /// </summary>
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
        /// <param name="upscaleFactor">
        /// How much to enlarge the source image: 2x, 4x, or 8x its original width and height. Rejected when the output would exceed 8192px on either side.<br/>
        /// Default Value: X2
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
        global::System.Threading.Tasks.Task<global::Ideogram.UpscaleImageTopazTextRefineResponse> PostUpscaleImageTopazTextRefineAsync(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.UpscaleImageTopazTextRefineRequestUpscaleFactor? upscaleFactor = default,
            int? seed = default,
            bool? async = default,
            string? webhookUrl = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}