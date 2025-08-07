#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Edit with Ideogram 3.0<br/>
        /// Edit a given image synchronously using the provided mask with Ideogram 3.0. The mask indicates which part of the image<br/>
        /// should be edited, while the prompt and chosen style can further guide the edit.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostEditImageV3Async(
            global::Ideogram.EditImageRequestV3 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit with Ideogram 3.0<br/>
        /// Edit a given image synchronously using the provided mask with Ideogram 3.0. The mask indicates which part of the image<br/>
        /// should be edited, while the prompt and chosen style can further guide the edit.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image being edited (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image being edited (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A black and white image of the same size as the image being edited (max size 10MB). Black regions in the mask should match up with the regions of the image that you would like to edit; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="maskname">
        /// A black and white image of the same size as the image being edited (max size 10MB). Black regions in the mask should match up with the regions of the image that you would like to edit; only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="prompt">
        /// The prompt used to describe the edited result.<br/>
        /// Example: A photo of a cat.
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
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
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
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
        /// <param name="characterReferenceImages">
        /// A set of images to use as character references (maximum total size 10MB across all character references). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="characterReferenceImagesMask">
        /// Optional masks for character reference images. When provided, must match the number of character_reference_images. Each mask should be a grayscale image of the same dimensions as the corresponding character reference image. The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostEditImageV3Async(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            string prompt,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.StyleTypeV3? styleType = default,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette = default,
            global::System.Collections.Generic.IList<string>? styleCodes = default,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages = default,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImagesMask = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}