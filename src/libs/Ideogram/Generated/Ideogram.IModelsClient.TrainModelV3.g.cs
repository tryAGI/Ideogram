#nullable enable

namespace Ideogram
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Train a custom Ideogram v3 model<br/>
        /// Start training a custom Ideogram v3 model from a dataset using default hyperparameters. The dataset must contain at least 15 images and a maximum of 100 images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainModelV3Async(

            global::Ideogram.TrainModelV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a custom Ideogram v3 model<br/>
        /// Start training a custom Ideogram v3 model from a dataset using default hyperparameters. The dataset must contain at least 15 images and a maximum of 100 images.
        /// </summary>
        /// <param name="datasetId">
        /// ID of the dataset to train the model from.<br/>
        /// Example: abc123
        /// </param>
        /// <param name="modelName">
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainModelV3Async(
            string datasetId,
            string modelName,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}