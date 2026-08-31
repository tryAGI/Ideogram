#nullable enable

namespace Ideogram
{
    public partial interface IImagesReframeClient
    {
        /// <summary>
        /// Reframe an image with Gemini 3.1 Flash Image<br/>
        /// Expand one image to a new aspect ratio with Gemini 3.1 Flash Image.<br/>
        /// Supply either an existing Ideogram image asset or raw image bytes,<br/>
        /// but not both. The requested aspect ratio is resolved to the closest<br/>
        /// supported 1K output dimensions.<br/>
        /// This operation is asynchronous. It returns as soon as the request is<br/>
        /// accepted; poll `GET /v1/generations/{generation_id}` for completion<br/>
        /// and results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageGemini31FlashImageResponse> Gemini31FlashImageAsync(

            global::Ideogram.ReframeImageGemini31FlashImageRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Gemini 3.1 Flash Image<br/>
        /// Expand one image to a new aspect ratio with Gemini 3.1 Flash Image.<br/>
        /// Supply either an existing Ideogram image asset or raw image bytes,<br/>
        /// but not both. The requested aspect ratio is resolved to the closest<br/>
        /// supported 1K output dimensions.<br/>
        /// This operation is asynchronous. It returns as soon as the request is<br/>
        /// accepted; poll `GET /v1/generations/{generation_id}` for completion<br/>
        /// and results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageGemini31FlashImageResponse>> Gemini31FlashImageAsResponseAsync(

            global::Ideogram.ReframeImageGemini31FlashImageRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Gemini 3.1 Flash Image<br/>
        /// Expand one image to a new aspect ratio with Gemini 3.1 Flash Image.<br/>
        /// Supply either an existing Ideogram image asset or raw image bytes,<br/>
        /// but not both. The requested aspect ratio is resolved to the closest<br/>
        /// supported 1K output dimensions.<br/>
        /// This operation is asynchronous. It returns as soon as the request is<br/>
        /// accepted; poll `GET /v1/generations/{generation_id}` for completion<br/>
        /// and results.
        /// </summary>
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
        /// The requested output aspect ratio. It resolves to the closest dimensions Gemini supports at the 1K output tier.<br/>
        /// Example: 969
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageGemini31FlashImageResponse> Gemini31FlashImageAsync(
            string aspectRatio,
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