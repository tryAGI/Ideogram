#nullable enable

namespace Ideogram
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Train a custom Ideogram v3 model with advanced hyperparameters<br/>
        /// Start training a custom Ideogram v3 model from a dataset with caller-supplied hyperparameters (training steps, LoRA rank, EMA decay, learning rate). All hyperparameters are optional and fall back to defaults when omitted. The dataset must contain at least 15 images and a maximum of 100 images. Returns the model ID and training status.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainModelV3AdvancedAsync(

            global::Ideogram.TrainModelV3AdvancedRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a custom Ideogram v3 model with advanced hyperparameters<br/>
        /// Start training a custom Ideogram v3 model from a dataset with caller-supplied hyperparameters (training steps, LoRA rank, EMA decay, learning rate). All hyperparameters are optional and fall back to defaults when omitted. The dataset must contain at least 15 images and a maximum of 100 images. Returns the model ID and training status.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainModelV3AdvancedAsync(
            string datasetId,
            string modelName,
            int? trainingSteps = default,
            int? loraRank = default,
            double? ema = default,
            double? learningRate = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}