#nullable enable

namespace Ideogram
{
    public partial interface IReframeClient
    {
        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Expand an image to a new Ideogram 3.0 resolution, keeping the source<br/>
        /// pixels in the center and filling the new area. Upload the source<br/>
        /// `image` using `multipart/form-data`. Returns results directly by<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageIdeogramV3Response> ReframeIdeogramV3Async(

            global::Ideogram.ReframeIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Expand an image to a new Ideogram 3.0 resolution, keeping the source<br/>
        /// pixels in the center and filling the new area. Upload the source<br/>
        /// `image` using `multipart/form-data`. Returns results directly by<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageIdeogramV3Response>> ReframeIdeogramV3AsResponseAsync(

            global::Ideogram.ReframeIdeogramV3Request request,
            bool? dryRun = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Expand an image to a new Ideogram 3.0 resolution, keeping the source<br/>
        /// pixels in the center and filling the new area. Upload the source<br/>
        /// `image` using `multipart/form-data`. Returns results directly by<br/>
        /// default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// Default Value: default
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// JPEG, PNG, or WEBP style reference images (max 10, max 25MB each). Multipart requests only. Cannot be combined with `style_preset` or `style_codes`.
        /// </param>
        /// <param name="async">
        /// Return immediately instead of waiting for reframed images.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageIdeogramV3Response> ReframeIdeogramV3Async(
            byte[] image,
            string imagename,
            global::Ideogram.ResolutionV3 resolution,
            bool? dryRun = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
            global::Ideogram.IdeogramColorPalette? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Expand an image to a new Ideogram 3.0 resolution, keeping the source<br/>
        /// pixels in the center and filling the new area. Upload the source<br/>
        /// `image` using `multipart/form-data`. Returns results directly by<br/>
        /// default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// Default Value: default
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// JPEG, PNG, or WEBP style reference images (max 10, max 25MB each). Multipart requests only. Cannot be combined with `style_preset` or `style_codes`.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
        /// </param>
        /// <param name="async">
        /// Return immediately instead of waiting for reframed images.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageIdeogramV3Response> ReframeIdeogramV3Async(
            global::System.IO.Stream image,
            string imagename,
            global::Ideogram.ResolutionV3 resolution,
            bool? dryRun = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
            global::Ideogram.IdeogramColorPalette? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Expand an image to a new Ideogram 3.0 resolution, keeping the source<br/>
        /// pixels in the center and filling the new area. Upload the source<br/>
        /// `image` using `multipart/form-data`. Returns results directly by<br/>
        /// default; set `async` to get a `generation_id` and poll<br/>
        /// `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="renderingSpeed">
        /// Default Value: default
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// JPEG, PNG, or WEBP style reference images (max 10, max 25MB each). Multipart requests only. Cannot be combined with `style_preset` or `style_codes`.
        /// </param>
        /// <param name="styleReferenceImagesFileNames">
        /// Optional file names to use for the multipart 'style_reference_images' file parts.
        /// </param>
        /// <param name="async">
        /// Return immediately instead of waiting for reframed images.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageIdeogramV3Response>> ReframeIdeogramV3AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::Ideogram.ResolutionV3 resolution,
            bool? dryRun = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.V2ImageReframeIdeogram3PostRequestBodyContentMultipartFormDataSchemaRenderingSpeed? renderingSpeed = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
            global::Ideogram.IdeogramColorPalette? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? styleReferenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? styleReferenceImagesFileNames = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}