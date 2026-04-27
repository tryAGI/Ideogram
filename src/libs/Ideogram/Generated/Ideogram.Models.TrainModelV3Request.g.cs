
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Training request for a custom Ideogram v3 model using default hyperparameters.<br/>
    /// Example: {"model_name":"my-custom-model","dataset_id":"abc123"}
    /// </summary>
    public sealed partial class TrainModelV3Request
    {
        /// <summary>
        /// ID of the dataset to train the model from.<br/>
        /// Example: abc123
        /// </summary>
        /// <example>abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </summary>
        /// <example>my-custom-model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelV3Request" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// ID of the dataset to train the model from.<br/>
        /// Example: abc123
        /// </param>
        /// <param name="modelName">
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainModelV3Request(
            string datasetId,
            string modelName)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelV3Request" /> class.
        /// </summary>
        public TrainModelV3Request()
        {
        }
    }
}