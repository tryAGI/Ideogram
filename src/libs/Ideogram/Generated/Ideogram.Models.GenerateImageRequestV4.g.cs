
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for Ideogram 4.0 image generation. Supply exactly one of<br/>
    /// `text_prompt` or `json_prompt`. When `text_prompt` is supplied,<br/>
    /// magic-prompt is applied automatically. When `json_prompt` is supplied,<br/>
    /// magic-prompt is skipped and the structured prompt is consumed<br/>
    /// directly.
    /// </summary>
    public sealed partial class GenerateImageRequestV4
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
        /// structured prompt is consumed by the diffusion model directly.<br/>
        /// Mutually exclusive with `text_prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_prompt")]
        public global::Ideogram.V4JsonPrompt? JsonPrompt { get; set; }

        /// <summary>
        /// Deprecated — use `text_prompt` for plain-text prompts or<br/>
        /// `json_prompt` for structured prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Deprecated — magic-prompt is now derived from the prompt input:<br/>
        /// `text_prompt` enables it, `json_prompt` disables it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPromptOption { get; set; }

        /// <summary>
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored when `text_prompt` is supplied. Ignored<br/>
        /// when `json_prompt` is supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// Deprecated — pin a registered magic-prompt system prompt via<br/>
        /// `magic_prompt_system_prompt_config_id` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter))]
        public global::Ideogram.MagicPromptVersionEnum? MagicPromptVersion { get; set; }

        /// <summary>
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the model version and style will be resolved from this URI.<br/>
        /// Example: model/my-custom-model/version/0
        /// </summary>
        /// <example>model/my-custom-model/version/0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        public string? CustomModelUri { get; set; }

        /// <summary>
        /// The 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </summary>
        /// <example>2048x2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter))]
        public global::Ideogram.ResolutionV4? Resolution { get; set; }

        /// <summary>
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendering_speed")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.RenderingSpeedJsonConverter))]
        public global::Ideogram.RenderingSpeed? RenderingSpeed { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// A natural-language prompt for image generation. When supplied,<br/>
        /// magic-prompt is enabled automatically. Mutually exclusive with<br/>
        /// `json_prompt`.
        /// </param>
        /// <param name="jsonPrompt">
        /// A structured prompt that conforms to the Ideogram 4.0 JSON<br/>
        /// contract. When supplied, magic-prompt is disabled and the<br/>
        /// structured prompt is consumed by the diffusion model directly.<br/>
        /// Mutually exclusive with `text_prompt`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored when `text_prompt` is supplied. Ignored<br/>
        /// when `json_prompt` is supplied.
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the model version and style will be resolved from this URI.<br/>
        /// Example: model/my-custom-model/version/0
        /// </param>
        /// <param name="resolution">
        /// The 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestV4(
            string? textPrompt,
            global::Ideogram.V4JsonPrompt? jsonPrompt,
            int? seed,
            string? magicPromptSystemPromptConfigId,
            string? customModelUri,
            global::Ideogram.ResolutionV4? resolution,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            bool? enableCopyrightDetection)
        {
            this.TextPrompt = textPrompt;
            this.JsonPrompt = jsonPrompt;
            this.Seed = seed;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.CustomModelUri = customModelUri;
            this.Resolution = resolution;
            this.RenderingSpeed = renderingSpeed;
            this.EnableCopyrightDetection = enableCopyrightDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4" /> class.
        /// </summary>
        public GenerateImageRequestV4()
        {
        }

    }
}