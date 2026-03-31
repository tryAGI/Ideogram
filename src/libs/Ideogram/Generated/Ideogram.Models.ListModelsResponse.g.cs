
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"models":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null}]}
    /// </summary>
    public sealed partial class ListModelsResponse
    {
        /// <summary>
        /// List of models.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ideogram.CustomModel> Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        /// <param name="models">
        /// List of models.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsResponse(
            global::System.Collections.Generic.IList<global::Ideogram.CustomModel> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        public ListModelsResponse()
        {
        }
    }
}