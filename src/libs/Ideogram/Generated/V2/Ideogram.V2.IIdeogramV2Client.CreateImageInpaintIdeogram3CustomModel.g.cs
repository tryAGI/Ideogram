#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.InpaintImageIdeogramV3CustomModelResponse> CreateImageInpaintIdeogram3CustomModelAsync(

            global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.InpaintImageIdeogramV3CustomModelResponse>> CreateImageInpaintIdeogram3CustomModelAsResponseAsync(

            global::Ideogram.V2.ImagesInpaintPostInpaintImageV2IdeogramV3CustomModelRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
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
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.InpaintImageIdeogramV3CustomModelResponse> CreateImageInpaintIdeogram3CustomModelAsync(
            string prompt,
            string customModelUri,
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            bool? dryRun = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.IdeogramV3StylePreset? stylePreset = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
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
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each), as JPEG, PNG, or WEBP.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false, wait until the images are ready. When true, return as soon as the request is accepted and poll `GET /v2/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.InpaintImageIdeogramV3CustomModelResponse> CreateImageInpaintIdeogram3CustomModelAsync(
            string prompt,
            string customModelUri,
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            bool? dryRun = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.IdeogramV3StylePreset? stylePreset = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
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
        /// The custom model URI returned by the custom-model API, in the form `model/&lt;model_name&gt;/version/&lt;version_name&gt;`. The authenticated user or organization must have access to the model.
        /// </param>
        /// <param name="image">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to repaint (max 25MB), as JPEG, PNG, or WEBP. Multipart requests only.
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
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. When omitted, the server chooses a speed supported by the selected custom model.
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset. Cannot be combined with style codes or style references.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// Images to use as style references (max 10, max 25MB each), as JPEG, PNG, or WEBP.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection. Adds detection latency; flagged images return `is_image_safe: false`.
        /// </param>
        /// <param name="async">
        /// When false, wait until the images are ready. When true, return as soon as the request is accepted and poll `GET /v2/generations/{generation_id}`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.InpaintImageIdeogramV3CustomModelResponse>> CreateImageInpaintIdeogram3CustomModelAsResponseAsync(
            string prompt,
            string customModelUri,
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            bool? dryRun = default,
            global::Ideogram.V2.MagicPromptMode? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2.V2ImageInpaintIdeogram3CustomModelPostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.V2.IdeogramV3StylePreset? stylePreset = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? enableCopyrightDetection = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}