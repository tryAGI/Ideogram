#nullable enable

namespace Ideogram
{
    public partial interface IEditWorkflowClient
    {
        /// <summary>
        /// Material Swap<br/>
        /// Re-renders masked regions of a product photo in the materials shown in<br/>
        /// reference images, preserving the product's construction and everything<br/>
        /// outside the masks. Upload the `image`, up to 4 `masks`, and the<br/>
        /// `materials` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.MaterialSwapResponse> PostMaterialSwapAsync(

            global::Ideogram.MaterialSwapRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Material Swap<br/>
        /// Re-renders masked regions of a product photo in the materials shown in<br/>
        /// reference images, preserving the product's construction and everything<br/>
        /// outside the masks. Upload the `image`, up to 4 `masks`, and the<br/>
        /// `materials` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.MaterialSwapResponse>> PostMaterialSwapAsResponseAsync(

            global::Ideogram.MaterialSwapRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Material Swap<br/>
        /// Re-renders masked regions of a product photo in the materials shown in<br/>
        /// reference images, preserving the product's construction and everything<br/>
        /// outside the masks. Upload the `image`, up to 4 `masks`, and the<br/>
        /// `materials` using `multipart/form-data`.<br/>
        /// Returns a `generation_id`; poll `GET /v2/generations/{generation_id}` or<br/>
        /// supply a `webhook_url`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The product photo to edit, by reference. Everything outside the<br/>
        /// masked region is preserved. Provide exactly one of<br/>
        /// `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="image">
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The product photo to edit (max size 25MB). JPEG, PNG, and WEBP<br/>
        /// formats are supported.
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
        /// Masks marking the regions to change (max 4, max size 25MB each).<br/>
        /// JPEG, PNG, and WEBP formats are supported. Every mask must have the<br/>
        /// same pixel dimensions as the product photo. White pixels mark the<br/>
        /// region to change and black pixels are preserved; alpha-only masks<br/>
        /// also work (opaque = change, transparent = preserve).
        /// </param>
        /// <param name="materialAssetIdentifiers">
        /// The material reference images, by reference. Only their material —<br/>
        /// color, texture, pattern scale, and orientation — is applied to the<br/>
        /// masked regions. Send one material, which every mask takes, or<br/>
        /// exactly one per mask paired by position. Provide exactly one of<br/>
        /// `material_asset_identifiers` or `materials`.
        /// </param>
        /// <param name="materials">
        /// Material reference images (max size 25MB each). JPEG, PNG, and WEBP<br/>
        /// formats are supported. Only their material (color, texture, pattern<br/>
        /// scale, and orientation) is applied to the masked regions. Send one<br/>
        /// material for every mask, or exactly one per mask, paired by<br/>
        /// position.
        /// </param>
        /// <param name="aspectRatio">
        /// Output aspect ratio. Defaults to the product photo's aspect ratio,<br/>
        /// which keeps the original framing. A different ratio extends the<br/>
        /// scene to fill the new shape rather than cropping, so part of the<br/>
        /// frame is newly generated. Supported values are `1:1`, `3:4`,<br/>
        /// `4:3`, `16:9`, and `9:16`.
        /// </param>
        /// <param name="quality">
        /// The quality tier for the edit. Higher tiers may improve detail and<br/>
        /// take longer to complete.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed outputs are added to it automatically.
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
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? maskAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? masks = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? materialAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? materials = default,
            string? aspectRatio = default,
            global::Ideogram.MaterialSwapQuality? quality = default,
            string? targetCollectionId = default,
            bool? @private = default,
            string? webhookUrl = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}