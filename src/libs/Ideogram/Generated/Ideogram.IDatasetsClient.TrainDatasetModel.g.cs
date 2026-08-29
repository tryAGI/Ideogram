#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Train a model from a dataset<br/>
        /// Start training a custom model from a dataset. The dataset must contain at least 15 images and a maximum of 100 images. Returns the model ID and training status.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainDatasetModelAsync(
            string datasetId,

            global::Ideogram.TrainDatasetModelRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a model from a dataset<br/>
        /// Start training a custom model from a dataset. The dataset must contain at least 15 images and a maximum of 100 images. Returns the model ID and training status.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.TrainDatasetModelResponse>> TrainDatasetModelAsResponseAsync(
            string datasetId,

            global::Ideogram.TrainDatasetModelRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Train a model from a dataset<br/>
        /// Start training a custom model from a dataset. The dataset must contain at least 15 images and a maximum of 100 images. Returns the model ID and training status.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="modelName">
        /// Name for the trained model. Must be 5-30 characters, alphanumeric with spaces and hyphens allowed.<br/>
        /// Example: my-custom-model
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.TrainDatasetModelResponse> TrainDatasetModelAsync(
            string datasetId,
            string modelName,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}