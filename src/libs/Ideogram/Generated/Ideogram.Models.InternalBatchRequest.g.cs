
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request for batch magic prompt evalution.
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
        public required global::System.Collections.Generic.IList<string> UserPrompts { get; set; }

        /// <summary>
        /// The experiment variant used for template selection for the magic prompts.<br/>
        /// Example: MAGIC_PROMPT_NO_TEXT
        /// </summary>
        /// <example>MAGIC_PROMPT_NO_TEXT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_variant")]
        public string? ExperimentVariant { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="samplingRequestParams"></param>
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