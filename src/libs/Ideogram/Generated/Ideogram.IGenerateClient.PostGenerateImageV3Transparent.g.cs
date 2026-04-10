#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 3.0 (Transparent Background)<br/>
        /// Generates images with transparent background synchronously based on a given prompt and optional parameters using<br/>
        /// the Ideogram 3.0 model. Images will be generated using maximum supported resolution at the specified aspect ratio<br/>
        /// to allow best results with upscaler. The selected resolution is written to the response, not the upscaled final<br/>
        /// resolution.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostGenerateImageV3TransparentAsync(

            global::Ideogram.GenerateTransparentImageRequestV3 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 3.0 (Transparent Background)<br/>
        /// Generates images with transparent background synchronously based on a given prompt and optional parameters using<br/>
        /// the Ideogram 3.0 model. Images will be generated using maximum supported resolution at the specified aspect ratio<br/>
        /// to allow best results with upscaler. The selected resolution is written to the response, not the upscaled final<br/>
        /// resolution.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to use to generate the image.<br/>
        /// Example: A photo of a cat
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="upscaleFactor">
        /// Upscale the initially generated image by the given factor. Upscale factors other than X1 will incur additional cost.<br/>
        /// Default Value: X1<br/>
        /// Example: X2
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="negativePrompt">
        /// Description of what to exclude from an image. Descriptions in the prompt take precedence<br/>
        /// to descriptions in the negative prompt.<br/>
        /// Example: brush strokes, painting
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customModelUri">
        /// A custom model URI in the format model/&lt;model_name&gt;/version/&lt;version_name&gt;. <br/>
        /// When provided, the model version and style will be resolved from this URI, and style_type is not required.<br/>
        /// A model must be able to generate transparent background to be used for this endpoint.<br/>
        /// Example: model/my-custom-model/version/1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV3> PostGenerateImageV3TransparentAsync(
            string prompt,
            int? seed = default,
            global::Ideogram.UpscaleFactor? upscaleFactor = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? negativePrompt = default,
            int? numImages = default,
            string? customModelUri = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}