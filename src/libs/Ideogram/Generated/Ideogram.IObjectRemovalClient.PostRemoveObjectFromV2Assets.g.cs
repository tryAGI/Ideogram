#nullable enable

namespace Ideogram
{
    public partial interface IObjectRemovalClient
    {
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectFromV2AssetsResponse> PostRemoveObjectFromV2AssetsAsync(

            global::Ideogram.RemoveObjectFromV2AssetsRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveObjectFromV2AssetsResponse>> PostRemoveObjectFromV2AssetsAsResponseAsync(

            global::Ideogram.RemoveObjectFromV2AssetsRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
        /// </param>
        /// <param name="storeAssets">
        /// Whether to store the resulting images on Ideogram. Defaults to `false`.<br/>
        /// Currently accepted but not yet enforced.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectFromV2AssetsResponse> PostRemoveObjectFromV2AssetsAsync(
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            byte[]? mask = default,
            string? maskname = default,
            int? seed = default,
            string? targetCollectionId = default,
            bool? storeAssets = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}