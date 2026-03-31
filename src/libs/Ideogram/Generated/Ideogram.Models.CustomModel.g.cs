
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A custom model.<br/>
    /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","is_available_for_generation":true,"dataset_id":"dataset_id","name":"name","is_owned":true,"training_runs":[{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null},{"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}],"model_id":"model_id","custom_model_uri":"model/my-custom-model/version/1","status":null}
    /// </summary>
    public sealed partial class CustomModel
    {
        /// <summary>
        /// Unique identifier for the model (base64 URL-safe encoded UUID).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// Use this URI when generating images with this model. Only present for models<br/>
        /// that have been registered in the model registry.<br/>
        /// Example: model/my-custom-model/version/1
        /// </summary>
        /// <example>model/my-custom-model/version/1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_model_uri")]
        public string? CustomModelUri { get; set; }

        /// <summary>
        /// Display name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The status of a custom model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.ModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.ModelStatus Status { get; set; }

        /// <summary>
        /// ID of the dataset (collection) the model was trained from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// When the model was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// When the model was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_update_time")]
        public global::System.DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Whether the model is available for image generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_available_for_generation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAvailableForGeneration { get; set; }

        /// <summary>
        /// Whether the authenticated user owns this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_owned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOwned { get; set; }

        /// <summary>
        /// Training run history. Only populated on the get-by-ID endpoint and only for owned models.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_runs")]
        public global::System.Collections.Generic.IList<global::Ideogram.TrainingRun>? TrainingRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModel" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Unique identifier for the model (base64 URL-safe encoded UUID).
        /// </param>
        /// <param name="name">
        /// Display name of the model.
        /// </param>
        /// <param name="status">
        /// The status of a custom model.
        /// </param>
        /// <param name="creationTime">
        /// When the model was created.
        /// </param>
        /// <param name="isAvailableForGeneration">
        /// Whether the model is available for image generation.
        /// </param>
        /// <param name="isOwned">
        /// Whether the authenticated user owns this model.
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// Use this URI when generating images with this model. Only present for models<br/>
        /// that have been registered in the model registry.<br/>
        /// Example: model/my-custom-model/version/1
        /// </param>
        /// <param name="datasetId">
        /// ID of the dataset (collection) the model was trained from.
        /// </param>
        /// <param name="lastUpdateTime">
        /// When the model was last updated.
        /// </param>
        /// <param name="trainingRuns">
        /// Training run history. Only populated on the get-by-ID endpoint and only for owned models.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomModel(
            string modelId,
            string name,
            global::Ideogram.ModelStatus status,
            global::System.DateTime creationTime,
            bool isAvailableForGeneration,
            bool isOwned,
            string? customModelUri,
            string? datasetId,
            global::System.DateTime? lastUpdateTime,
            global::System.Collections.Generic.IList<global::Ideogram.TrainingRun>? trainingRuns)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.CustomModelUri = customModelUri;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.DatasetId = datasetId;
            this.CreationTime = creationTime;
            this.LastUpdateTime = lastUpdateTime;
            this.IsAvailableForGeneration = isAvailableForGeneration;
            this.IsOwned = isOwned;
            this.TrainingRuns = trainingRuns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomModel" /> class.
        /// </summary>
        public CustomModel()
        {
        }
    }
}