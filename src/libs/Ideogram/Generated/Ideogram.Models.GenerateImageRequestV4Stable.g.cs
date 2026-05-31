
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Request body for the stable Ideogram 4.0 endpoint. Supply exactly one<br/>
    /// of `text_prompt` or `json_prompt`. The model URI is pinned<br/>
    /// server-side. When `resolution` is omitted, the server chooses an<br/>
    /// aspect ratio automatically.
    /// </summary>
    public sealed partial class GenerateImageRequestV4Stable
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
        /// Random seed for reproducibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional. When supplied, the image is generated at this<br/>
        /// resolution. When omitted, the server picks an aspect ratio<br/>
        /// automatically based on the prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ResolutionV4JsonConverter))]
        public global::Ideogram.ResolutionV4? Resolution { get; set; }

        /// <summary>
        /// Optional. Selects a specific pinned stable build. When omitted,<br/>
        /// the default stable model URI is used. When set to `stable_may29`,<br/>
        /// the request is routed to the May 29th stable build.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.GenerateImageRequestV4StableVersionJsonConverter))]
        public global::Ideogram.GenerateImageRequestV4StableVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4Stable" /> class.
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
        /// <param name="resolution">
        /// Optional. When supplied, the image is generated at this<br/>
        /// resolution. When omitted, the server picks an aspect ratio<br/>
        /// automatically based on the prompt.
        /// </param>
        /// <param name="version">
        /// Optional. Selects a specific pinned stable build. When omitted,<br/>
        /// the default stable model URI is used. When set to `stable_may29`,<br/>
        /// the request is routed to the May 29th stable build.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateImageRequestV4Stable(
            string? textPrompt,
            global::Ideogram.V4JsonPrompt? jsonPrompt,
            int? seed,
            global::Ideogram.ResolutionV4? resolution,
            global::Ideogram.GenerateImageRequestV4StableVersion? version)
        {
            this.TextPrompt = textPrompt;
            this.JsonPrompt = jsonPrompt;
            this.Seed = seed;
            this.Resolution = resolution;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateImageRequestV4Stable" /> class.
        /// </summary>
        public GenerateImageRequestV4Stable()
        {
        }

    }
}