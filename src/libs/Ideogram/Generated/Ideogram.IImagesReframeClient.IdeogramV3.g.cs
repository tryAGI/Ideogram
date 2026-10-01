#nullable enable

namespace Ideogram
{
    public partial interface IImagesReframeClient
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageIdeogramV3Response> IdeogramV3Async(

            global::Ideogram.ReframeImageIdeogramV3Request request,
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageIdeogramV3Response>> IdeogramV3AsResponseAsync(

            global::Ideogram.ReframeImageIdeogramV3Request request,
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
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB). Multipart requests only.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
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
        /// Default Value: default
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: bright_art
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members).
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8-character hexadecimal codes representing the style of the image. Refer to each endpoint for supported combinations with style types, presets, and reference images.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references. Cannot be combined with a style preset, style codes, or uploaded style reference images.
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
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageIdeogramV3Response> IdeogramV3Async(
            global::Ideogram.ResolutionV3 resolution,
            bool? dryRun = default,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.IdeogramV3StylePreset? stylePreset = default,
            global::Ideogram.IdeogramColorPalette? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}