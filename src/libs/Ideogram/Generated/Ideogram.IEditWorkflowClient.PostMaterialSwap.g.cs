#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Product Material Change<br/>
        /// Re-renders the masked regions of the product photo in the materials<br/>
        /// shown by the reference images — matching each one's color, texture,<br/>
        /// pattern scale, and orientation — while preserving the product's<br/>
        /// silhouette, construction, seams, and shading, and keeping every region<br/>
        /// outside the masks unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the masks marking the regions to re-material as either<br/>
        /// `AssetIdentifier` references (`mask_asset_identifiers`) or the raw mask<br/>
        /// bytes directly (`masks`, multipart requests only) — up to 4 regions; a<br/>
        /// single-region edit is a one-item list. Provide exactly one of the two<br/>
        /// forms. Every mask must have the same pixel dimensions as the product<br/>
        /// photo. White pixels mark the region to change; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to change and transparent pixels are preserved.<br/>
        /// Supply the material references as either `AssetIdentifier` references<br/>
        /// (`material_asset_identifiers`) or the raw image bytes directly<br/>
        /// (`materials`, multipart requests only). Provide exactly one of the two<br/>
        /// forms. Send either one material, which every mask takes, or exactly one<br/>
        /// material per mask, paired by position.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MaterialSwapResponse> PostMaterialSwapAsync(

            global::Ideogram.MaterialSwapRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Product Material Change<br/>
        /// Re-renders the masked regions of the product photo in the materials<br/>
        /// shown by the reference images — matching each one's color, texture,<br/>
        /// pattern scale, and orientation — while preserving the product's<br/>
        /// silhouette, construction, seams, and shading, and keeping every region<br/>
        /// outside the masks unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the masks marking the regions to re-material as either<br/>
        /// `AssetIdentifier` references (`mask_asset_identifiers`) or the raw mask<br/>
        /// bytes directly (`masks`, multipart requests only) — up to 4 regions; a<br/>
        /// single-region edit is a one-item list. Provide exactly one of the two<br/>
        /// forms. Every mask must have the same pixel dimensions as the product<br/>
        /// photo. White pixels mark the region to change; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to change and transparent pixels are preserved.<br/>
        /// Supply the material references as either `AssetIdentifier` references<br/>
        /// (`material_asset_identifiers`) or the raw image bytes directly<br/>
        /// (`materials`, multipart requests only). Provide exactly one of the two<br/>
        /// forms. Send either one material, which every mask takes, or exactly one<br/>
        /// material per mask, paired by position.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MaterialSwapResponse>> PostMaterialSwapAsResponseAsync(

            global::Ideogram.MaterialSwapRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Product Material Change<br/>
        /// Re-renders the masked regions of the product photo in the materials<br/>
        /// shown by the reference images — matching each one's color, texture,<br/>
        /// pattern scale, and orientation — while preserving the product's<br/>
        /// silhouette, construction, seams, and shading, and keeping every region<br/>
        /// outside the masks unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the masks marking the regions to re-material as either<br/>
        /// `AssetIdentifier` references (`mask_asset_identifiers`) or the raw mask<br/>
        /// bytes directly (`masks`, multipart requests only) — up to 4 regions; a<br/>
        /// single-region edit is a one-item list. Provide exactly one of the two<br/>
        /// forms. Every mask must have the same pixel dimensions as the product<br/>
        /// photo. White pixels mark the region to change; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to change and transparent pixels are preserved.<br/>
        /// Supply the material references as either `AssetIdentifier` references<br/>
        /// (`material_asset_identifiers`) or the raw image bytes directly<br/>
        /// (`materials`, multipart requests only). Provide exactly one of the two<br/>
        /// forms. Send either one material, which every mask takes, or exactly one<br/>
        /// material per mask, paired by position.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The product photo to edit (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The product photo to edit (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Multipart requests only.<br/>
        /// Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="maskAssetIdentifiers">
        /// The masks marking the regions of the product photo to change, by<br/>
        /// reference (max 4). Every mask must have the same pixel dimensions<br/>
        /// as the product photo. White pixels mark the region to change; black<br/>
        /// pixels are preserved. Alpha-only masks are also supported: opaque<br/>
        /// pixels mark the region to change and transparent pixels are<br/>
        /// preserved. Provide exactly one of `mask_asset_identifiers` or<br/>
        /// `masks`.
        /// </param>
        /// <param name="masks">
        /// The masks marking the regions of the product photo to change (max<br/>
        /// 4, max size 25MB each), as raw bytes; only JPEG, PNG, and WEBP<br/>
        /// formats are supported. Every mask must have the same pixel<br/>
        /// dimensions as the product photo, and follows the same pixel rules<br/>
        /// as `mask_asset_identifiers`. Multipart requests only. Provide<br/>
        /// exactly one of `mask_asset_identifiers` or `masks`.
        /// </param>
        /// <param name="materialAssetIdentifiers">
        /// The material reference images, by reference. Only their material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Provide exactly one of<br/>
        /// `material_asset_identifiers` or `materials`.
        /// </param>
        /// <param name="materials">
        /// The material reference images (max size 25MB each), as raw bytes;<br/>
        /// only JPEG, PNG, and WEBP formats are supported. Only their material<br/>
        /// — color, texture, pattern scale, and orientation — is applied to<br/>
        /// the masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Multipart requests only.<br/>
        /// Provide exactly one of `material_asset_identifiers` or `materials`.
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
        global::System.Threading.Tasks.Task<global::Ideogram.MaterialSwapResponse> PostMaterialSwapAsync(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? maskAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? masks = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? materialAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? materials = default,
            string? aspectRatio = default,
            global::Ideogram.GptImage2Quality? quality = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}