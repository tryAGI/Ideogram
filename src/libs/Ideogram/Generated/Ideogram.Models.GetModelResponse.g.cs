
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"model":{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null}}
    /// </summary>
    public sealed partial class GetModelResponse
    {
        /// <summary>
        /// A custom model.<br/>
        /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null}
        /// </summary>
        /// <example>{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.CustomModel Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// A custom model.<br/>
        /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetModelResponse(
            global::Ideogram.CustomModel model)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse" /> class.
        /// </summary>
        public GetModelResponse()
        {
        }
    }
}