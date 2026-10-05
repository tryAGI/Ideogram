#nullable enable

namespace Ideogram
{
    public partial interface IImagesReframeClient
    {
        /// <summary>
        /// Reframe with Nano Banana 2<br/>
        /// Expand an image to a new aspect ratio with Nano Banana 2. Upload the<br/>
        /// source `image` using `multipart/form-data`. Always asynchronous:<br/>
        /// returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// for results.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageNanoBanana2Response> NanoBanana2Async(

            global::Ideogram.ReframeImageNanoBanana2Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe with Nano Banana 2<br/>
        /// Expand an image to a new aspect ratio with Nano Banana 2. Upload the<br/>
        /// source `image` using `multipart/form-data`. Always asynchronous:<br/>
        /// returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// for results.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageNanoBanana2Response>> NanoBanana2AsResponseAsync(

            global::Ideogram.ReframeImageNanoBanana2Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe with Nano Banana 2<br/>
        /// Expand an image to a new aspect ratio with Nano Banana 2. Upload the<br/>
        /// source `image` using `multipart/form-data`. Always asynchronous:<br/>
        /// returns a `generation_id`; poll `GET /v2/generations/{generation_id}`<br/>
        /// for results.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 50MB).
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 50MB).
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratios Nano Banana 2 can reframe an image to.
        /// </param>
        /// <param name="private">
        /// API-key requests are always private. For bearer-authenticated<br/>
        /// requests, this controls whether the result is private; when<br/>
        /// omitted, it follows the caller's plan entitlement. Enterprise<br/>
        /// generations are always private.
        /// </param>
        /// <param name="numImages">
        /// The number of output images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageNanoBanana2Response> NanoBanana2Async(
            global::Ideogram.NanoBanana2ReframeAspectRatio aspectRatio,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            bool? @private = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}