#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Edit with Ideogram V2<br/>
        /// Edit one or more images using a text prompt. Provide images via file upload<br/>
        /// or Ideogram image URLs, and describe the desired edit in your prompt.<br/>
        /// Unlike inpainting (/v1/ideogram-v3/inpaint), no mask is required. The model interprets the<br/>
        /// prompt to determine what to change.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.EditImageGenerationResponseV3> PostEditImageV2V3Async(

            global::Ideogram.EditImageV2RequestV3 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit with Ideogram V2<br/>
        /// Edit one or more images using a text prompt. Provide images via file upload<br/>
        /// or Ideogram image URLs, and describe the desired edit in your prompt.<br/>
        /// Unlike inpainting (/v1/ideogram-v3/inpaint), no mask is required. The model interprets the<br/>
        /// prompt to determine what to change.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the desired edit.<br/>
        /// Example: Change the background to a beach sunset.
        /// </param>
        /// <param name="images">
        /// Images to edit (max 10 images, max size 10MB each); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imageUrls">
        /// URLs to Ideogram images to use as references (max 10). Supports URLs from generation responses and image uploads. Alternative to uploading via the images field.
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="magicPrompt">
        /// Determine if MagicPrompt should be used in generating the request or not.<br/>
        /// Example: ON
        /// </param>
        /// <param name="resolution">
        /// The resolutions supported for Ideogram 3.0.<br/>
        /// Example: 1280x800
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio to use for image generation, which determines the image's resolution. Cannot be used in conjunction with resolution. Defaults to 1x1.
        /// </param>
        /// <param name="transparentBackground">
        /// Whether the output should have a transparent background. Default false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.EditImageGenerationResponseV3> PostEditImageV2V3Async(
            string prompt,
            global::System.Collections.Generic.IList<byte[]>? images = default,
            global::System.Collections.Generic.IList<string>? imageUrls = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            global::Ideogram.ResolutionV3? resolution = default,
            global::Ideogram.AspectRatioV3? aspectRatio = default,
            bool? transparentBackground = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}