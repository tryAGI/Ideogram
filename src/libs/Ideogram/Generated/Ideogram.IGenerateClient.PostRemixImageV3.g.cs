#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Remix with Ideogram 3.0<br/>
        /// Remix provided images synchronously based on a given prompt and optional parameters with the Ideogram 3.0 model.<br/>
        /// Input images are cropped to the chosen aspect ratio before being remixed.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostRemixImageV3Async(
            global::Ideogram.RemixImageRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remix with Ideogram 3.0<br/>
        /// Remix provided images synchronously based on a given prompt and optional parameters with the Ideogram 3.0 model.<br/>
        /// Input images are cropped to the chosen aspect ratio before being remixed.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image to remix binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image to remix binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="prompt">
        /// The prompt to use to generate the image.<br/>
        /// Example: A photo of a cat
        /// </param>
        /// <param name="imageWeight">
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for model version V_3.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: BALANCED
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from an image. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
        /// <param name="styleCodes">
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="styleReferenceImages">
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostRemixImageV3Async(
            byte[] image,
            string imagename,
            string prompt,
            int? imageWeight = default,
            int? seed = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? negativePrompt = default,
            int? numImages = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}