
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request for batch magic prompt evalution.<br/>
    /// Example: {"user_prompts":["a cat","a dog"],"sampling_request_params":{"aspect_ratio":"1x1","style_type":"GENERAL","magic_prompt_version":"V_0","seed":12345,"negative_prompt":"brush strokes, painting","magic_prompt_option":"ON","model":"V_2_TURBO","resolution":"1280x800","num_images":1,"color_palette":{"name":"PASTEL"}},"experiment_variant":"MAGIC_PROMPT_NO_TEXT"}
    /// </summary>
    public sealed partial class InternalBatchRequest
    {
        /// <summary>
        /// The prompts to enhance with a magic prompt.<br/>
        /// Example: [a cat, a dog]
        /// </summary>
        /// <example>[a cat, a dog]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> UserPrompts { get; set; } = default!;

        /// <summary>
        /// The experiment variant used for template selection for the magic prompts.<br/>
        /// Example: MAGIC_PROMPT_NO_TEXT
        /// </summary>
        /// <example>MAGIC_PROMPT_NO_TEXT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_variant")]
        public string? ExperimentVariant { get; set; }

        /// <summary>
        /// Example: {"aspect_ratio":"1x1","style_type":"GENERAL","magic_prompt_version":"V_0","seed":12345,"negative_prompt":"brush strokes, painting","magic_prompt_option":"ON","model":"V_2_TURBO","resolution":"1280x800","num_images":1,"color_palette":{"name":"PASTEL"}}
        /// </summary>
        /// <example>{"aspect_ratio":"1x1","style_type":"GENERAL","magic_prompt_version":"V_0","seed":12345,"negative_prompt":"brush strokes, painting","magic_prompt_option":"ON","model":"V_2_TURBO","resolution":"1280x800","num_images":1,"color_palette":{"name":"PASTEL"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_request_params")]
        public global::Ideogram.SamplingRequestParams? SamplingRequestParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchRequest" /> class.
        /// </summary>
        /// <param name="userPrompts">
        /// The prompts to enhance with a magic prompt.<br/>
        /// Example: [a cat, a dog]
        /// </param>
        /// <param name="experimentVariant">
        /// The experiment variant used for template selection for the magic prompts.<br/>
        /// Example: MAGIC_PROMPT_NO_TEXT
        /// </param>
        /// <param name="samplingRequestParams">
        /// Example: {"aspect_ratio":"1x1","style_type":"GENERAL","magic_prompt_version":"V_0","seed":12345,"negative_prompt":"brush strokes, painting","magic_prompt_option":"ON","model":"V_2_TURBO","resolution":"1280x800","num_images":1,"color_palette":{"name":"PASTEL"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalBatchRequest(
            global::System.Collections.Generic.IList<string> userPrompts,
            string? experimentVariant,
            global::Ideogram.SamplingRequestParams? samplingRequestParams)
        {
            this.UserPrompts = userPrompts ?? throw new global::System.ArgumentNullException(nameof(userPrompts));
            this.ExperimentVariant = experimentVariant;
            this.SamplingRequestParams = samplingRequestParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalBatchRequest" /> class.
        /// </summary>
        public InternalBatchRequest()
        {
        }
    }
}