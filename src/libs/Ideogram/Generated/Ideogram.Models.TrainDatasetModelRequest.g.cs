
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// Example: {"model_name":"my-custom-model","lora_rank":64,"num_chips":16,"ema":0.999,"training_steps":1000,"learning_rate":0.0001}
    /// </summary>
    public sealed partial class TrainDatasetModelRequest
    {
        /// <summary>
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </summary>
        /// <example>my-custom-model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Number of training steps. Must be between 100 and 20000 and a multiple of 100. Defaults to 1000.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// LoRA rank for model training. Must be one of 64, 128, or 256. Defaults to 128. Note: lora_rank &gt; 128 requires num_chips &gt;= 32.<br/>
        /// Example: 64
        /// </summary>
        /// <example>64</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// Number of TPU chips to use. Must be one of 16 or 32.<br/>
        /// Example: 16
        /// </summary>
        /// <example>16</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_chips")]
        public int? NumChips { get; set; }

        /// <summary>
        /// Exponential moving average decay rate. Must be greater than 0.<br/>
        /// Example: 0.999
        /// </summary>
        /// <example>0.999</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ema")]
        public double? Ema { get; set; }

        /// <summary>
        /// Learning rate for the optimizer. Must be greater than 0.<br/>
        /// Example: 0.0001
        /// </summary>
        /// <example>0.0001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainDatasetModelRequest" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </param>
        /// <param name="trainingSteps">
        /// Number of training steps. Must be between 100 and 20000 and a multiple of 100. Defaults to 1000.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank for model training. Must be one of 64, 128, or 256. Defaults to 128. Note: lora_rank &gt; 128 requires num_chips &gt;= 32.<br/>
        /// Example: 64
        /// </param>
        /// <param name="numChips">
        /// Number of TPU chips to use. Must be one of 16 or 32.<br/>
        /// Example: 16
        /// </param>
        /// <param name="ema">
        /// Exponential moving average decay rate. Must be greater than 0.<br/>
        /// Example: 0.999
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for the optimizer. Must be greater than 0.<br/>
        /// Example: 0.0001
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainDatasetModelRequest(
            string modelName,
            int? trainingSteps,
            int? loraRank,
            int? numChips,
            double? ema,
            double? learningRate)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.TrainingSteps = trainingSteps;
            this.LoraRank = loraRank;
            this.NumChips = numChips;
            this.Ema = ema;
            this.LearningRate = learningRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainDatasetModelRequest" /> class.
        /// </summary>
        public TrainDatasetModelRequest()
        {
        }
    }
}