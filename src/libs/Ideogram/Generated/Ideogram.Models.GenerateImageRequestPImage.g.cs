
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for the distilled few-step Ideogram generate endpoints. The<br/>
    /// speed/quality tier is selected by the URL path, not this body. Supply a<br/>
    /// `prompt`: either natural language or a structured Ideogram 4.0 JSON prompt<br/>
    /// (the server detects which). The base model is always the distilled<br/>
    /// few-step Ideogram model; a custom registry model cannot be selected on<br/>
    /// these endpoints.
    /// </summary>
    public sealed partial class GenerateImageRequestPImage
    {
        /// <summary>
        /// The prompt for image generation. Accepts either natural language or<br/>
        /// a structured prompt that conforms to the Ideogram 4.0 JSON contract;<br/>
        /// the server detects which was supplied. See `prompt_upsampling` for<br/>
        /// how magic-prompt is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls magic-prompt (prompt upsampling). `AUTO` (default) applies<br/>
        /// magic-prompt to a natural-language `prompt` or a non-Ideogram 4.0 JSON<br/>
        /// `prompt`, and skips it when `prompt` is already a structured Ideogram<br/>
        /// 4.0 JSON prompt. `ON` always applies magic-prompt, even to an Ideogram<br/>
        /// 4.0 JSON prompt; `OFF` never applies it. Defaults to `AUTO`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_upsampling")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? PromptUpsampling { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored only when magic-prompt runs (a<br/>
        /// natural-language `prompt` with `prompt_upsampling` AUTO or ON).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </summary>
        /// <example>2048x2048</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter))]
        public global::Ideogram.ResolutionV4? Resolution { get; set; }

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
        /// Initializes a new instance of the <see cref="GenerateImageRequestPImage" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for image generation. Accepts either natural language or<br/>
        /// a structured prompt that conforms to the Ideogram 4.0 JSON contract;<br/>
        /// the server detects which was supplied. See `prompt_upsampling` for<br/>
        /// how magic-prompt is applied.
        /// </param>
        /// <param name="promptUpsampling">
        /// Controls magic-prompt (prompt upsampling). `AUTO` (default) applies<br/>
        /// magic-prompt to a natural-language `prompt` or a non-Ideogram 4.0 JSON<br/>
        /// `prompt`, and skips it when `prompt` is already a structured Ideogram<br/>
        /// 4.0 JSON prompt. `ON` always applies magic-prompt, even to an Ideogram<br/>
        /// 4.0 JSON prompt; `OFF` never applies it. Defaults to `AUTO`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored only when magic-prompt runs (a<br/>
        /// natural-language `prompt` with `prompt_upsampling` AUTO or ON).
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestPImage(
            string prompt,
            global::Ideogram.MagicPromptOption? promptUpsampling,
            int? seed,
            string? magicPromptSystemPromptConfigId,
            global::Ideogram.ResolutionV4? resolution,
            bool? enableCopyrightDetection)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.PromptUpsampling = promptUpsampling;
            this.Seed = seed;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.Resolution = resolution;
            this.EnableCopyrightDetection = enableCopyrightDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestPImage" /> class.
        /// </summary>
        public GenerateImageRequestPImage()
        {
        }

    }
}