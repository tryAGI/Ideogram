
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"training_status":"training_status","model_name":"model_name","dataset_id":"dataset_id","model_id":"model_id"}
    /// </summary>
    public sealed partial class TrainDatasetModelResponse
    {
        /// <summary>
        /// Unique identifier of the created model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Identifier of the dataset used for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Current training status of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingStatus { get; set; }

        /// <summary>
        /// Name of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainDatasetModelResponse" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Unique identifier of the created model.
        /// </param>
        /// <param name="datasetId">
        /// Identifier of the dataset used for training.
        /// </param>
        /// <param name="trainingStatus">
        /// Current training status of the model.
        /// </param>
        /// <param name="modelName">
        /// Name of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainDatasetModelResponse(
            string modelId,
            string datasetId,
            string trainingStatus,
            string modelName)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.TrainingStatus = trainingStatus ?? throw new global::System.ArgumentNullException(nameof(trainingStatus));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainDatasetModelResponse" /> class.
        /// </summary>
        public TrainDatasetModelResponse()
        {
        }
    }
}