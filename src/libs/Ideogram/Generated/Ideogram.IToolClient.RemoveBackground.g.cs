#nullable enable

namespace Ideogram
{
    public partial interface IToolClient
    {
        /// <summary>
        /// Remove an image background<br/>
        /// Remove the background from one image and return a foreground PNG with<br/>
        /// transparency. Supply exactly one source: raw `image` bytes in a<br/>
        /// multipart request, or an existing `image_asset_identifier` in JSON or<br/>
        /// multipart form.<br/>
        /// By default the request blocks until the foreground image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll `GET /v1/generations/{generation_id}`.<br/>
        /// API-key requests use the organization bound to the key. Firebase Bearer<br/>
        /// requests use their selected organization, and Mini App context tokens<br/>
        /// remain bound to the organization in the token. When `private` is omitted,<br/>
        /// Bearer and Mini App callers inherit their plan's private-generation<br/>
        /// default; Enterprise generations are always private.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveBackgroundV2Response> RemoveBackgroundAsync(

            global::Ideogram.RemoveBackgroundV2Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an image background<br/>
        /// Remove the background from one image and return a foreground PNG with<br/>
        /// transparency. Supply exactly one source: raw `image` bytes in a<br/>
        /// multipart request, or an existing `image_asset_identifier` in JSON or<br/>
        /// multipart form.<br/>
        /// By default the request blocks until the foreground image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll `GET /v1/generations/{generation_id}`.<br/>
        /// API-key requests use the organization bound to the key. Firebase Bearer<br/>
        /// requests use their selected organization, and Mini App context tokens<br/>
        /// remain bound to the organization in the token. When `private` is omitted,<br/>
        /// Bearer and Mini App callers inherit their plan's private-generation<br/>
        /// default; Enterprise generations are always private.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveBackgroundV2Response>> RemoveBackgroundAsResponseAsync(

            global::Ideogram.RemoveBackgroundV2Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an image background<br/>
        /// Remove the background from one image and return a foreground PNG with<br/>
        /// transparency. Supply exactly one source: raw `image` bytes in a<br/>
        /// multipart request, or an existing `image_asset_identifier` in JSON or<br/>
        /// multipart form.<br/>
        /// By default the request blocks until the foreground image is ready and<br/>
        /// returns it in `data`. Set `async` to true to return immediately after<br/>
        /// the request is accepted, then poll `GET /v1/generations/{generation_id}`.<br/>
        /// API-key requests use the organization bound to the key. Firebase Bearer<br/>
        /// requests use their selected organization, and Mini App context tokens<br/>
        /// remain bound to the organization in the token. When `private` is omitted,<br/>
        /// Bearer and Mini App callers inherit their plan's private-generation<br/>
        /// default; Enterprise generations are always private.
        /// </summary>
        /// <param name="image">
        /// Raw JPEG, PNG, or WebP image bytes (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// Raw JPEG, PNG, or WebP image bytes (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// Firebase Bearer and Mini App callers inherit their plan entitlement.<br/>
        /// Enterprise generations are always private. API keys use their bound<br/>
        /// organization and otherwise default to public when no subscription<br/>
        /// entitlement is available.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return after acceptance and poll `GET /v1/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveBackgroundV2Response> RemoveBackgroundAsync(
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            bool? @private = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}