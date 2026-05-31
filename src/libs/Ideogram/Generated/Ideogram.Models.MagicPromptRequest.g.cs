
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to generate a magic prompt<br/>
    /// Example: {"prompt":"a cat","magic_prompt_version":"V_0_4","classify_prompt_category":true,"style_type":"AUTO","seed":12345}
    /// </summary>
    public sealed partial class MagicPromptRequest
    {
        /// <summary>
        /// The prompt to enhance with a magic prompt. Mutually<br/>
        /// exclusive with `messages`; one of the two must be set.<br/>
        /// Example: a cat
        /// </summary>
        /// <example>a cat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

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
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classify_prompt_category")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ClassifyPromptCategory { get; set; }

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
        /// Generations with character reference are subject to the character reference pricing. A set of images to use as character references (maximum total size 10MB across all character references), currently only supports 1 character reference image. The images should be in JPEG, PNG or WebP format.
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
        /// Optional target aspect ratio used to condition the generated<br/>
        /// magic prompt's framing. Forwarded to the autoprompt pipeline<br/>
        /// so registry-driven system prompts that interpolate<br/>
        /// `` see the bucket the caller intends.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV3JsonConverter))]
        public global::Ideogram.AspectRatioV3? AspectRatio { get; set; }

        /// <summary>
        /// Sampling temperature override. Defaults to the trainer-conditioned<br/>
        /// value when omitted (0.7 for V4_QWEN_3_5_27B). Only honored with<br/>
        /// V4 magic-prompt versions; supplying it with another version<br/>
        /// returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Nucleus-sampling top_p override. Only honored with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Top-k sampling override. Only honored with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// min_p sampling override. Only honored with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_p")]
        public float? MinP { get; set; }

        /// <summary>
        /// Cap on the number of tokens the model may generate. Defaults to<br/>
        /// 4096 (the trainer's reference cap) when omitted. Only honored<br/>
        /// with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Presence-penalty override. Only honored with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Frequency-penalty override. Only honored with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Repetition-penalty override. Only honored with V4 versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_penalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// Optional override of the LoRA adapter the V4 magic-prompt<br/>
        /// wrapper downloads and runs. Pass a `gs://` URI pointing at a<br/>
        /// checkpoint directory containing `adapter_config.json`. When<br/>
        /// omitted, the wrapper-preloaded production checkpoint is used.<br/>
        /// Only honored with the LoRA-fused `V4_QWEN_3_5_27B` version;<br/>
        /// supplying it with `V4_QWEN_3_5_27B_PREFUSED` (which serves<br/>
        /// pre-merged weights and cannot swap adapters per request) or<br/>
        /// any other version returns 400.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        public string? Checkpoint { get; set; }

        /// <summary>
        /// Pre-formed chat messages forwarded verbatim to V4. Mutually<br/>
        /// exclusive with `prompt`; exactly one must be set. V4 only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Ideogram.MagicPromptRequestMessagesInner>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptRequest" /> class.
        /// </summary>
        /// <param name="magicPromptVersion">
        /// The magic prompt version to use when magic prompt option is set to AUTO or ON.<br/>
        /// Example: V_0
        /// </param>
        /// <param name="classifyPromptCategory">
        /// Whether to classify the prompt into a use case category.<br/>
        /// Default Value: true<br/>
        /// Example: false
        /// </param>
        /// <param name="prompt">
        /// The prompt to enhance with a magic prompt. Mutually<br/>
        /// exclusive with `messages`; one of the two must be set.<br/>
        /// Example: a cat
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
        /// Generations with character reference are subject to the character reference pricing. A set of images to use as character references (maximum total size 10MB across all character references), currently only supports 1 character reference image. The images should be in JPEG, PNG or WebP format.
        /// </param>
        /// <param name="systemPrompt">
        /// A system prompt to use for the magic prompt.<br/>
        /// Example: You are a helpful assistant that generates magic prompts for images.
        /// </param>
        /// <param name="aspectRatio">
        /// Optional target aspect ratio used to condition the generated<br/>
        /// magic prompt's framing. Forwarded to the autoprompt pipeline<br/>
        /// so registry-driven system prompts that interpolate<br/>
        /// `` see the bucket the caller intends.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature override. Defaults to the trainer-conditioned<br/>
        /// value when omitted (0.7 for V4_QWEN_3_5_27B). Only honored with<br/>
        /// V4 magic-prompt versions; supplying it with another version<br/>
        /// returns 400.
        /// </param>
        /// <param name="topP">
        /// Nucleus-sampling top_p override. Only honored with V4 versions.
        /// </param>
        /// <param name="topK">
        /// Top-k sampling override. Only honored with V4 versions.
        /// </param>
        /// <param name="minP">
        /// min_p sampling override. Only honored with V4 versions.
        /// </param>
        /// <param name="maxTokens">
        /// Cap on the number of tokens the model may generate. Defaults to<br/>
        /// 4096 (the trainer's reference cap) when omitted. Only honored<br/>
        /// with V4 versions.
        /// </param>
        /// <param name="presencePenalty">
        /// Presence-penalty override. Only honored with V4 versions.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency-penalty override. Only honored with V4 versions.
        /// </param>
        /// <param name="repetitionPenalty">
        /// Repetition-penalty override. Only honored with V4 versions.
        /// </param>
        /// <param name="checkpoint">
        /// Optional override of the LoRA adapter the V4 magic-prompt<br/>
        /// wrapper downloads and runs. Pass a `gs://` URI pointing at a<br/>
        /// checkpoint directory containing `adapter_config.json`. When<br/>
        /// omitted, the wrapper-preloaded production checkpoint is used.<br/>
        /// Only honored with the LoRA-fused `V4_QWEN_3_5_27B` version;<br/>
        /// supplying it with `V4_QWEN_3_5_27B_PREFUSED` (which serves<br/>
        /// pre-merged weights and cannot swap adapters per request) or<br/>
        /// any other version returns 400.
        /// </param>
        /// <param name="messages">
        /// Pre-formed chat messages forwarded verbatim to V4. Mutually<br/>
        /// exclusive with `prompt`; exactly one must be set. V4 only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagicPromptRequest(
            global::Ideogram.MagicPromptVersionEnum magicPromptVersion,
            bool classifyPromptCategory,
            string? prompt,
            global::Ideogram.StyleTypeV3? styleType,
            int? seed,
            global::System.Collections.Generic.IList<byte[]>? characterReferenceImages,
            string? systemPrompt,
            global::Ideogram.AspectRatioV3? aspectRatio,
            float? temperature,
            float? topP,
            int? topK,
            float? minP,
            int? maxTokens,
            float? presencePenalty,
            float? frequencyPenalty,
            float? repetitionPenalty,
            string? checkpoint,
            global::System.Collections.Generic.IList<global::Ideogram.MagicPromptRequestMessagesInner>? messages)
        {
            this.Prompt = prompt;
            this.MagicPromptVersion = magicPromptVersion;
            this.ClassifyPromptCategory = classifyPromptCategory;
            this.StyleType = styleType;
            this.Seed = seed;
            this.CharacterReferenceImages = characterReferenceImages;
            this.SystemPrompt = systemPrompt;
            this.AspectRatio = aspectRatio;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.MinP = minP;
            this.MaxTokens = maxTokens;
            this.PresencePenalty = presencePenalty;
            this.FrequencyPenalty = frequencyPenalty;
            this.RepetitionPenalty = repetitionPenalty;
            this.Checkpoint = checkpoint;
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptRequest" /> class.
        /// </summary>
        public MagicPromptRequest()
        {
        }

    }
}