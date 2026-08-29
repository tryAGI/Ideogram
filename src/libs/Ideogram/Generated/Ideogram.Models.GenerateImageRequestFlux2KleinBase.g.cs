
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for the undistilled FLUX.2-Klein base generate endpoint (50-step quality tier). The base model is<br/>
    /// pinned server-side; supply `custom_model_uri` to layer a registered<br/>
    /// FLUX.2-Klein LoRA finetune on the base.<br/>
    /// Width and height must each be a positive multiple of 16; the total<br/>
    /// area must not exceed 1,048,576 pixels (1024×1024). When `width` and<br/>
    /// `height` are omitted, the server uses the model's default 1024×1024.
    /// </summary>
    public sealed partial class GenerateImageRequestFlux2KleinBase
    {
        /// <summary>
        /// A natural-language prompt for image generation.<br/>
        /// Example: A photo of a tabby cat sleeping on a couch, soft daylight.
        /// </summary>
        /// <example>A photo of a tabby cat sleeping on a couch, soft daylight.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// An optional system prompt applied alongside the prompt — use it for<br/>
        /// standing instructions such as style constraints or "do not render<br/>
        /// text". When omitted, no system prompt is applied. If you trained a<br/>
        /// LoRA with a system prompt, supply the same one here for best results.<br/>
        /// Example: Do not include any text in the image.
        /// </summary>
        /// <example>Do not include any text in the image.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Output width in pixels; must be a positive multiple of 16.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Output height in pixels; must be a positive multiple of 16.<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Optional diffusion step count. When omitted, the server uses the<br/>
        /// model's default. Higher values trade latency for quality.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the URI must resolve to a registered fine-tune of the<br/>
        /// FLUX.2-Klein base model; the fine-tune's LoRA checkpoint is layered<br/>
        /// on the base. When omitted, the FLUX.2-Klein base is used with no LoRA.<br/>
        /// Example: model/my-flux-klein-base-lora/version/0
        /// </summary>
        /// <example>model/my-flux-klein-base-lora/version/0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        public string? CustomModelUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestFlux2KleinBase" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A natural-language prompt for image generation.<br/>
        /// Example: A photo of a tabby cat sleeping on a couch, soft daylight.
        /// </param>
        /// <param name="systemPrompt">
        /// An optional system prompt applied alongside the prompt — use it for<br/>
        /// standing instructions such as style constraints or "do not render<br/>
        /// text". When omitted, no system prompt is applied. If you trained a<br/>
        /// LoRA with a system prompt, supply the same one here for best results.<br/>
        /// Example: Do not include any text in the image.
        /// </param>
        /// <param name="width">
        /// Output width in pixels; must be a positive multiple of 16.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="height">
        /// Output height in pixels; must be a positive multiple of 16.<br/>
        /// Example: 1024
        /// </param>
        /// <param name="numInferenceSteps">
        /// Optional diffusion step count. When omitted, the server uses the<br/>
        /// model's default. Higher values trade latency for quality.<br/>
        /// Example: 50
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the URI must resolve to a registered fine-tune of the<br/>
        /// FLUX.2-Klein base model; the fine-tune's LoRA checkpoint is layered<br/>
        /// on the base. When omitted, the FLUX.2-Klein base is used with no LoRA.<br/>
        /// Example: model/my-flux-klein-base-lora/version/0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestFlux2KleinBase(
            string prompt,
            string? systemPrompt,
            int? width,
            int? height,
            int? numInferenceSteps,
            int? seed,
            int? numImages,
            string? customModelUri)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.SystemPrompt = systemPrompt;
            this.Width = width;
            this.Height = height;
            this.NumInferenceSteps = numInferenceSteps;
            this.Seed = seed;
            this.NumImages = numImages;
            this.CustomModelUri = customModelUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestFlux2KleinBase" /> class.
        /// </summary>
        public GenerateImageRequestFlux2KleinBase()
        {
        }

    }
}