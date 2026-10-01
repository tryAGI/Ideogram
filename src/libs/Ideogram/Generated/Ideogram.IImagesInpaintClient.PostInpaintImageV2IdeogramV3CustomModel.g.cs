#nullable enable

namespace Ideogram
{
    public partial interface IImagesInpaintClient
    {
        /// <summary>
        /// Inpaint with a custom Ideogram 3.0 model<br/>
        /// Repaint the masked region of a source image with a custom Ideogram 3.0<br/>
        /// model, passed as `custom_model_uri`. Upload the source `image` and its<br/>
        /// `mask` using `multipart/form-data`. Returns results directly by<br/>
        /// default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.InpaintImageIdeogramV3CustomModelResponse> PostInpaintImageV2IdeogramV3CustomModelAsync(

            global::Ideogram.InpaintImageIdeogramV3CustomModelRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint with a custom Ideogram 3.0 model<br/>
        /// Repaint the masked region of a source image with a custom Ideogram 3.0<br/>
        /// model, passed as `custom_model_uri`. Upload the source `image` and its<br/>
        /// `mask` using `multipart/form-data`. Returns results directly by<br/>
        /// default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.InpaintImageIdeogramV3CustomModelResponse>> PostInpaintImageV2IdeogramV3CustomModelAsResponseAsync(

            global::Ideogram.InpaintImageIdeogramV3CustomModelRequest request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Inpaint with a custom Ideogram 3.0 model<br/>
        /// Repaint the masked region of a source image with a custom Ideogram 3.0<br/>
        /// model, passed as `custom_model_uri`. Upload the source `image` and its<br/>
        /// `mask` using `multipart/form-data`. Returns results directly by<br/>
        /// default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
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
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="maskAssetIdentifier">
        /// A black-and-white mask asset the same size as the source image. Black marks the region to repaint. Takes priority over `mask`.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP. Black marks the region to repaint. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the source image, as JPEG, PNG, or WEBP. Black marks the region to repaint. Multipart requests only.
        /// </param>
        /// <param name="magicPrompt">
        /// Controls magic prompt (automatic prompt rewriting). Defaults to `auto`.<br/>
        /// Default Value: auto
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
        /// A saved style, by its URL-safe base64 collection id. Takes priority over `style_reference_images` if both are supplied.
        /// </param>
        /// <param name="styleReferenceCollectionVersionId">
        /// Optional URL-safe base64 version id for the saved style. Ignored without `style_reference_collection_id`.
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references. Takes priority over raw style reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each), as JPEG, PNG, or WEBP.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false, wait until the images are ready. When true, return as soon as the request is accepted and poll `GET /v2/generations/{generation_id}`.<br/>
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
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AssetIdentifier? maskAssetIdentifier = default,
            byte[]? mask = default,
            string? maskname = default,
            global::Ideogram.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.InpaintImageIdeogramV3CustomModelRequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
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