#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Upscale provided images synchronously with an optional prompt.<br/>
        /// A request to upscale a provided image with Ideogram.<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostUpscaleImageAsync(
            global::Ideogram.UpscaleImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upscale provided images synchronously with an optional prompt.<br/>
        /// A request to upscale a provided image with Ideogram.<br/>
        /// Supported image formats include JPEG, PNG, and WEBP
        /// </summary>
        /// <param name="imageRequest">
        /// A request to upscale a provided image with the help of an optional prompt.
        /// </param>
        /// <param name="imageFile">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
        /// </param>
        /// <param name="imageFilename">
        /// An image binary; only JPEG, WEBPs and PNGs are supported at this time
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