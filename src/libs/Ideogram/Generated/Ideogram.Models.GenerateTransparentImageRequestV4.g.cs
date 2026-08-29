
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for Ideogram 4.0 transparent-background image generation.<br/>
    /// Supply exactly one of `text_prompt` or `json_prompt`. When<br/>
    /// `text_prompt` is supplied, magic-prompt is applied automatically. When<br/>
    /// `json_prompt` is supplied, magic-prompt is skipped and the structured<br/>
    /// prompt is consumed directly; its `compositional_deconstruction.background`<br/>
    /// is replaced with a transparent-background directive.
    /// </summary>
    public sealed partial class GenerateTransparentImageRequestV4
    {
        /// <summary>
        /// A natural-language prompt for image generation. When supplied,<br/>
        /// magic-prompt is enabled automatically. Mutually exclusive with<br/>
        /// `json_prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        public string? TextPrompt { get; set; }

        /// <summary>
        /// A structured prompt that conforms to the Ideogram 4.0 JSON<br/>
        /// contract. When supplied, magic-prompt is disabled and the<br/>
        /// structured prompt is consumed by the diffusion model directly,<br/>
        /// except that `compositional_deconstruction.background` is replaced<br/>
        /// with a transparent-background directive. Mutually exclusive with<br/>
        /// `text_prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_prompt")]
        public global::Ideogram.V4JsonPrompt? JsonPrompt { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored when `text_prompt` is supplied. Ignored<br/>
        /// when `json_prompt` is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// The aspect ratio for an Ideogram 4.0 magic prompt. `AUTO` lets the<br/>
        /// model select the most suitable ratio from the prompt; any other value<br/>
        /// pins the ratio. The non-AUTO values are the buckets the 4.0 model<br/>
        /// supports.<br/>
        /// Default Value: AUTO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV4JsonConverter))]
        public global::Ideogram.AspectRatioV4? AspectRatio { get; set; }

        /// <summary>
        /// The output resolution tier for the generated image. Tiers are<br/>
        /// total-pixel budgets matching a square of the named size (for example,<br/>
        /// `8K` delivers at most 8192x8192 total pixels); wide and tall aspect<br/>
        /// ratios keep the same pixel budget, so a single dimension may exceed<br/>
        /// the named size. Defaults to 1K.<br/>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.OutputResolutionJsonConverter))]
        public global::Ideogram.OutputResolution? OutputResolution { get; set; }

        /// <summary>
        /// The rendering speed to use. Defaults to DEFAULT.<br/>
        /// Default Value: DEFAULT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedV4JsonConverter))]
        public global::Ideogram.RenderingSpeedV4? RenderingSpeed { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTransparentImageRequestV4" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// A natural-language prompt for image generation. When supplied,<br/>
        /// magic-prompt is enabled automatically. Mutually exclusive with<br/>
        /// `json_prompt`.
        /// </param>
        /// <param name="jsonPrompt">
        /// A structured prompt that conforms to the Ideogram 4.0 JSON<br/>
        /// contract. When supplied, magic-prompt is disabled and the<br/>
        /// structured prompt is consumed by the diffusion model directly,<br/>
        /// except that `compositional_deconstruction.background` is replaced<br/>
        /// with a transparent-background directive. Mutually exclusive with<br/>
        /// `text_prompt`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored when `text_prompt` is supplied. Ignored<br/>
        /// when `json_prompt` is supplied.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 4.0 magic prompt. `AUTO` lets the<br/>
        /// model select the most suitable ratio from the prompt; any other value<br/>
        /// pins the ratio. The non-AUTO values are the buckets the 4.0 model<br/>
        /// supports.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution tier for the generated image. Tiers are<br/>
        /// total-pixel budgets matching a square of the named size (for example,<br/>
        /// `8K` delivers at most 8192x8192 total pixels); wide and tall aspect<br/>
        /// ratios keep the same pixel budget, so a single dimension may exceed<br/>
        /// the named size. Defaults to 1K.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. Defaults to DEFAULT.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateTransparentImageRequestV4(
            string? textPrompt,
            global::Ideogram.V4JsonPrompt? jsonPrompt,
            int? seed,
            string? magicPromptSystemPromptConfigId,
            global::Ideogram.AspectRatioV4? aspectRatio,
            global::Ideogram.OutputResolution? outputResolution,
            global::Ideogram.RenderingSpeedV4? renderingSpeed,
            bool? enableCopyrightDetection)
        {
            this.TextPrompt = textPrompt;
            this.JsonPrompt = jsonPrompt;
            this.Seed = seed;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.AspectRatio = aspectRatio;
            this.OutputResolution = outputResolution;
            this.RenderingSpeed = renderingSpeed;
            this.EnableCopyrightDetection = enableCopyrightDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTransparentImageRequestV4" /> class.
        /// </summary>
        public GenerateTransparentImageRequestV4()
        {
        }

    }
}