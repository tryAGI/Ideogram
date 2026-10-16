
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Structured prompt for Ideogram 4.0 generation. When `json_prompt` is<br/>
    /// supplied, magic-prompt is disabled and the diffusion model consumes<br/>
    /// the JSON contract directly. Mutually exclusive with `text_prompt`<br/>
    /// and the legacy `prompt` field.
    /// </summary>
    public sealed partial class V4JsonPrompt
    {
        /// <summary>
        /// One- or two-sentence overall description of the desired image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_level_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HighLevelDescription { get; set; }

        /// <summary>
        /// Optional style description supplied alongside a V4 JSON prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_description")]
        public global::Ideogram.V4StyleDescription? StyleDescription { get; set; }

        /// <summary>
        /// The compositional breakdown of a V4 prompt — background plus an ordered list of elements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compositional_deconstruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.V4CompositionalDeconstruction CompositionalDeconstruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="V4JsonPrompt" /> class.
        /// </summary>
        /// <param name="highLevelDescription">
        /// One- or two-sentence overall description of the desired image.
        /// </param>
        /// <param name="compositionalDeconstruction">
        /// The compositional breakdown of a V4 prompt — background plus an ordered list of elements.
        /// </param>
        /// <param name="styleDescription">
        /// Optional style description supplied alongside a V4 JSON prompt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public V4JsonPrompt(
            string highLevelDescription,
            global::Ideogram.V4CompositionalDeconstruction compositionalDeconstruction,
            global::Ideogram.V4StyleDescription? styleDescription)
        {
            this.HighLevelDescription = highLevelDescription ?? throw new global::System.ArgumentNullException(nameof(highLevelDescription));
            this.StyleDescription = styleDescription;
            this.CompositionalDeconstruction = compositionalDeconstruction ?? throw new global::System.ArgumentNullException(nameof(compositionalDeconstruction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V4JsonPrompt" /> class.
        /// </summary>
        public V4JsonPrompt()
        {
        }

    }
}