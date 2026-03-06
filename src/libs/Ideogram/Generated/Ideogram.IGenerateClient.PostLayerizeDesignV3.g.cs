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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(

            global::Ideogram.LayerizeDesignRequestV3 request,
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
        /// <param name="requestedFontFile">
        /// A font name from the available font library to use for text rendering. When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with uploaded_font_file.<br/>
        /// Example: Ubuntu-Regular.ttf
        /// </param>
        /// <param name="uploadedFontFile">
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </param>
        /// <param name="uploadedFontFilename">
        /// A custom font file to use for text rendering. Supported formats are .ttf, .otf, .woff, and .woff2 (max size 5MB). When provided, font matching is skipped and this font is used for all text layers. Cannot be used together with requested_font_file.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostLayerizeDesignV3Async(
            byte[] flatGraphicImage,
            string flatGraphicImagename,
            string? prompt = default,
            int? seed = default,
            string? requestedFontFile = default,
            byte[]? uploadedFontFile = default,
            string? uploadedFontFilename = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}