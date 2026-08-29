#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Remove Object<br/>
        /// Remove a masked object from a given image synchronously. Supply the image and a binary mask marking the region to remove (white = remove); the masked region is regenerated to blend with the surrounding scene. Supported image formats include JPEG, PNG, and WebP. Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectResponse> PostRemoveObjectAsync(

            global::Ideogram.RemoveObjectRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Object<br/>
        /// Remove a masked object from a given image synchronously. Supply the image and a binary mask marking the region to remove (white = remove); the masked region is regenerated to blend with the surrounding scene. Supported image formats include JPEG, PNG, and WebP. Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveObjectResponse>> PostRemoveObjectAsResponseAsync(

            global::Ideogram.RemoveObjectRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Object<br/>
        /// Remove a masked object from a given image synchronously. Supply the image and a binary mask marking the region to remove (white = remove); the masked region is regenerated to blend with the surrounding scene. Supported image formats include JPEG, PNG, and WebP. Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="seed">
        /// Optional random seed for reproducible output. When omitted, a random seed is chosen.
        /// </param>
        /// <param name="numInferenceSteps">
        /// Optional number of diffusion steps. Higher is slower but can improve quality; values are clamped to [1, 128]. When omitted, the model default is used.
        /// </param>
        /// <param name="guidanceScale">
        /// Optional classifier-free guidance (CFG) scale. Higher follows the removal instruction more strongly; values are clamped to [1, 10]. When omitted, the model default is used.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectResponse> PostRemoveObjectAsync(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            int? seed = default,
            int? numInferenceSteps = default,
            float? guidanceScale = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove Object<br/>
        /// Remove a masked object from a given image synchronously. Supply the image and a binary mask marking the region to remove (white = remove); the masked region is regenerated to blend with the surrounding scene. Supported image formats include JPEG, PNG, and WebP. Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="seed">
        /// Optional random seed for reproducible output. When omitted, a random seed is chosen.
        /// </param>
        /// <param name="numInferenceSteps">
        /// Optional number of diffusion steps. Higher is slower but can improve quality; values are clamped to [1, 128]. When omitted, the model default is used.
        /// </param>
        /// <param name="guidanceScale">
        /// Optional classifier-free guidance (CFG) scale. Higher follows the removal instruction more strongly; values are clamped to [1, 10]. When omitted, the model default is used.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveObjectResponse> PostRemoveObjectAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            int? seed = default,
            int? numInferenceSteps = default,
            float? guidanceScale = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Object<br/>
        /// Remove a masked object from a given image synchronously. Supply the image and a binary mask marking the region to remove (white = remove); the masked region is regenerated to blend with the surrounding scene. Supported image formats include JPEG, PNG, and WebP. Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image to remove an object from (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A binary mask the same size as the image; white (&gt;= 128) marks the region to remove. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="seed">
        /// Optional random seed for reproducible output. When omitted, a random seed is chosen.
        /// </param>
        /// <param name="numInferenceSteps">
        /// Optional number of diffusion steps. Higher is slower but can improve quality; values are clamped to [1, 128]. When omitted, the model default is used.
        /// </param>
        /// <param name="guidanceScale">
        /// Optional classifier-free guidance (CFG) scale. Higher follows the removal instruction more strongly; values are clamped to [1, 10]. When omitted, the model default is used.
        /// </param>
        /// <param name="renderingSpeed">
        /// The rendering speed to use.<br/>
        /// Default Value: DEFAULT
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveObjectResponse>> PostRemoveObjectAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            int? seed = default,
            int? numInferenceSteps = default,
            float? guidanceScale = default,
            global::Ideogram.RenderingSpeed? renderingSpeed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}