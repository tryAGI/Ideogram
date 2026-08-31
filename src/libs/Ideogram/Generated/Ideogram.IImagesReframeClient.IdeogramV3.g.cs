#nullable enable

namespace Ideogram
{
    public partial interface IImagesReframeClient
    {
        /// <summary>
        /// Reframe an image with Ideogram 3.0, by asset id or by uploaded bytes<br/>
        /// Expand an image to a new Ideogram 3.0 resolution. The source pixels<br/>
        /// are preserved in the center and Ideogram fills the new area. Supply<br/>
        /// exactly one source: an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or raw image bytes (`image`, multipart<br/>
        /// requests only). Supplying both forms, or neither, is rejected.<br/>
        /// Optional style controls are mutually exclusive. Supply at most one of<br/>
        /// `style_preset`, `style_codes`, `style_reference_asset_identifiers`, or<br/>
        /// raw `style_reference_images` (multipart requests only). Each style<br/>
        /// reference transport accepts at most 10 images.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately, then poll<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ReframeImageIdeogramV3Response> IdeogramV3Async(

            global::Ideogram.ReframeImageIdeogramV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Ideogram 3.0, by asset id or by uploaded bytes<br/>
        /// Expand an image to a new Ideogram 3.0 resolution. The source pixels<br/>
        /// are preserved in the center and Ideogram fills the new area. Supply<br/>
        /// exactly one source: an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or raw image bytes (`image`, multipart<br/>
        /// requests only). Supplying both forms, or neither, is rejected.<br/>
        /// Optional style controls are mutually exclusive. Supply at most one of<br/>
        /// `style_preset`, `style_codes`, `style_reference_asset_identifiers`, or<br/>
        /// raw `style_reference_images` (multipart requests only). Each style<br/>
        /// reference transport accepts at most 10 images.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately, then poll<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ReframeImageIdeogramV3Response>> IdeogramV3AsResponseAsync(

            global::Ideogram.ReframeImageIdeogramV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reframe an image with Ideogram 3.0, by asset id or by uploaded bytes<br/>
        /// Expand an image to a new Ideogram 3.0 resolution. The source pixels<br/>
        /// are preserved in the center and Ideogram fills the new area. Supply<br/>
        /// exactly one source: an `AssetIdentifier` reference<br/>
        /// (`image_asset_identifier`) or raw image bytes (`image`, multipart<br/>
        /// requests only). Supplying both forms, or neither, is rejected.<br/>
        /// Optional style controls are mutually exclusive. Supply at most one of<br/>
        /// `style_preset`, `style_codes`, `style_reference_asset_identifiers`, or<br/>
        /// raw `style_reference_images` (multipart requests only). Each style<br/>
        /// reference transport accepts at most 10 images.<br/>
        /// By default the request blocks until the images are ready and returns<br/>
        /// them in `data`. Set `async` to true to return immediately, then poll<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB), as raw bytes. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The JPEG, PNG, or WEBP image to reframe (max 25MB), as raw bytes. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
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
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: BRIGHT_ART
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceAssetIdentifiers">
        /// Existing upload or generated image assets to use as style references. Cannot be combined with a style preset, style codes, or uploaded style reference images.
        /// </param>
        /// <param name="styleReferenceImages">
        /// JPEG, PNG, or WEBP style reference images (max 10, max 25MB each), as raw bytes. Multipart requests only. Cannot be combined with a style preset, style codes, or referenced style assets.
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
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.ReframeImageIdeogramV3RequestRenderingSpeed? renderingSpeed = default,
            global::Ideogram.StylePresetV3? stylePreset = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<global::Ideogram.AssetIdentifier>? styleReferenceAssetIdentifiers = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            bool? async = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}