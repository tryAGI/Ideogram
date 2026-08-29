#nullable enable

namespace Ideogram
{
    public partial interface IObjectRemovalClient
    {
        /// <summary>
        /// Remove a masked object from an image, by asset id or by uploaded bytes<br/>
        /// Remove a masked object from an image. For each of the source image and the<br/>
        /// mask, supply either an `AssetIdentifier` reference (`image_asset_identifier`<br/>
        /// / `mask_asset_identifier`) or the raw image bytes directly (`image` / `mask`,<br/>
        /// multipart requests only) — callers are never required to call<br/>
        /// `POST /v2/assets` first. If both a reference and bytes are supplied for the<br/>
        /// same input, the reference wins and the bytes are ignored.<br/>
        /// Poll for completion with `GET /v1/generations/{generation_id}` using the<br/>
        /// returned `generation_id`.<br/>
        /// This is the `/v2` capability-first shape; no `model` or `model_uri` field is<br/>
        /// exposed until a second backend exists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectFromV2AssetsResponse> PostRemoveObjectFromV2AssetsAsync(

            global::Ideogram.RemoveObjectFromV2AssetsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a masked object from an image, by asset id or by uploaded bytes<br/>
        /// Remove a masked object from an image. For each of the source image and the<br/>
        /// mask, supply either an `AssetIdentifier` reference (`image_asset_identifier`<br/>
        /// / `mask_asset_identifier`) or the raw image bytes directly (`image` / `mask`,<br/>
        /// multipart requests only) — callers are never required to call<br/>
        /// `POST /v2/assets` first. If both a reference and bytes are supplied for the<br/>
        /// same input, the reference wins and the bytes are ignored.<br/>
        /// Poll for completion with `GET /v1/generations/{generation_id}` using the<br/>
        /// returned `generation_id`.<br/>
        /// This is the `/v2` capability-first shape; no `model` or `model_uri` field is<br/>
        /// exposed until a second backend exists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveObjectFromV2AssetsResponse>> PostRemoveObjectFromV2AssetsAsResponseAsync(

            global::Ideogram.RemoveObjectFromV2AssetsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove a masked object from an image, by asset id or by uploaded bytes<br/>
        /// Remove a masked object from an image. For each of the source image and the<br/>
        /// mask, supply either an `AssetIdentifier` reference (`image_asset_identifier`<br/>
        /// / `mask_asset_identifier`) or the raw image bytes directly (`image` / `mask`,<br/>
        /// multipart requests only) — callers are never required to call<br/>
        /// `POST /v2/assets` first. If both a reference and bytes are supplied for the<br/>
        /// same input, the reference wins and the bytes are ignored.<br/>
        /// Poll for completion with `GET /v1/generations/{generation_id}` using the<br/>
        /// returned `generation_id`.<br/>
        /// This is the `/v2` capability-first shape; no `model` or `model_uri` field is<br/>
        /// exposed until a second backend exists.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to remove an object from (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `image_asset_identifier` is also supplied.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="mask">
        /// A binary mask the same size as the image, as raw bytes; white (&gt;= 128) marks the region to remove. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </param>
        /// <param name="maskname">
        /// A binary mask the same size as the image, as raw bytes; white (&gt;= 128) marks the region to remove. Only JPEG, PNG, and WEBP formats are supported. Multipart requests only; ignored if `mask_asset_identifier` is also supplied.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="storeAssets">
        /// Whether to store resulting generation assets on Ideogram. Defaults to `false` for<br/>
        /// API developers; first-party mini-apps should pass `true`. Reserved in the schema for<br/>
        /// an upcoming storage-control rollout — currently accepted but not yet enforced.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectFromV2AssetsResponse> PostRemoveObjectFromV2AssetsAsync(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            byte[]? mask = default,
            string? maskname = default,
            int? seed = default,
            bool? storeAssets = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}