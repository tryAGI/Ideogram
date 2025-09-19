
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SamplingRequestParams
    {
        /// <summary>
        /// Example: 1x1
        /// </summary>
        /// <example>1x1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// The model used to generate an image or edit one. /generate and /remix supports all model types, however, /edit is only supported for V_2 and V_2_TURBO.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </summary>
        /// <example>V_2_TURBO</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ModelEnumJsonConverter))]
        public global::Ideogram.ModelEnum? Model { get; set; }

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPromptOption { get; set; }

        /// <summary>
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </summary>
        /// <example>V_0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter))]
        public global::Ideogram.MagicPromptVersionEnum? MagicPromptVersion { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Only available for model versions V_1, V_1_TURBO, V_2 and V_2_TURBO. Description of what to exclude from an image. Descriptions in the prompt take precedence to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </summary>
        /// <example>brush strokes, painting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </summary>
        /// <example>1280x800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV3JsonConverter))]
        public global::Ideogram.ResolutionV3? Resolution { get; set; }

        /// <summary>
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_palette")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ColorPaletteWithPresetNameOrMembersJsonConverter))]
        public global::Ideogram.ColorPaletteWithPresetNameOrMembers? ColorPalette { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamplingRequestParams" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// Example: 1x1
        /// </param>
        /// <param name="model">
        /// The model used to generate an image or edit one. /generate and /remix supports all model types, however, /edit is only supported for V_2 and V_2_TURBO.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptVersion">
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="negativePrompt">
        /// Only available for model versions V_1, V_1_TURBO, V_2 and V_2_TURBO. Description of what to exclude from an image. Descriptions in the prompt take precedence to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="colorPalette">
        /// A color palette for generation, must EITHER be specified via one of the presets (name) or explicitly via hexadecimal representations of the color with optional weights (members). Not supported by V_1, V_1_TURBO, V_2A and V_2A_TURBO models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamplingRequestParams(
            global::Ideogram.AspectRatioV3? aspectRatio,
            global::Ideogram.ModelEnum? model,
            global::Ideogram.MagicPromptOption? magicPromptOption,
            global::Ideogram.MagicPromptVersionEnum? magicPromptVersion,
            int? seed,
            global::Ideogram.StyleTypeV3? styleType,
            string? negativePrompt,
            int? numImages,
            global::Ideogram.ResolutionV3? resolution,
            global::Ideogram.ColorPaletteWithPresetNameOrMembers? colorPalette)
        {
            this.AspectRatio = aspectRatio;
            this.Model = model;
            this.MagicPromptOption = magicPromptOption;
            this.MagicPromptVersion = magicPromptVersion;
            this.Seed = seed;
            this.StyleType = styleType;
            this.NegativePrompt = negativePrompt;
            this.NumImages = numImages;
            this.Resolution = resolution;
            this.ColorPalette = colorPalette;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamplingRequestParams" /> class.
        /// </summary>
        public SamplingRequestParams()
        {
        }
    }
}