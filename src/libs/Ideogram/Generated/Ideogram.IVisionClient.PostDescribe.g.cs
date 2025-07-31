#nullable enable

namespace Ideogram
{
    public partial interface IVisionClient
    {
        /// <summary>
        /// Describe<br/>
        /// Describe an image.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponse> PostDescribeAsync(
            global::Ideogram.DescribeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Describe<br/>
        /// Describe an image.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="describeModelVersion">
        /// The model version to use for describing images. Defaults to V_3.<br/>
        /// Default Value: V_3
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponse> PostDescribeAsync(
            byte[] imageFile,
            string imageFilename,
            global::Ideogram.DescribeModelVersion? describeModelVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}