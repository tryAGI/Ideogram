
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response containing the generated Ideogram 4.0 magic prompt.<br/>
    /// Example: {"json_prompt":{"high_level_description":"A photorealistic ginger cat perched on a vintage wooden chair by a sunlit window.","style_description":{"aesthetics":"warm, cozy, nostalgic","lighting":"soft natural window light","medium":"photograph"},"compositional_deconstruction":{"background":"A dim room with a bright window casting warm light.","elements":[{"type":"obj","desc":"ginger cat with green eyes sitting upright on a vintage wooden chair"}]}},"aspect_ratio":"1x1"}
    /// </summary>
    public sealed partial class MagicPromptV4Response
    {
        /// <summary>
        /// The enhanced prompt as an Ideogram 4.0 structured JSON prompt. This<br/>
        /// conforms to the same contract as `json_prompt` on<br/>
        /// `/v1/ideogram-v4/generate`, so it can be passed straight back to<br/>
        /// that endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V4JsonPrompt JsonPrompt { get; set; }

        /// <summary>
        /// The resolved aspect ratio. When the request used `AUTO`, this is<br/>
        /// the ratio the model selected; otherwise it echoes the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.AspectRatioV4 AspectRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptV4Response" /> class.
        /// </summary>
        /// <param name="jsonPrompt">
        /// The enhanced prompt as an Ideogram 4.0 structured JSON prompt. This<br/>
        /// conforms to the same contract as `json_prompt` on<br/>
        /// `/v1/ideogram-v4/generate`, so it can be passed straight back to<br/>
        /// that endpoint.
        /// </param>
        /// <param name="aspectRatio">
        /// The resolved aspect ratio. When the request used `AUTO`, this is<br/>
        /// the ratio the model selected; otherwise it echoes the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagicPromptV4Response(
            global::Ideogram.V4JsonPrompt jsonPrompt,
            global::Ideogram.AspectRatioV4 aspectRatio)
        {
            this.JsonPrompt = jsonPrompt ?? throw new global::System.ArgumentNullException(nameof(jsonPrompt));
            this.AspectRatio = aspectRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptV4Response" /> class.
        /// </summary>
        public MagicPromptV4Response()
        {
        }

    }
}