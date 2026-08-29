#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Advertisement Resizer<br/>
        /// Resizes an advertisement image to the exact target size. Supply `prompt`<br/>
        /// to provide specific instructions for how the advertisement should look<br/>
        /// after resizing.<br/>
        /// The request is processed asynchronously and immediately returns a<br/>
        /// `generation_id`. Poll `GET /v1/generations/{generation_id}` until `status`<br/>
        /// is `completed` or `failed`. The completed polling response contains the<br/>
        /// final resized image(s) in `data` and the amount charged for variable<br/>
        /// usage-based pricing in `usage_cost_usd_micros`. If a `webhook_url` is<br/>
        /// supplied, the completed result is also POSTed to that URL.<br/>
        /// Supply the advertisement image as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// The required `resolution` (`WIDTHxHEIGHT`) sets the exact output<br/>
        /// dimensions.<br/>
        /// The model is fixed by the route, so no `model` field is accepted.
        /// </summary>
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostResizeImageAsyncAsync(

            global::Ideogram.ResizeAdImageRequest request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Advertisement Resizer<br/>
        /// Resizes an advertisement image to the exact target size. Supply `prompt`<br/>
        /// to provide specific instructions for how the advertisement should look<br/>
        /// after resizing.<br/>
        /// The request is processed asynchronously and immediately returns a<br/>
        /// `generation_id`. Poll `GET /v1/generations/{generation_id}` until `status`<br/>
        /// is `completed` or `failed`. The completed polling response contains the<br/>
        /// final resized image(s) in `data` and the amount charged for variable<br/>
        /// usage-based pricing in `usage_cost_usd_micros`. If a `webhook_url` is<br/>
        /// supplied, the completed result is also POSTed to that URL.<br/>
        /// Supply the advertisement image as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// The required `resolution` (`WIDTHxHEIGHT`) sets the exact output<br/>
        /// dimensions.<br/>
        /// The model is fixed by the route, so no `model` field is accepted.
        /// </summary>
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
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AsyncImageGenerationResponseV4>> PostResizeImageAsyncAsResponseAsync(

            global::Ideogram.ResizeAdImageRequest request,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Advertisement Resizer<br/>
        /// Resizes an advertisement image to the exact target size. Supply `prompt`<br/>
        /// to provide specific instructions for how the advertisement should look<br/>
        /// after resizing.<br/>
        /// The request is processed asynchronously and immediately returns a<br/>
        /// `generation_id`. Poll `GET /v1/generations/{generation_id}` until `status`<br/>
        /// is `completed` or `failed`. The completed polling response contains the<br/>
        /// final resized image(s) in `data` and the amount charged for variable<br/>
        /// usage-based pricing in `usage_cost_usd_micros`. If a `webhook_url` is<br/>
        /// supplied, the completed result is also POSTed to that URL.<br/>
        /// Supply the advertisement image as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// The required `resolution` (`WIDTHxHEIGHT`) sets the exact output<br/>
        /// dimensions.<br/>
        /// The model is fixed by the route, so no `model` field is accepted.
        /// </summary>
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
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The source image to reframe (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The source image to reframe (max size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="resolution">
        /// Target ad resolution, formatted as `WIDTHxHEIGHT`. Must be one of<br/>
        /// the supported ad resolutions listed above; any other value is<br/>
        /// rejected with a 400. Each returned image has exactly these pixel<br/>
        /// dimensions.
        /// </param>
        /// <param name="prompt">
        /// Optional edit instruction to apply while reframing, for example "remove the logo" or "put the price bottom-right".
        /// </param>
        /// <param name="quality">
        /// Output quality tier. Higher tiers generally improve detail and may take longer to complete. Supported values are LOW, MEDIUM, and HIGH.<br/>
        /// Default Value: HIGH
        /// </param>
        /// <param name="numImages">
        /// The number of reframed variations to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="storeAssets">
        /// Reserved for a future release: accepted for forward compatibility but not yet applied. Resulting assets are not stored to your account regardless of this value.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AsyncImageGenerationResponseV4> PostResizeImageAsyncAsync(
            global::Ideogram.ResizeAdImageRequestResolution resolution,
            string? webhookUrl = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            string? prompt = default,
            global::Ideogram.ResizeAdImageQuality? quality = default,
            int? numImages = default,
            bool? storeAssets = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}