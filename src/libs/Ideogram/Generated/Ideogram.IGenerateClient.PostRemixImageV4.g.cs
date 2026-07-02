#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Remix with Ideogram 4.0<br/>
        /// Remix an image synchronously using the Ideogram 4.0 model with an initial image and a prompt.<br/>
        /// Mirrors `/v1/ideogram-v3/remix` semantics (including `image_weight` for how strongly the<br/>
        /// output should resemble the input image) but routes the request through the V_4_0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostRemixImageV4Async(

            global::Ideogram.RemixImageRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.0<br/>
        /// Remix an image synchronously using the Ideogram 4.0 model with an initial image and a prompt.<br/>
        /// Mirrors `/v1/ideogram-v3/remix` semantics (including `image_weight` for how strongly the<br/>
        /// output should resemble the input image) but routes the request through the V_4_0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostRemixImageV4AsResponseAsync(

            global::Ideogram.RemixImageRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.0<br/>
        /// Remix an image synchronously using the Ideogram 4.0 model with an initial image and a prompt.<br/>
        /// Mirrors `/v1/ideogram-v3/remix` semantics (including `image_weight` for how strongly the<br/>
        /// output should resemble the input image) but routes the request through the V_4_0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostRemixImageV4Async(
            byte[] image,
            string imagename,
            string textPrompt,
            int? imageWeight = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remix with Ideogram 4.0<br/>
        /// Remix an image synchronously using the Ideogram 4.0 model with an initial image and a prompt.<br/>
        /// Mirrors `/v1/ideogram-v3/remix` semantics (including `image_weight` for how strongly the<br/>
        /// output should resemble the input image) but routes the request through the V_4_0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ImageGenerationResponseV4> PostRemixImageV4Async(
            global::System.IO.Stream image,
            string imagename,
            string textPrompt,
            int? imageWeight = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remix with Ideogram 4.0<br/>
        /// Remix an image synchronously using the Ideogram 4.0 model with an initial image and a prompt.<br/>
        /// Mirrors `/v1/ideogram-v3/remix` semantics (including `image_weight` for how strongly the<br/>
        /// output should resemble the input image) but routes the request through the V_4_0 model.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The initial image binary (max 10MB); only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="textPrompt">
        /// The text prompt that guides the remix.
        /// </param>
        /// <param name="imageWeight">
        /// Optional. How strongly the output should resemble the input image. Higher values keep<br/>
        /// the input image's structure; lower values allow the prompt to drive the output more.<br/>
        /// When omitted, the weight is chosen automatically from the edit instruction; supplying<br/>
        /// a value overrides that automatic choice.
        /// </param>
        /// <param name="resolution">
        /// The 1K and 2K resolutions supported for Ideogram 4.0 image generation.<br/>
        /// Example: 2048x2048
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="enableCopyrightDetection">
        /// Optional. Opt this request into post-generation copyright detection (Hive likeness + logo<br/>
        /// checks). See GenerateImageRequestV3 for details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ImageGenerationResponseV4>> PostRemixImageV4AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            string textPrompt,
            int? imageWeight = default,
            global::Ideogram.ResolutionV4? resolution = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            bool? enableCopyrightDetection = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}