#nullable enable

namespace Ideogram
{
    public partial interface IImagesReframeClient
    {
        /// <summary>
        /// Reframe an image with Nano Banana Pro<br/>
        /// Recompose one image for a new aspect ratio with Nano Banana Pro, at a<br/>
        /// 1K, 2K, or 4K output tier. Supply either an existing Ideogram image<br/>
        /// asset or raw image bytes, but not both. The requested aspect ratio is<br/>
        /// resolved to the closest dimensions the model supports at that tier.<br/>
        /// This operation is asynchronous. It returns as soon as the request is<br/>
        /// accepted; poll `GET /v2/generations/{generation_id}` for completion<br/>
        /// and results.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageNanoBananaProResponse> NanoBananaProAsync(

            global::Ideogram.ReframeImageNanoBananaProRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Nano Banana Pro<br/>
        /// Recompose one image for a new aspect ratio with Nano Banana Pro, at a<br/>
        /// 1K, 2K, or 4K output tier. Supply either an existing Ideogram image<br/>
        /// asset or raw image bytes, but not both. The requested aspect ratio is<br/>
        /// resolved to the closest dimensions the model supports at that tier.<br/>
        /// This operation is asynchronous. It returns as soon as the request is<br/>
        /// accepted; poll `GET /v2/generations/{generation_id}` for completion<br/>
        /// and results.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageNanoBananaProResponse>> NanoBananaProAsResponseAsync(

            global::Ideogram.ReframeImageNanoBananaProRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Nano Banana Pro<br/>
        /// Recompose one image for a new aspect ratio with Nano Banana Pro, at a<br/>
        /// 1K, 2K, or 4K output tier. Supply either an existing Ideogram image<br/>
        /// asset or raw image bytes, but not both. The requested aspect ratio is<br/>
        /// resolved to the closest dimensions the model supports at that tier.<br/>
        /// This operation is asynchronous. It returns as soon as the request is<br/>
        /// accepted; poll `GET /v2/generations/{generation_id}` for completion<br/>
        /// and results.
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
        /// The requested output aspect ratio, as `width:height`.<br/>
        /// Example: 969
        /// </param>
        /// <param name="resolutionTier">
        /// The output resolution tier. The model sizes its output by tier at the requested aspect ratio; exact pixel dimensions cannot be requested.<br/>
        /// Default Value: 1K
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageNanoBananaProResponse> NanoBananaProAsync(
            string aspectRatio,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.ReframeImageNanoBananaProRequestResolutionTier? resolutionTier = default,
            bool? @private = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}