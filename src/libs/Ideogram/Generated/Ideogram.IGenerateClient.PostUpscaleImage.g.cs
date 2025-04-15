#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Upscale<br/>
        /// Upscale provided images synchronously with an optional prompt.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostUpscaleImageAsync(
            global::Ideogram.UpscaleImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upscale<br/>
        /// Upscale provided images synchronously with an optional prompt.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.<br/>
        /// Images links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="imageRequest">
        /// A request to upscale a provided image with the help of an optional prompt.
        /// </param>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostUpscaleImageAsync(
            global::Ideogram.UpscaleInitialImageRequest imageRequest,
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}