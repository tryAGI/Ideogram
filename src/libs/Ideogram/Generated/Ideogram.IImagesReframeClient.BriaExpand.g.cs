#nullable enable

namespace Ideogram
{
    public partial interface IImagesReframeClient
    {
        /// <summary>
        /// Reframe an image with Bria Expand<br/>
        /// Extend one image to a new aspect ratio with Bria Expand. The source<br/>
        /// pixels are kept exactly as they are, centered on the new canvas, and<br/>
        /// the model paints only the added area. Supply either an existing<br/>
        /// Ideogram image asset or raw image bytes, but not both. The canvas is<br/>
        /// sized from the source so that the whole source fits.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageBriaExpandResponse> BriaExpandAsync(

            global::Ideogram.ReframeImageBriaExpandRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Bria Expand<br/>
        /// Extend one image to a new aspect ratio with Bria Expand. The source<br/>
        /// pixels are kept exactly as they are, centered on the new canvas, and<br/>
        /// the model paints only the added area. Supply either an existing<br/>
        /// Ideogram image asset or raw image bytes, but not both. The canvas is<br/>
        /// sized from the source so that the whole source fits.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageBriaExpandResponse>> BriaExpandAsResponseAsync(

            global::Ideogram.ReframeImageBriaExpandRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Bria Expand<br/>
        /// Extend one image to a new aspect ratio with Bria Expand. The source<br/>
        /// pixels are kept exactly as they are, centered on the new canvas, and<br/>
        /// the model paints only the added area. Supply either an existing<br/>
        /// Ideogram image asset or raw image bytes, but not both. The canvas is<br/>
        /// sized from the source so that the whole source fits.<br/>
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
        /// <param name="private">
        /// API-key requests are always private. For bearer-authenticated<br/>
        /// requests, this controls whether the result is private; when<br/>
        /// omitted, it follows the caller's plan entitlement. Enterprise<br/>
        /// generations are always private.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageBriaExpandResponse> BriaExpandAsync(
            string aspectRatio,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            bool? @private = default,
            int? seed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}