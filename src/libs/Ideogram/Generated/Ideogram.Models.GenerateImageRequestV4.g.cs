
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateImageRequestV4
    {
        /// <summary>
        /// The text prompt for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
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
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the model version and style will be resolved from this URI.<br/>
        /// Example: model/my-custom-model/version/0
        /// </summary>
        /// <example>model/my-custom-model/version/0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        public string? CustomModelUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt for image generation.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the model version and style will be resolved from this URI.<br/>
        /// Example: model/my-custom-model/version/0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestV4(
            string prompt,
            int? seed,
            global::Ideogram.MagicPromptOption? magicPromptOption,
            string? customModelUri)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Seed = seed;
            this.MagicPromptOption = magicPromptOption;
            this.CustomModelUri = customModelUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4" /> class.
        /// </summary>
        public GenerateImageRequestV4()
        {
        }
    }
}