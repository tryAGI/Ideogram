
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for P-Image Ideogram. The model's quality and resolution<br/>
    /// tier are supplied as request parameters. The server selects the matching<br/>
    /// P-Image model variant; custom registry models cannot be selected.
    /// </summary>
    public sealed partial class GenerateImageRequestPImageIdeogram
    {
        /// <summary>
        /// The prompt for image generation. Accepts either natural language or<br/>
        /// a structured Ideogram 4.0 JSON prompt; the server detects which was supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Controls magic-prompt (prompt upsampling). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
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
        /// for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// The generation quality level. Defaults to `MEDIUM`.<br/>
        /// Default Value: MEDIUM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.QualityJsonConverter))]
        public global::Ideogram.Quality? Quality { get; set; }

        /// <summary>
        /// The output-size tier. Defaults to `1K`.<br/>
        /// Default Value: 1K
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.PImageResolutionJsonConverter))]
        public global::Ideogram.PImageResolution? Resolution { get; set; }

        /// <summary>
        /// The output aspect ratio. Defaults to `1x1`.<br/>
        /// Default Value: 1x1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// Optional. An exact output width in pixels, used together with<br/>
        /// `custom_height` for output sizes outside the preset tiers. Must be<br/>
        /// a positive multiple of 16 between 16 and 4096, and<br/>
        /// `custom_width` × `custom_height` must not exceed 4,194,304 pixels<br/>
        /// (2048×2048). Cannot be combined with `resolution` or<br/>
        /// `aspect_ratio`; the request is billed at the resolution tier<br/>
        /// matching its total pixel count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_width")]
        public int? CustomWidth { get; set; }

        /// <summary>
        /// Optional. An exact output height in pixels, used together with<br/>
        /// `custom_width`. See `custom_width` for the accepted range and<br/>
        /// billing behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_height")]
        public int? CustomHeight { get; set; }

        /// <summary>
        /// Optional. Opt this request into post-generation copyright detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestPImageIdeogram" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt for image generation. Accepts either natural language or<br/>
        /// a structured Ideogram 4.0 JSON prompt; the server detects which was supplied.
        /// </param>
        /// <param name="promptUpsampling">
        /// Controls magic-prompt (prompt upsampling). Defaults to `AUTO`.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request.
        /// </param>
        /// <param name="quality">
        /// The generation quality level. Defaults to `MEDIUM`.<br/>
        /// Default Value: MEDIUM
        /// </param>
        /// <param name="resolution">
        /// The output-size tier. Defaults to `1K`.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="aspectRatio">
        /// The output aspect ratio. Defaults to `1x1`.<br/>
        /// Default Value: 1x1
        /// </param>
        /// <param name="customWidth">
        /// Optional. An exact output width in pixels, used together with<br/>
        /// `custom_height` for output sizes outside the preset tiers. Must be<br/>
        /// a positive multiple of 16 between 16 and 4096, and<br/>
        /// `custom_width` × `custom_height` must not exceed 4,194,304 pixels<br/>
        /// (2048×2048). Cannot be combined with `resolution` or<br/>
        /// `aspect_ratio`; the request is billed at the resolution tier<br/>
        /// matching its total pixel count.
        /// </param>
        /// <param name="customHeight">
        /// Optional. An exact output height in pixels, used together with<br/>
        /// `custom_width`. See `custom_width` for the accepted range and<br/>
        /// billing behavior.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestPImageIdeogram(
            string prompt,
            global::Ideogram.MagicPromptOption? promptUpsampling,
            int? seed,
            string? magicPromptSystemPromptConfigId,
            global::Ideogram.Quality? quality,
            global::Ideogram.PImageResolution? resolution,
            global::Ideogram.AspectRatioV3? aspectRatio,
            int? customWidth,
            int? customHeight,
            bool? enableCopyrightDetection)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.PromptUpsampling = promptUpsampling;
            this.Seed = seed;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.Quality = quality;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.CustomWidth = customWidth;
            this.CustomHeight = customHeight;
            this.EnableCopyrightDetection = enableCopyrightDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestPImageIdeogram" /> class.
        /// </summary>
        public GenerateImageRequestPImageIdeogram()
        {
        }

    }
}