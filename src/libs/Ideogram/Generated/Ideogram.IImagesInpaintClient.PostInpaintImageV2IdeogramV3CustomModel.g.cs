#nullable enable

namespace Ideogram
{
    public partial interface IImagesInpaintClient
    {
        /// <summary>
        /// Repaint a masked region with a custom Ideogram 3.0 model<br/>
        /// Repaint the masked region of a source image with a custom Ideogram 3.0<br/>
        /// model the authenticated user or organization can access. Supply the<br/>
        /// model URI returned by the custom-model API as `custom_model_uri`.<br/>
        /// For each of the source image and mask, supply either an<br/>
        /// `AssetIdentifier` reference (`image_asset_identifier` /<br/>
        /// `mask_asset_identifier`) or raw bytes (`image` / `mask`, multipart<br/>
        /// requests only). A reference wins if both forms are supplied.<br/>
        /// Optional style controls are style codes, a style preset, or style<br/>
        /// reference images. Supply style references as a saved style, existing<br/>
        /// asset identifiers, or raw image bytes. Only one style control may be<br/>
        /// used; when multiple reference forms are supplied, the collection wins<br/>
        /// over identifiers, and identifiers win over bytes.<br/>
        /// By default the request blocks until the images are ready. Set `async`<br/>
        /// to true to return after dispatch and poll<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InpaintImageIdeogramV3CustomModelResponse> PostInpaintImageV2IdeogramV3CustomModelAsync(

            global::Ideogram.InpaintImageIdeogramV3CustomModelRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repaint a masked region with a custom Ideogram 3.0 model<br/>
        /// Repaint the masked region of a source image with a custom Ideogram 3.0<br/>
        /// model the authenticated user or organization can access. Supply the<br/>
        /// model URI returned by the custom-model API as `custom_model_uri`.<br/>
        /// For each of the source image and mask, supply either an<br/>
        /// `AssetIdentifier` reference (`image_asset_identifier` /<br/>
        /// `mask_asset_identifier`) or raw bytes (`image` / `mask`, multipart<br/>
        /// requests only). A reference wins if both forms are supplied.<br/>
        /// Optional style controls are style codes, a style preset, or style<br/>
        /// reference images. Supply style references as a saved style, existing<br/>
        /// asset identifiers, or raw image bytes. Only one style control may be<br/>
        /// used; when multiple reference forms are supplied, the collection wins<br/>
        /// over identifiers, and identifiers win over bytes.<br/>
        /// By default the request blocks until the images are ready. Set `async`<br/>
        /// to true to return after dispatch and poll<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.InpaintImageIdeogramV3CustomModelResponse>> PostInpaintImageV2IdeogramV3CustomModelAsResponseAsync(

            global::Ideogram.InpaintImageIdeogramV3CustomModelRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Repaint a masked region with a custom Ideogram 3.0 model<br/>
        /// Repaint the masked region of a source image with a custom Ideogram 3.0<br/>
        /// model the authenticated user or organization can access. Supply the<br/>
        /// model URI returned by the custom-model API as `custom_model_uri`.<br/>
        /// For each of the source image and mask, supply either an<br/>
        /// `AssetIdentifier` reference (`image_asset_identifier` /<br/>
        /// `mask_asset_identifier`) or raw bytes (`image` / `mask`, multipart<br/>
        /// requests only). A reference wins if both forms are supplied.<br/>
        /// Optional style controls are style codes, a style preset, or style<br/>
        /// reference images. Supply style references as a saved style, existing<br/>
        /// asset identifiers, or raw image bytes. Only one style control may be<br/>
        /// used; when multiple reference forms are supplied, the collection wins<br/>
        /// over identifiers, and identifiers win over bytes.<br/>
        /// By default the request blocks until the images are ready. Set `async`<br/>
        /// to true to return after dispatch and poll<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the repainted result.
        /// </param>
        /// <param name="customModelUri">
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.<br/>
        /// Example: model/my-custom-model/version/1
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// The source image asset to repaint. Takes priority over `image`.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max size 25MB), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored when `image_asset_identifier` is supplied.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max size 25MB), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored when `image_asset_identifier` is supplied.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// A black-and-white mask asset the same size as the source image. Black marks the region to repaint. Takes priority over `mask`.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP bytes. Black marks the region to repaint. Multipart requests only; ignored when `mask_asset_identifier` is supplied.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP bytes. Black marks the region to repaint. Multipart requests only; ignored when `mask_asset_identifier` is supplied.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceCollectionId">
        /// A saved style, by its URL-safe base64 collection id. Takes priority over asset identifiers and raw style reference images.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id for the saved style. Ignored without `style_reference_collection_id`.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references. Takes priority over raw style reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max size 25MB each), as JPEG, PNG, or WEBP bytes. Multipart requests only; ignored if a collection or asset identifiers are supplied.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false, block until the images are ready. When true, return after dispatch and poll `GET /v1/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="private">
        /// When true or omitted, the output is kept private to your account. Set to false to publish it. Enterprise accounts always generate privately.
        /// </param>
        /// <param name="targetCollectionId">
        /// A collection you can write to, by its URL-safe base64 collection id. Completed images are added to it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InpaintImageIdeogramV3CustomModelResponse> PostInpaintImageV2IdeogramV3CustomModelAsync(
            string prompt,
            string customModelUri,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            byte[]? mask = default,
            string? maskname = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.StylePresetV3? stylePreset = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            string? styleReferenceCollectionId = default,
            string? styleReferenceCollectionVersionId = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            bool? @private = default,
            string? targetCollectionId = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}