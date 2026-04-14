#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4Async(

            global::Ideogram.GenerateImageRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The text prompt for image generation.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;.<br/>
        /// When provided, the model version and style will be resolved from this URI.<br/>
        /// Example: model/my-custom-model/version/0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4Async(
            string prompt,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? customModelUri = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}