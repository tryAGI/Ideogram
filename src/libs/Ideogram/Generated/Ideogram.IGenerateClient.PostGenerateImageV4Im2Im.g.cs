#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Image-to-image with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model with an initial image as input.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4Im2ImAsync(

            global::Ideogram.GenerateImageRequestV4Im2Im request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-image with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model with an initial image as input.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostGenerateImageV4Im2ImAsResponseAsync(

            global::Ideogram.GenerateImageRequestV4Im2Im request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-image with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model with an initial image as input.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// The 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4Im2ImAsync(
            byte[] image,
            string imagename,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Image-to-image with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model with an initial image as input.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// The 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostGenerateImageV4Im2ImAsync(
            global::System.IO.Stream image,
            string imagename,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image-to-image with Ideogram 4.0<br/>
        /// Generates images synchronously using the Ideogram 4.0 model with an initial image as input.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="prompt">
        /// An optional text prompt to guide the generation.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPromptOption">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="resolution">
        /// The 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use. For Ideogram V4, `rendering_speed=FLASH`<br/>
        /// is coming soon; requests with `rendering_speed=FLASH` currently<br/>
        /// return a 400.
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostGenerateImageV4Im2ImAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPromptOption = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}