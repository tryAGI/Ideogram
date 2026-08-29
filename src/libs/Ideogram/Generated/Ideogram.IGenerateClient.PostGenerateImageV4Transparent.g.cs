#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generate with Ideogram 4.0 (Transparent Background)<br/>
        /// Generates images with a transparent background synchronously using the<br/>
        /// Ideogram 4.0 model. The result is delivered as a PNG with an alpha<br/>
        /// channel.<br/>
        /// All Ideogram 4.0 aspect ratios are supported, including `AUTO`, which<br/>
        /// lets the model select the most suitable ratio from the prompt.<br/>
        /// `output_resolution` selects the delivered resolution tier. Tiers are<br/>
        /// total-pixel budgets: wide and tall aspect ratios keep the same pixel<br/>
        /// budget as the square of the named size, so a single dimension may<br/>
        /// exceed it. The response reports the final delivered resolution.<br/>
        /// Image links are available for a limited period of time; if you would<br/>
        /// like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4TransparentAsync(

            global::Ideogram.GenerateTransparentImageRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0 (Transparent Background)<br/>
        /// Generates images with a transparent background synchronously using the<br/>
        /// Ideogram 4.0 model. The result is delivered as a PNG with an alpha<br/>
        /// channel.<br/>
        /// All Ideogram 4.0 aspect ratios are supported, including `AUTO`, which<br/>
        /// lets the model select the most suitable ratio from the prompt.<br/>
        /// `output_resolution` selects the delivered resolution tier. Tiers are<br/>
        /// total-pixel budgets: wide and tall aspect ratios keep the same pixel<br/>
        /// budget as the square of the named size, so a single dimension may<br/>
        /// exceed it. The response reports the final delivered resolution.<br/>
        /// Image links are available for a limited period of time; if you would<br/>
        /// like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostGenerateImageV4TransparentAsResponseAsync(

            global::Ideogram.GenerateTransparentImageRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate with Ideogram 4.0 (Transparent Background)<br/>
        /// Generates images with a transparent background synchronously using the<br/>
        /// Ideogram 4.0 model. The result is delivered as a PNG with an alpha<br/>
        /// channel.<br/>
        /// All Ideogram 4.0 aspect ratios are supported, including `AUTO`, which<br/>
        /// lets the model select the most suitable ratio from the prompt.<br/>
        /// `output_resolution` selects the delivered resolution tier. Tiers are<br/>
        /// total-pixel budgets: wide and tall aspect ratios keep the same pixel<br/>
        /// budget as the square of the named size, so a single dimension may<br/>
        /// exceed it. The response reports the final delivered resolution.<br/>
        /// Image links are available for a limited period of time; if you would<br/>
        /// like to keep the image, you must download it.
        /// </summary>
        /// <param name="textPrompt">
        /// A natural-language prompt for image generation. When supplied,<br/>
        /// magic-prompt is enabled automatically. Mutually exclusive with<br/>
        /// `json_prompt`.
        /// </param>
        /// <param name="jsonPrompt">
        /// A structured prompt that conforms to the Ideogram 4.0 JSON<br/>
        /// contract. When supplied, magic-prompt is disabled and the<br/>
        /// structured prompt is consumed by the diffusion model directly,<br/>
        /// except that `compositional_deconstruction.background` is replaced<br/>
        /// with a transparent-background directive. Mutually exclusive with<br/>
        /// `text_prompt`.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use<br/>
        /// for this request. Honored when `text_prompt` is supplied. Ignored<br/>
        /// when `json_prompt` is supplied.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio for an Ideogram 4.0 magic prompt. `AUTO` lets the<br/>
        /// model select the most suitable ratio from the prompt; any other value<br/>
        /// pins the ratio. The non-AUTO values are the buckets the 4.0 model<br/>
        /// supports.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="outputResolution">
        /// The output resolution tier for the generated image. Tiers are<br/>
        /// total-pixel budgets matching a square of the named size (for example,<br/>
        /// `8K` delivers at most 8192x8192 total pixels); wide and tall aspect<br/>
        /// ratios keep the same pixel budget, so a single dimension may exceed<br/>
        /// the named size. Defaults to 1K.<br/>
        /// Default Value: 1K
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. Defaults to DEFAULT.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). The effective gate is the OR of this field and the organization's<br/>
        /// `copyright_detection_enabled` setting on `/api`. See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4TransparentAsync(
            string? textPrompt = default,
            global::Ideogram.V4JsonPrompt? jsonPrompt = default,
            int? seed = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.AspectRatioV4? aspectRatio = default,
            global::Ideogram.OutputResolution? outputResolution = default,
            global::Ideogram.RenderingSpeedV4? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}