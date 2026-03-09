
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// The response containing generated magic prompt<br/>
    /// Example: {"magic_prompt":"A photorealistic cat with striking green eyes, sitting gracefully on a vintage wooden chair. The cat\u0027s fur has beautiful orange and white markings, and soft natural lighting illuminates the scene from a nearby window."}
    /// </summary>
    public sealed partial class MagicPromptResponse
    {
        /// <summary>
        /// The generated magic prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magic_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string MagicPrompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptResponse" /> class.
        /// </summary>
        /// <param name="magicPrompt">
        /// The generated magic prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagicPromptResponse(
            string magicPrompt)
        {
            this.MagicPrompt = magicPrompt ?? throw new global::System.ArgumentNullException(nameof(magicPrompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptResponse" /> class.
        /// </summary>
        public MagicPromptResponse()
        {
        }
    }
}