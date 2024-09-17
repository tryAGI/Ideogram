
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageRequest
    {
        /// <summary>
        /// The prompt to use to generate the image.<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// (Cannot be used in conjunction with resolution) The aspect ratio to use for image generation, which determines the image's resolution. Defaults to ASPECT_1_1.<br/>
        /// Example: ASPECT_10_16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioJsonConverter))]
        public global::Ideogram.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The model used to generate. Defaults to V_2.<br/>
        /// Default Value: V_2<br/>
        /// Example: V_2_TURBO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ModelEnumJsonConverter))]
        public global::Ideogram.ModelEnum? Model { get; set; } = global::Ideogram.ModelEnum.V2;

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPromptOption { get; set; } = global::Ideogram.MagicPromptOption.AUTO;

        /// <summary>
        /// Example: 12345
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The style type to generate with; this is only applicable for models V_2 and above and should not be specified for model versions V_1.<br/>
        /// Example: REALISTIC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.StyleTypeJsonConverter))]
        public global::Ideogram.StyleType? StyleType { get; set; }

        /// <summary>
        /// Description of what to exclude from an image. Descriptions in the prompt take precedence to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// (For model_version for 2.0 only, cannot be used in conjunction with aspect_ratio) The resolution to use for image generation, represented in width x height. If not specified, defaults to using aspect_ratio.<br/>
        /// Example: RESOLUTION_1024_1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionJsonConverter))]
        public global::Ideogram.Resolution? Resolution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}