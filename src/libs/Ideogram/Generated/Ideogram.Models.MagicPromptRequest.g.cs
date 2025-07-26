
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to generate a magic prompt
    /// </summary>
    public sealed partial class MagicPromptRequest
    {
        /// <summary>
        /// The prompt to enhance with a magic prompt<br/>
        /// Example: a cat
        /// </summary>
        /// <example>a cat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </summary>
        /// <example>V_0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptVersionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.MagicPromptVersionEnum MagicPromptVersion { get; set; }

        /// <summary>
        /// Whether to classify the prompt into a use case category.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </summary>
        /// <default>true</default>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classify_prompt_category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ClassifyPromptCategory { get; set; } = true;

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
        /// Random seed for reproducible generation<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A set of images to use as character references. The images should be in JPEG, PNG or WebP format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_reference_images")]
        public global::System.Collections.Generic.IList<byte[]>? CharacterReferenceImages { get; set; }

        /// <summary>
        /// A system prompt to use for the magic prompt.<br/>
        /// Example: You are a helpful assistant that generates magic prompts for images.
        /// </summary>
        /// <example>You are a helpful assistant that generates magic prompts for images.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to enhance with a magic prompt<br/>
        /// Example: a cat
        /// </param>
        /// <param name="magicPromptVersion">
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </param>
        /// <param name="classifyPromptCategory">
        /// Whether to classify the prompt into a use case category.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </param>
        /// <param name="styleType">
        /// The style type to generate with.<br/>
        /// Default Value: GENERAL<br/>
        /// Example: GENERAL
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation<br/>
        /// Example: 12345
        /// </param>
        /// <param name="characterReferenceImages">
        /// A set of images to use as character references. The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="systemPrompt">
        /// A system prompt to use for the magic prompt.<br/>
        /// Example: You are a helpful assistant that generates magic prompts for images.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagicPromptRequest(
            string prompt,
            global::Ideogram.MagicPromptVersionEnum magicPromptVersion,
            bool classifyPromptCategory,
            global::Ideogram.StyleTypeV3? styleType,
            int? seed,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages,
            string? systemPrompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MagicPromptVersion = magicPromptVersion;
            this.ClassifyPromptCategory = classifyPromptCategory;
            this.StyleType = styleType;
            this.Seed = seed;
            this.CharacterReferenceImages = characterReferenceImages;
            this.SystemPrompt = systemPrompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptRequest" /> class.
        /// </summary>
        public MagicPromptRequest()
        {
        }
    }
}