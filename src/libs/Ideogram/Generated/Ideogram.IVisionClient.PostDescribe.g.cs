#nullable enable

namespace Ideogram
{
    public partial interface IVisionClient
    {
        /// <summary>
        /// Describe an image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponse> PostDescribeAsync(
            global::Ideogram.DescribeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Describe an image
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="imageFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponse> PostDescribeAsync(
            byte[] imageFile,
            string imageFilename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}