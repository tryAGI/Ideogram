#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Layerize an existing flat graphic image with text detection and correction<br/>
        /// Processes an existing flat graphic image to detect and correct text layers without generating a new image from scratch.<br/>
        /// The uploaded image is analyzed for text content, which is then removed and returned as structured text layers with font matching, sizing, and color information.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(

            global::Ideogram.LayerizeDesignRequestV3 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layerize an existing flat graphic image with text detection and correction<br/>
        /// Processes an existing flat graphic image to detect and correct text layers without generating a new image from scratch.<br/>
        /// The uploaded image is analyzed for text content, which is then removed and returned as structured text layers with font matching, sizing, and color information.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="flatGraphicImage">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="flatGraphicImagename">
        /// The flat graphic image to process for text detection and correction. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="prompt">
        /// An optional prompt to describe the image. If not provided, a prompt will be auto-generated from the image via captioning.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="fontFileH1">
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </param>
        /// <param name="fontFileH1name">
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </param>
        /// <param name="fontNameH1">
        /// Font name from the available font library for H1 text. Ignored if font_file_h1 is provided.<br/>
        /// Example: Ubuntu-Bold.ttf
        /// </param>
        /// <param name="fontFileH2">
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </param>
        /// <param name="fontFileH2name">
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </param>
        /// <param name="fontNameH2">
        /// Font name from the available font library for H2 text. Ignored if font_file_h2 is provided.
        /// </param>
        /// <param name="fontFileBody">
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </param>
        /// <param name="fontFileBodyname">
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </param>
        /// <param name="fontNameBody">
        /// Font name from the available font library for body text. Ignored if font_file_body is provided.
        /// </param>
        /// <param name="fontFileSmall">
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </param>
        /// <param name="fontFileSmallname">
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </param>
        /// <param name="fontNameSmall">
        /// Font name from the available font library for small text. Ignored if font_file_small is provided.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(
            byte[] flatGraphicImage,
            string flatGraphicImagename,
            string? prompt = default,
            int? seed = default,
            byte[]? fontFileH1 = default,
            string? fontFileH1name = default,
            string? fontNameH1 = default,
            byte[]? fontFileH2 = default,
            string? fontFileH2name = default,
            string? fontNameH2 = default,
            byte[]? fontFileBody = default,
            string? fontFileBodyname = default,
            string? fontNameBody = default,
            byte[]? fontFileSmall = default,
            string? fontFileSmallname = default,
            string? fontNameSmall = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}