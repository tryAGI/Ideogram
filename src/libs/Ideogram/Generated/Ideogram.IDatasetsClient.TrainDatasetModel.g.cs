#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Train a model from a dataset<br/>
        /// Start training a custom model from a dataset. The dataset must contain at least 5 images. Returns the model ID and training status.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainDatasetModelAsync(
            string datasetId,

            global::Ideogram.TrainDatasetModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a model from a dataset<br/>
        /// Start training a custom model from a dataset. The dataset must contain at least 5 images. Returns the model ID and training status.
        /// </summary>
        /// <param name="datasetId"></param>
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
        /// Example: 0.999F
        /// </param>
        /// <param name="learningRate">
        /// Learning rate for the optimizer. Must be greater than 0.<br/>
        /// Example: 0.0001F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainDatasetModelAsync(
            string datasetId,
            string modelName,
            int? trainingSteps = default,
            int? loraRank = default,
            int? numChips = default,
            double? ema = default,
            double? learningRate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}