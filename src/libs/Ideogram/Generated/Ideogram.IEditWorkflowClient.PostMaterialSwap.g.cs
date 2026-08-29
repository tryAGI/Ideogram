#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Product Material Change<br/>
        /// Re-renders the masked region of the product photo in the material shown<br/>
        /// by the reference image — matching its color, texture, pattern scale,<br/>
        /// and orientation — while preserving the product's silhouette,<br/>
        /// construction, seams, and shading, and keeping every region outside the<br/>
        /// mask unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the mask marking the region to re-material as either an<br/>
        /// `AssetIdentifier` reference (`mask_asset_identifier`) or the raw mask<br/>
        /// bytes directly (`mask`, multipart requests only). Provide exactly one<br/>
        /// of the two forms. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to change and transparent pixels are preserved.<br/>
        /// Supply the material reference as either an `AssetIdentifier` reference<br/>
        /// (`material_asset_identifier`) or the raw image bytes directly<br/>
        /// (`material`, multipart requests only). Provide exactly one of the two<br/>
        /// forms.
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
        /// Re-renders the masked region of the product photo in the material shown<br/>
        /// by the reference image — matching its color, texture, pattern scale,<br/>
        /// and orientation — while preserving the product's silhouette,<br/>
        /// construction, seams, and shading, and keeping every region outside the<br/>
        /// mask unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the mask marking the region to re-material as either an<br/>
        /// `AssetIdentifier` reference (`mask_asset_identifier`) or the raw mask<br/>
        /// bytes directly (`mask`, multipart requests only). Provide exactly one<br/>
        /// of the two forms. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to change and transparent pixels are preserved.<br/>
        /// Supply the material reference as either an `AssetIdentifier` reference<br/>
        /// (`material_asset_identifier`) or the raw image bytes directly<br/>
        /// (`material`, multipart requests only). Provide exactly one of the two<br/>
        /// forms.
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
        /// Re-renders the masked region of the product photo in the material shown<br/>
        /// by the reference image — matching its color, texture, pattern scale,<br/>
        /// and orientation — while preserving the product's silhouette,<br/>
        /// construction, seams, and shading, and keeping every region outside the<br/>
        /// mask unchanged.<br/>
        /// The request is processed asynchronously. Poll<br/>
        /// `GET /v1/generations/{generation_id}` with the returned `generation_id`<br/>
        /// until the generation is completed or failed.<br/>
        /// Supply the product photo as either an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or the raw image bytes directly (`image`,<br/>
        /// multipart requests only). Provide exactly one of the two forms;<br/>
        /// supplying both, or neither, is rejected with a 400.<br/>
        /// Supply the mask marking the region to re-material as either an<br/>
        /// `AssetIdentifier` reference (`mask_asset_identifier`) or the raw mask<br/>
        /// bytes directly (`mask`, multipart requests only). Provide exactly one<br/>
        /// of the two forms. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels are<br/>
        /// preserved. Alpha-only masks are also supported: opaque pixels mark the<br/>
        /// region to change and transparent pixels are preserved.<br/>
        /// Supply the material reference as either an `AssetIdentifier` reference<br/>
        /// (`material_asset_identifier`) or the raw image bytes directly<br/>
        /// (`material`, multipart requests only). Provide exactly one of the two<br/>
        /// forms.
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
        /// <param name="maskAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="mask">
        /// The mask marking the region of the product photo to change (max<br/>
        /// size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels<br/>
        /// are preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to change and transparent pixels are preserved.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifier` or `mask`.
        /// </param>
        /// <param name="maskname">
        /// The mask marking the region of the product photo to change (max<br/>
        /// size 25MB), as raw bytes; only JPEG, PNG, and WEBP formats are<br/>
        /// supported. The mask must have the same pixel dimensions as the<br/>
        /// product photo. White pixels mark the region to change; black pixels<br/>
        /// are preserved. Alpha-only masks are also supported: opaque pixels<br/>
        /// mark the region to change and transparent pixels are preserved.<br/>
        /// Multipart requests only. Provide exactly one of<br/>
        /// `mask_asset_identifier` or `mask`.
        /// </param>
        /// <param name="materialAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="material">
        /// The material reference image (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Only its material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked region. Multipart requests only. Provide exactly one of<br/>
        /// `material_asset_identifier` or `material`.
        /// </param>
        /// <param name="materialname">
        /// The material reference image (max size 25MB), as raw bytes; only<br/>
        /// JPEG, PNG, and WEBP formats are supported. Only its material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked region. Multipart requests only. Provide exactly one of<br/>
        /// `material_asset_identifier` or `material`.
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
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            byte[]? mask = default,
            string? maskname = default,
            global::Ideogram.AssetIdentifier? materialAssetIdentifier = default,
            byte[]? material = default,
            string? materialname = default,
            string? aspectRatio = default,
            global::Ideogram.GptImage2Quality? quality = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}