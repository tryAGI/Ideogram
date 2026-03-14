
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateGraphicRequestV3
    {
        /// <summary>
        /// The prompt to use to generate the graphic.<br/>
        /// Example: A birthday card saying 'Happy Birthday'
        /// </summary>
        /// <example>A birthday card saying 'Happy Birthday'</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </summary>
        /// <example>1280x800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        public global::Ideogram.ResolutionV3? Resolution { get; set; }

        /// <summary>
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPrompt { get; set; }

        /// <summary>
        /// Description of what to exclude from a graphic. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </summary>
        /// <example>brush strokes, painting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Number of graphics to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter))]
        public global::Ideogram.ColorPaletteWithPresetNameOrMembers? ColorPalette { get; set; }

        /// <summary>
        /// A list of 8 character hexadecimal codes representing the style of the image. Cannot be used in conjunction with style_reference_images or style_type.<br/>
        /// Example: [AAFF5733, 0133FF57, DE3357FF]
        /// </summary>
        /// <example>[AAFF5733, 0133FF57, DE3357FF]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_codes")]
        public global::System.Collections.Generic.IList<string>? StyleCodes { get; set; }

        /// <summary>
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </summary>
        /// <example>GENERAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter))]
        public global::Ideogram.StyleTypeV3? StyleType { get; set; }

        /// <summary>
        /// A predefined style preset that applies a specific artistic style to the generated image.<br/>
        /// Example: BRIGHT_ART
        /// </summary>
        /// <example>BRIGHT_ART</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StylePresetV3JsonConverter))]
        public global::Ideogram.StylePresetV3? StylePreset { get; set; }

        /// <summary>
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;. <br/>
        /// When provided, the model version and style will be resolved from this URI, and style_type is not required.<br/>
        /// Example: model/my-custom-model/version/1
        /// </summary>
        /// <example>model/my-custom-model/version/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        public string? CustomModelUri { get; set; }

        /// <summary>
        /// An existing flat graphic image to process for text detection and correction without generating a new image. When provided, image generation is bypassed. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flat_graphic_image")]
        public byte[]? FlatGraphicImage { get; set; }

        /// <summary>
        /// An existing flat graphic image to process for text detection and correction without generating a new image. When provided, image generation is bypassed. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flat_graphic_imagename")]
        public string? FlatGraphicImagename { get; set; }

        /// <summary>
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h1")]
        public byte[]? FontFileH1 { get; set; }

        /// <summary>
        /// Custom font file for H1 (heading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h1name")]
        public string? FontFileH1name { get; set; }

        /// <summary>
        /// Font name from the available font library for H1 text. Ignored if font_file_h1 is provided.<br/>
        /// Example: Ubuntu-Bold.ttf
        /// </summary>
        /// <example>Ubuntu-Bold.ttf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_h1")]
        public string? FontNameH1 { get; set; }

        /// <summary>
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h2")]
        public byte[]? FontFileH2 { get; set; }

        /// <summary>
        /// Custom font file for H2 (subheading) text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_h2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_h2name")]
        public string? FontFileH2name { get; set; }

        /// <summary>
        /// Font name from the available font library for H2 text. Ignored if font_file_h2 is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_h2")]
        public string? FontNameH2 { get; set; }

        /// <summary>
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_body")]
        public byte[]? FontFileBody { get; set; }

        /// <summary>
        /// Custom font file for body text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_bodyname")]
        public string? FontFileBodyname { get; set; }

        /// <summary>
        /// Font name from the available font library for body text. Ignored if font_file_body is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_body")]
        public string? FontNameBody { get; set; }

        /// <summary>
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_small")]
        public byte[]? FontFileSmall { get; set; }

        /// <summary>
        /// Custom font file for small/caption text. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB). Takes priority over font_name_small.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_file_smallname")]
        public string? FontFileSmallname { get; set; }

        /// <summary>
        /// Font name from the available font library for small text. Ignored if font_file_small is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_name_small")]
        public string? FontNameSmall { get; set; }

        /// <summary>
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// A set of asset images (e.g., logos, icons) to use as references for detection and replacement (maximum 10 images). The images should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_asset_images")]
        public global::System.Collections.Generic.IList<byte[]>? ReferenceAssetImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateGraphicRequestV3" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use to generate the graphic.<br/>
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
        /// Description of what to exclude from a graphic. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="numImages">
        /// Number of graphics to generate.<br/>
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
        /// <param name="flatGraphicImage">
        /// An existing flat graphic image to process for text detection and correction without generating a new image. When provided, image generation is bypassed. The image should be in JPEG, PNG or WebP format (max size 10MB).
        /// </param>
        /// <param name="flatGraphicImagename">
        /// An existing flat graphic image to process for text detection and correction without generating a new image. When provided, image generation is bypassed. The image should be in JPEG, PNG or WebP format (max size 10MB).
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateGraphicRequestV3(
            string? prompt,
            int? seed,
            global::Ideogram.ResolutionV3? resolution,
            global::Ideogram.AspectRatioV3? aspectRatio,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            global::Ideogram.MagicPromptOption? magicPrompt,
            string? negativePrompt,
            int? numImages,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette,
            global::System.Collections.Generic.IList<string>? styleCodes,
            global::Ideogram.StyleTypeV3? styleType,
            global::Ideogram.StylePresetV3? stylePreset,
            string? customModelUri,
            byte[]? flatGraphicImage,
            string? flatGraphicImagename,
            byte[]? fontFileH1,
            string? fontFileH1name,
            string? fontNameH1,
            byte[]? fontFileH2,
            string? fontFileH2name,
            string? fontNameH2,
            byte[]? fontFileBody,
            string? fontFileBodyname,
            string? fontNameBody,
            byte[]? fontFileSmall,
            string? fontFileSmallname,
            string? fontNameSmall,
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages,
            global::System.Collections.Generic.IList<byte[]>? referenceAssetImages)
        {
            this.Prompt = prompt;
            this.Seed = seed;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.RenderingSpeed = renderingSpeed;
            this.MagicPrompt = magicPrompt;
            this.NegativePrompt = negativePrompt;
            this.NumImages = numImages;
            this.ColorPalette = colorPalette;
            this.StyleCodes = styleCodes;
            this.StyleType = styleType;
            this.StylePreset = stylePreset;
            this.CustomModelUri = customModelUri;
            this.FlatGraphicImage = flatGraphicImage;
            this.FlatGraphicImagename = flatGraphicImagename;
            this.FontFileH1 = fontFileH1;
            this.FontFileH1name = fontFileH1name;
            this.FontNameH1 = fontNameH1;
            this.FontFileH2 = fontFileH2;
            this.FontFileH2name = fontFileH2name;
            this.FontNameH2 = fontNameH2;
            this.FontFileBody = fontFileBody;
            this.FontFileBodyname = fontFileBodyname;
            this.FontNameBody = fontNameBody;
            this.FontFileSmall = fontFileSmall;
            this.FontFileSmallname = fontFileSmallname;
            this.FontNameSmall = fontNameSmall;
            this.StyleReferenceImages = styleReferenceImages;
            this.ReferenceAssetImages = referenceAssetImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateGraphicRequestV3" /> class.
        /// </summary>
        public GenerateGraphicRequestV3()
        {
        }
    }
}