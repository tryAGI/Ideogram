
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to upscale a provided image with the help of an optional prompt.
    /// </summary>
    public sealed partial class UpscaleInitialImageRequest
    {
        /// <summary>
        /// An optional prompt to guide the upscale<br/>
        /// Example: A serene tropical beach scene. Dominating the foreground are tall palm trees with lush green leaves, standing tall against a backdrop of a sandy beach. The beach leads to the azure waters of the sea, which gently kisses the shoreline. In the distance, there is an island or landmass with a silhouette of what appears to be a lighthouse or tower. The sky above is painted with fluffy white clouds, some of which are tinged with hues of pink and orange, suggesting either a sunrise or sunset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resemblance")]
        public int Resemblance { get; set; } = 50;

        /// <summary>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public int Detail { get; set; } = 50;

        /// <summary>
        /// Determine if MagicPrompt should be used in generating the request or not<br/>
        /// Default Value: AUTO<br/>
        /// Example: ON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt_option")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.MagicPromptOptionJsonConverter))]
        public global::Ideogram.MagicPromptOption? MagicPromptOption { get; set; } = global::Ideogram.MagicPromptOption.AUTO;

        /// <summary>
        /// Example: 12345
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}