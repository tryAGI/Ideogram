
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequestV4Im2Im
    {
        /// <summary>
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// An optional text prompt to guide the generation.
        /// </summary>
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
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </summary>
        /// <example>ON</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPromptOption { get; set; }

        /// <summary>
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_system_prompt_config_id")]
        public string? MagicPromptSystemPromptConfigId { get; set; }

        /// <summary>
        /// The resolutions supported for Ideogram 4.0 image-to-image generation.<br/>
        /// Example: 1024x1024
        /// </summary>
        /// <example>1024x1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4ImageToImageJsonConverter))]
        public global::Ideogram.ResolutionV4ImageToImage? Resolution { get; set; }

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
        /// checks). See GenerateImageRequestV3 for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_copyright_detection")]
        public bool? EnableCopyrightDetection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4Im2Im" /> class.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 4.0 image-to-image generation.<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestV4Im2Im(
            byte[] image,
            string imagename,
            string? prompt,
            int? seed,
            global::Ideogram.MagicPromptOption? magicPromptOption,
            string? magicPromptSystemPromptConfigId,
            global::Ideogram.ResolutionV4ImageToImage? resolution,
            global::Ideogram.RenderingSpeed? renderingSpeed,
            bool? enableCopyrightDetection)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt;
            this.Seed = seed;
            this.MagicPromptOption = magicPromptOption;
            this.MagicPromptSystemPromptConfigId = magicPromptSystemPromptConfigId;
            this.Resolution = resolution;
            this.RenderingSpeed = renderingSpeed;
            this.EnableCopyrightDetection = enableCopyrightDetection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4Im2Im" /> class.
        /// </summary>
        public GenerateImageRequestV4Im2Im()
        {
        }

    }
}