
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequestV3
    {
        /// <summary>
        /// The prompt to use to generate the image.<br/>
        /// Example: A photo of a cat
        /// </summary>
        /// <example>A photo of a cat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

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
        /// Default Value: BALANCED
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
        /// Description of what to exclude from an image. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </summary>
        /// <example>brush strokes, painting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Number of images to generate.<br/>
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
        /// Example: GENERAL
        /// </summary>
        /// <example>GENERAL</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StyleTypeV3JsonConverter))]
        public global::Ideogram.StyleTypeV3? StyleType { get; set; }

        /// <summary>
        /// A set of images to use as style references (maximum total size 10MB across all style references). The images should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? StyleReferenceImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV3" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use to generate the image.<br/>
        /// Example: A photo of a cat
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestV3(
            string prompt,
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
            global::System.Collections.Generic.IList<byte[]>? styleReferenceImages)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
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
            this.StyleReferenceImages = styleReferenceImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV3" /> class.
        /// </summary>
        public GenerateImageRequestV3()
        {
        }
    }
}