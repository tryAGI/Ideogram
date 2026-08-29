
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to generate an Ideogram 4.0 magic prompt.<br/>
    /// Example: {"text_prompt":"a cat","aspect_ratio":"AUTO"}
    /// </summary>
    public sealed partial class MagicPromptV4Request
    {
        /// <summary>
        /// The natural-language prompt to enhance into an Ideogram 4.0 magic<br/>
        /// prompt. Named `text_prompt` to match the Ideogram 4.0 generate<br/>
        /// request surface.<br/>
        /// Example: a cat
        /// </summary>
        /// <example>a cat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Target aspect ratio. Defaults to `AUTO`, which lets the model<br/>
        /// select the most suitable ratio and return it in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.AspectRatioV4JsonConverter))]
        public global::Ideogram.AspectRatioV4? AspectRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptV4Request" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// The natural-language prompt to enhance into an Ideogram 4.0 magic<br/>
        /// prompt. Named `text_prompt` to match the Ideogram 4.0 generate<br/>
        /// request surface.<br/>
        /// Example: a cat
        /// </param>
        /// <param name="aspectRatio">
        /// Target aspect ratio. Defaults to `AUTO`, which lets the model<br/>
        /// select the most suitable ratio and return it in the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagicPromptV4Request(
            string textPrompt,
            global::Ideogram.AspectRatioV4? aspectRatio)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.AspectRatio = aspectRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagicPromptV4Request" /> class.
        /// </summary>
        public MagicPromptV4Request()
        {
        }

    }
}