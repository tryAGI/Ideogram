
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A training run for a custom model.<br/>
    /// Example: {"creation_time":"2000-01-23T04:56:07\u002B00:00","last_update_time":"2000-01-23T04:56:07\u002B00:00","lora_rank":6,"num_chips":1,"training_run_id":"training_run_id","ema":5.962133916683182,"training_steps":0,"learning_rate":5.637376656633329,"status":null}
    /// </summary>
    public sealed partial class TrainingRun
    {
        /// <summary>
        /// Unique identifier for the training run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingRunId { get; set; }

        /// <summary>
        /// The status of a training run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.JsonConverters.TrainingRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ideogram.TrainingRunStatus Status { get; set; }

        /// <summary>
        /// Number of training steps configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_steps")]
        public int? TrainingSteps { get; set; }

        /// <summary>
        /// LoRA rank used for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// Number of TPU chips used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_chips")]
        public int? NumChips { get; set; }

        /// <summary>
        /// Exponential moving average decay rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ema")]
        public double? Ema { get; set; }

        /// <summary>
        /// Learning rate for the optimizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// When the training run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// When the training run was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_update_time")]
        public global::System.DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRun" /> class.
        /// </summary>
        /// <param name="trainingRunId">
        /// Unique identifier for the training run.
        /// </param>
        /// <param name="status">
        /// The status of a training run.
        /// </param>
        /// <param name="creationTime">
        /// When the training run was created.
        /// </param>
        /// <param name="trainingSteps">
        /// Number of training steps configured.
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank used for training.
        /// </param>
        /// <param name="numChips">
        /// Number of TPU chips used.
        /// </param>
        /// <param name="ema">
        /// Exponential moving average decay rate.
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for the optimizer.
        /// </param>
        /// <param name="lastUpdateTime">
        /// When the training run was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingRun(
            string trainingRunId,
            global::Ideogram.TrainingRunStatus status,
            global::System.DateTime creationTime,
            int? trainingSteps,
            int? loraRank,
            int? numChips,
            double? ema,
            double? learningRate,
            global::System.DateTime? lastUpdateTime)
        {
            this.TrainingRunId = trainingRunId ?? throw new global::System.ArgumentNullException(nameof(trainingRunId));
            this.Status = status;
            this.TrainingSteps = trainingSteps;
            this.LoraRank = loraRank;
            this.NumChips = numChips;
            this.Ema = ema;
            this.LearningRate = learningRate;
            this.CreationTime = creationTime;
            this.LastUpdateTime = lastUpdateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingRun" /> class.
        /// </summary>
        public TrainingRun()
        {
        }
    }
}