#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Product Color Change<br/>
        /// Recolors the masked regions of the product photo, each to its own<br/>
        /// target color, while preserving the product's geometry, materials,<br/>
        /// prints, logos, and shading, and keeping every region outside the<br/>
        /// masks unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the masks marking the regions to recolor as either<br/>
        /// `AssetIdentifier` references (`mask_asset_identifiers`) or the raw<br/>
        /// mask bytes directly (`masks`, multipart requests only), paired by<br/>
        /// position with `colors` — up to 4 regions; a single-region edit is a<br/>
        /// one-item list. Provide exactly one of the two forms. Every mask must<br/>
        /// have the same pixel dimensions as the product photo. White pixels<br/>
        /// mark the region to recolor; black pixels are preserved. Alpha-only<br/>
        /// masks are also supported: opaque pixels mark the region to recolor<br/>
        /// and transparent pixels are preserved.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ColorwaysResponse> PostColorwaysAsync(

            global::Ideogram.ColorwaysRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Product Color Change<br/>
        /// Recolors the masked regions of the product photo, each to its own<br/>
        /// target color, while preserving the product's geometry, materials,<br/>
        /// prints, logos, and shading, and keeping every region outside the<br/>
        /// masks unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the masks marking the regions to recolor as either<br/>
        /// `AssetIdentifier` references (`mask_asset_identifiers`) or the raw<br/>
        /// mask bytes directly (`masks`, multipart requests only), paired by<br/>
        /// position with `colors` — up to 4 regions; a single-region edit is a<br/>
        /// one-item list. Provide exactly one of the two forms. Every mask must<br/>
        /// have the same pixel dimensions as the product photo. White pixels<br/>
        /// mark the region to recolor; black pixels are preserved. Alpha-only<br/>
        /// masks are also supported: opaque pixels mark the region to recolor<br/>
        /// and transparent pixels are preserved.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ColorwaysResponse>> PostColorwaysAsResponseAsync(

            global::Ideogram.ColorwaysRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Product Color Change<br/>
        /// Recolors the masked regions of the product photo, each to its own<br/>
        /// target color, while preserving the product's geometry, materials,<br/>
        /// prints, logos, and shading, and keeping every region outside the<br/>
        /// masks unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the masks marking the regions to recolor as either<br/>
        /// `AssetIdentifier` references (`mask_asset_identifiers`) or the raw<br/>
        /// mask bytes directly (`masks`, multipart requests only), paired by<br/>
        /// position with `colors` — up to 4 regions; a single-region edit is a<br/>
        /// one-item list. Provide exactly one of the two forms. Every mask must<br/>
        /// have the same pixel dimensions as the product photo. White pixels<br/>
        /// mark the region to recolor; black pixels are preserved. Alpha-only<br/>
        /// masks are also supported: opaque pixels mark the region to recolor<br/>
        /// and transparent pixels are preserved.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The product photo to recolor (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The product photo to recolor (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="maskAssetIdentifiers">
        /// The masks marking the regions of the product photo to recolor, by<br/>
        /// reference, paired by position with `colors` (max 4). Every mask<br/>
        /// must have the same pixel dimensions as the product photo. White<br/>
        /// pixels mark the region to recolor; black pixels are preserved.<br/>
        /// Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to recolor and transparent pixels are preserved. Provide<br/>
        /// exactly one of `mask_asset_identifiers` or `masks`.
        /// </param>
        /// <param name="masks">
        /// The masks marking the regions of the product photo to recolor<br/>
        /// (max 4, max size 25MB each), as raw bytes, paired by position with<br/>
        /// `colors`; only JPEG, PNG, and WEBP formats are supported. Every<br/>
        /// mask must have the same pixel dimensions as the product photo,<br/>
        /// and follows the same pixel rules as `mask_asset_identifiers`.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifiers` or `masks`.
        /// </param>
        /// <param name="colors">
        /// One target color per mask in `masks` or<br/>
        /// `mask_asset_identifiers`, as six-digit hex codes like `#B3202C`,<br/>
        /// paired by position. The product's shape, construction, materials,<br/>
        /// prints, and logos are always preserved.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generated image. Defaults to the aspect<br/>
        /// ratio of the product photo when omitted, which preserves the<br/>
        /// original framing exactly. When a different ratio is requested, the<br/>
        /// scene is extended to fill the new shape rather than cropped, so<br/>
        /// part of the frame is newly generated. Supported values are `1:1`,<br/>
        /// `3:4`, `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the image edit. Higher tiers may improve detail<br/>
        /// and take longer to complete.
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish the output to the public feed. Enterprise accounts always generate privately.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ColorwaysResponse> PostColorwaysAsync(
            global::System.Collections.Generic.IList<string> colors,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? maskAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? masks = default,
            string? aspectRatio = default,
            global::Ideogram.GptImage2Quality? quality = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}