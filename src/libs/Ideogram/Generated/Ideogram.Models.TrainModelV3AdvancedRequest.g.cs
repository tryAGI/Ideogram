
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Advanced training request for a custom Ideogram v3 model. Hyperparameters are optional and fall back to defaults when omitted.<br/>
    /// Example: {"model_name":"my-custom-model","lora_rank":64,"dataset_id":"abc123","ema":0.999,"training_steps":1000,"learning_rate":0.0001}
    /// </summary>
    public sealed partial class TrainModelV3AdvancedRequest
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
        /// Number of training steps. Must be between 100 and 10000 and a multiple of 100. Defaults to 1000.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// LoRA rank for model training. Must be one of 64 or 128. Defaults to 128. Higher rank increases model capacity at the cost of longer training and larger weights.<br/>
        /// Example: 64
        /// </summary>
        /// <example>64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// Exponential moving average decay rate for the model weights. Must be between 0 and 1 (exclusive). Typical values are 0.99-0.9999; higher values produce smoother weight averages but respond more slowly to training updates.<br/>
        /// Example: 0.999F
        /// </summary>
        /// <example>0.999F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ema")]
        public double? Ema { get; set; }

        /// <summary>
        /// Learning rate for the optimizer. Must be greater than 0. Typical values for LoRA fine-tuning are 1e-5 to 1e-4; larger values train faster but risk instability.<br/>
        /// Example: 0.0001F
        /// </summary>
        /// <example>0.0001F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelV3AdvancedRequest" /> class.
        /// </summary>
        /// <param name="datasetId">
        /// ID of the dataset to train the model from.<br/>
        /// Example: abc123
        /// </param>
        /// <param name="modelName">
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </param>
        /// <param name="trainingSteps">
        /// Number of training steps. Must be between 100 and 10000 and a multiple of 100. Defaults to 1000.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank for model training. Must be one of 64 or 128. Defaults to 128. Higher rank increases model capacity at the cost of longer training and larger weights.<br/>
        /// Example: 64
        /// </param>
        /// <param name="ema">
        /// Exponential moving average decay rate for the model weights. Must be between 0 and 1 (exclusive). Typical values are 0.99-0.9999; higher values produce smoother weight averages but respond more slowly to training updates.<br/>
        /// Example: 0.999F
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for the optimizer. Must be greater than 0. Typical values for LoRA fine-tuning are 1e-5 to 1e-4; larger values train faster but risk instability.<br/>
        /// Example: 0.0001F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainModelV3AdvancedRequest(
            string datasetId,
            string modelName,
            int? trainingSteps,
            int? loraRank,
            double? ema,
            double? learningRate)
        {
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.TrainingSteps = trainingSteps;
            this.LoraRank = loraRank;
            this.Ema = ema;
            this.LearningRate = learningRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainModelV3AdvancedRequest" /> class.
        /// </summary>
        public TrainModelV3AdvancedRequest()
        {
        }
    }
}