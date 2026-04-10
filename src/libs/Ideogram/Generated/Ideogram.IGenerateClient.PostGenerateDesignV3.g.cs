#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate a design from a text prompt with text detection and correction<br/>
        /// Generates a design synchronously from a text prompt using the Ideogram 3.0 model, then detects and corrects text layers within the generated image.<br/>
        /// The response includes the generated image URL along with detected text layers (with font, size, color, position) and image asset layers.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostGenerateDesignV3Async(

            global::Ideogram.GenerateDesignRequestV3 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a design from a text prompt with text detection and correction<br/>
        /// Generates a design synchronously from a text prompt using the Ideogram 3.0 model, then detects and corrects text layers within the generated image.<br/>
        /// The response includes the generated image URL along with detected text layers (with font, size, color, position) and image asset layers.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use to generate the design.<br/>
        /// Example: A birthday card saying 'Happy Birthday'
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from a design. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="numImages">
        /// Number of designs to generate.<br/>
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
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="stylePreset">
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: BRIGHT_ART
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;. <br/>
        /// When provided, the model version and style will be resolved from this URI, and style_type is not required.<br/>
        /// Example: model/my-custom-model/version/1
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
        /// <param name="styleReferenceImages">
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="referenceAssetImages">
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayeredImageGenerationResponseV3> PostGenerateDesignV3Async(
            string prompt,
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
            global::Ideogram.StylePresetV3? stylePreset = default,
            string? customModelUri = default,
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
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages = default,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}