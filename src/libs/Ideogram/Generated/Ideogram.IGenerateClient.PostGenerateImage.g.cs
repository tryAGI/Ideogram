#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Generates images synchronously based on a given prompt and optional parameters.<br/>
        /// A request to generate an image with Ideogram.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostGenerateImageAsync(
            global::Ideogram.GenerateImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates images synchronously based on a given prompt and optional parameters.<br/>
        /// A request to generate an image with Ideogram.
        /// </summary>
        /// <param name="imageRequest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GenerateImageResponse> PostGenerateImageAsync(
            global::Ideogram.ImageRequest imageRequest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}