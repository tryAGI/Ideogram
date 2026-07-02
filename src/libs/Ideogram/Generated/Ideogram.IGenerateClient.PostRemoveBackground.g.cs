#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Remove Background<br/>
        /// Remove the background of a given image synchronously. The foreground subject<br/>
        /// is identified and returned on a transparent background. Supported image formats include JPEG,<br/>
        /// PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image,<br/>
        /// you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveBackgroundResponse> PostRemoveBackgroundAsync(

            global::Ideogram.RemoveBackgroundRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background<br/>
        /// Remove the background of a given image synchronously. The foreground subject<br/>
        /// is identified and returned on a transparent background. Supported image formats include JPEG,<br/>
        /// PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image,<br/>
        /// you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveBackgroundResponse>> PostRemoveBackgroundAsResponseAsync(

            global::Ideogram.RemoveBackgroundRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background<br/>
        /// Remove the background of a given image synchronously. The foreground subject<br/>
        /// is identified and returned on a transparent background. Supported image formats include JPEG,<br/>
        /// PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image,<br/>
        /// you must download it.
        /// </summary>
        /// <param name="image">
        /// The image whose background is being removed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image whose background is being removed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveBackgroundResponse> PostRemoveBackgroundAsync(
            byte[] image,
            string imagename,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove Background<br/>
        /// Remove the background of a given image synchronously. The foreground subject<br/>
        /// is identified and returned on a transparent background. Supported image formats include JPEG,<br/>
        /// PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image,<br/>
        /// you must download it.
        /// </summary>
        /// <param name="image">
        /// The image whose background is being removed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image whose background is being removed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.RemoveBackgroundResponse> PostRemoveBackgroundAsync(
            global::System.IO.Stream image,
            string imagename,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Background<br/>
        /// Remove the background of a given image synchronously. The foreground subject<br/>
        /// is identified and returned on a transparent background. Supported image formats include JPEG,<br/>
        /// PNG, and WebP.<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image,<br/>
        /// you must download it.
        /// </summary>
        /// <param name="image">
        /// The image whose background is being removed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The image whose background is being removed (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.RemoveBackgroundResponse>> PostRemoveBackgroundAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}