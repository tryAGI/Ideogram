
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response for an Ideogram 4.0 describe request. The `json_prompt`<br/>
    /// field is a structured `V4JsonPrompt` that can be passed back as<br/>
    /// `json_prompt` to the `/v1/ideogram-v4/generate` family of endpoints.<br/>
    /// Example: {"json_prompt":{"high_level_description":"high_level_description","style_description":{"photo":"photo","art_style":"art_style","medium":"medium","aesthetics":"aesthetics","lighting":"lighting","color_palette":["#FFD700","#FFD700"]},"compositional_deconstruction":{"background":"background","elements":[{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]},{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]}]},"tags":["tags","tags"]}}
    /// </summary>
    public sealed partial class DescribeResponseV4
    {
        /// <summary>
        /// Structured prompt for Ideogram 4.0 generation. When `json_prompt` is<br/>
        /// supplied, magic-prompt is disabled and the diffusion model consumes<br/>
        /// the JSON contract directly. Mutually exclusive with `text_prompt`<br/>
        /// and the legacy `prompt` field.<br/>
        /// Example: {"high_level_description":"high_level_description","style_description":{"photo":"photo","art_style":"art_style","medium":"medium","aesthetics":"aesthetics","lighting":"lighting","color_palette":["#FFD700","#FFD700"]},"compositional_deconstruction":{"background":"background","elements":[{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]},{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]}]},"tags":["tags","tags"]}
        /// </summary>
        /// <example>{"high_level_description":"high_level_description","style_description":{"photo":"photo","art_style":"art_style","medium":"medium","aesthetics":"aesthetics","lighting":"lighting","color_palette":["#FFD700","#FFD700"]},"compositional_deconstruction":{"background":"background","elements":[{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]},{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]}]},"tags":["tags","tags"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V4JsonPrompt JsonPrompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeResponseV4" /> class.
        /// </summary>
        /// <param name="jsonPrompt">
        /// Structured prompt for Ideogram 4.0 generation. When `json_prompt` is<br/>
        /// supplied, magic-prompt is disabled and the diffusion model consumes<br/>
        /// the JSON contract directly. Mutually exclusive with `text_prompt`<br/>
        /// and the legacy `prompt` field.<br/>
        /// Example: {"high_level_description":"high_level_description","style_description":{"photo":"photo","art_style":"art_style","medium":"medium","aesthetics":"aesthetics","lighting":"lighting","color_palette":["#FFD700","#FFD700"]},"compositional_deconstruction":{"background":"background","elements":[{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]},{"bbox":[0,0,1000,1000],"type":"obj","desc":"desc","color_palette":["#FFD700","#FFD700"]}]},"tags":["tags","tags"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeResponseV4(
            global::Ideogram.V4JsonPrompt jsonPrompt)
        {
            this.JsonPrompt = jsonPrompt ?? throw new global::System.ArgumentNullException(nameof(jsonPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeResponseV4" /> class.
        /// </summary>
        public DescribeResponseV4()
        {
        }

    }
}