#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Edit an image with a prompt at lower cost and latency<br/>
        /// Edit an image using a text prompt, optimized for lower cost and<br/>
        /// latency. Upload the image being edited via the `image` field. Up to 9<br/>
        /// additional `reference_images` may be supplied to guide the edit.<br/>
        /// Output is always generated at 1K resolution. Input images larger than<br/>
        /// 1024px on their long edge are downscaled before processing. The<br/>
        /// `aspect_ratio` field controls the output aspect ratio only; when<br/>
        /// omitted, the output follows the aspect ratio of the image being<br/>
        /// edited.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V1EditImagesResponse> PostV1EditLiteImageAsync(

            global::Ideogram.V1EditLiteImagesRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image with a prompt at lower cost and latency<br/>
        /// Edit an image using a text prompt, optimized for lower cost and<br/>
        /// latency. Upload the image being edited via the `image` field. Up to 9<br/>
        /// additional `reference_images` may be supplied to guide the edit.<br/>
        /// Output is always generated at 1K resolution. Input images larger than<br/>
        /// 1024px on their long edge are downscaled before processing. The<br/>
        /// `aspect_ratio` field controls the output aspect ratio only; when<br/>
        /// omitted, the output follows the aspect ratio of the image being<br/>
        /// edited.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.V1EditImagesResponse>> PostV1EditLiteImageAsResponseAsync(

            global::Ideogram.V1EditLiteImagesRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image with a prompt at lower cost and latency<br/>
        /// Edit an image using a text prompt, optimized for lower cost and<br/>
        /// latency. Upload the image being edited via the `image` field. Up to 9<br/>
        /// additional `reference_images` may be supplied to guide the edit.<br/>
        /// Output is always generated at 1K resolution. Input images larger than<br/>
        /// 1024px on their long edge are downscaled before processing. The<br/>
        /// `aspect_ratio` field controls the output aspect ratio only; when<br/>
        /// omitted, the output follows the aspect ratio of the image being<br/>
        /// edited.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the desired edit.<br/>
        /// Example: Remove the person from the photo.
        /// </param>
        /// <param name="image">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="referenceImages">
        /// Optional additional reference images to guide the edit (max 9, max size 25MB each); JPEG, WebP and PNG formats are supported.
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
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the edited output. When omitted, the output<br/>
        /// follows the aspect ratio of the image being edited.<br/>
        /// Example: 16x9
        /// </param>
        /// <param name="transparency">
        /// Controls whether the edited output has a transparent background.<br/>
        /// - `TRANSPARENT`: the output is produced with a transparent background.<br/>
        /// - `OPAQUE`: the output is produced with an opaque background.<br/>
        /// - `AUTO`: the server decides based on the prompt and the image being<br/>
        ///   edited (e.g. whether it already has a transparent background). This is<br/>
        ///   the default. When the prompt asks only for background removal, the<br/>
        ///   output may be the edited image with its background removed.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V1EditImagesResponse> PostV1EditLiteImageAsync(
            string prompt,
            byte[] image,
            string imagename,
            global::System.Collections.Generic.IList<byte[]>? referenceImages = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.AspectRatioEditLite? aspectRatio = default,
            global::Ideogram.TransparencyOption? transparency = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Edit an image with a prompt at lower cost and latency<br/>
        /// Edit an image using a text prompt, optimized for lower cost and<br/>
        /// latency. Upload the image being edited via the `image` field. Up to 9<br/>
        /// additional `reference_images` may be supplied to guide the edit.<br/>
        /// Output is always generated at 1K resolution. Input images larger than<br/>
        /// 1024px on their long edge are downscaled before processing. The<br/>
        /// `aspect_ratio` field controls the output aspect ratio only; when<br/>
        /// omitted, the output follows the aspect ratio of the image being<br/>
        /// edited.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the desired edit.<br/>
        /// Example: Remove the person from the photo.
        /// </param>
        /// <param name="image">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="referenceImages">
        /// Optional additional reference images to guide the edit (max 9, max size 25MB each); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="referenceImagesFileNames">
        /// Optional file names to use for the multipart 'reference_images' file parts.
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
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the edited output. When omitted, the output<br/>
        /// follows the aspect ratio of the image being edited.<br/>
        /// Example: 16x9
        /// </param>
        /// <param name="transparency">
        /// Controls whether the edited output has a transparent background.<br/>
        /// - `TRANSPARENT`: the output is produced with a transparent background.<br/>
        /// - `OPAQUE`: the output is produced with an opaque background.<br/>
        /// - `AUTO`: the server decides based on the prompt and the image being<br/>
        /// edited (e.g. whether it already has a transparent background). This is<br/>
        /// the default. When the prompt asks only for background removal, the<br/>
        /// output may be the edited image with its background removed.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V1EditImagesResponse> PostV1EditLiteImageAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? referenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? referenceImagesFileNames = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.AspectRatioEditLite? aspectRatio = default,
            global::Ideogram.TransparencyOption? transparency = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an image with a prompt at lower cost and latency<br/>
        /// Edit an image using a text prompt, optimized for lower cost and<br/>
        /// latency. Upload the image being edited via the `image` field. Up to 9<br/>
        /// additional `reference_images` may be supplied to guide the edit.<br/>
        /// Output is always generated at 1K resolution. Input images larger than<br/>
        /// 1024px on their long edge are downscaled before processing. The<br/>
        /// `aspect_ratio` field controls the output aspect ratio only; when<br/>
        /// omitted, the output follows the aspect ratio of the image being<br/>
        /// edited.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="prompt">
        /// The prompt describing the desired edit.<br/>
        /// Example: Remove the person from the photo.
        /// </param>
        /// <param name="image">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="imagename">
        /// The image being edited (max size 25MB); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="referenceImages">
        /// Optional additional reference images to guide the edit (max 9, max size 25MB each); JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="referenceImagesFileNames">
        /// Optional file names to use for the multipart 'reference_images' file parts.
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
        /// <param name="magicPromptSystemPromptConfigId">
        /// A base64url-encoded magic prompt system prompt config ID to use for this request.
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the edited output. When omitted, the output<br/>
        /// follows the aspect ratio of the image being edited.<br/>
        /// Example: 16x9
        /// </param>
        /// <param name="transparency">
        /// Controls whether the edited output has a transparent background.<br/>
        /// - `TRANSPARENT`: the output is produced with a transparent background.<br/>
        /// - `OPAQUE`: the output is produced with an opaque background.<br/>
        /// - `AUTO`: the server decides based on the prompt and the image being<br/>
        /// edited (e.g. whether it already has a transparent background). This is<br/>
        /// the default. When the prompt asks only for background removal, the<br/>
        /// output may be the edited image with its background removed.<br/>
        /// Default Value: AUTO
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.V1EditImagesResponse>> PostV1EditLiteImageAsResponseAsync(
            string prompt,
            global::System.IO.Stream image,
            string imagename,
            global::System.Collections.Generic.IReadOnlyList<global::System.IO.Stream>? referenceImages = default,
            global::System.Collections.Generic.IReadOnlyList<string>? referenceImagesFileNames = default,
            int? numImages = default,
            int? seed = default,
            global::Ideogram.MagicPromptOption? magicPrompt = default,
            string? magicPromptSystemPromptConfigId = default,
            global::Ideogram.AspectRatioEditLite? aspectRatio = default,
            global::Ideogram.TransparencyOption? transparency = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}