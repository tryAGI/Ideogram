#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Reframe a square image to a chosen resolution with Ideogram 3.0. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostReframeImageV3Async(
            global::Ideogram.ReframeImageRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reframe with Ideogram 3.0<br/>
        /// Reframe a square image to a chosen resolution with Ideogram 3.0. The supported image formats include JPEG, PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image being reframed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image being reframed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for model version V_3.<br/>
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
        /// The rendering speed to use.<br/>
        /// Default Value: BALANCED
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleReferenceImages">
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostReframeImageV3Async(
            byte[] image,
            string imagename,
            global::Ideogram.ResolutionV3 resolution,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}