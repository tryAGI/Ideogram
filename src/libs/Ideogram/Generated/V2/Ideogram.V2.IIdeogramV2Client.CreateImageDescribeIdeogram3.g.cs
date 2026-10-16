#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image with Ideogram's 3.0<br/>
        /// image captioner (a fine-tune of the Qwen2-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the description<br/>
        /// is returned directly.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.DescribeImageIdeogramV3Response> CreateImageDescribeIdeogram3Async(

            global::Ideogram.V2.ImageDescribePostDescribeImageIdeogramV3Request request,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image with Ideogram's 3.0<br/>
        /// image captioner (a fine-tune of the Qwen2-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the description<br/>
        /// is returned directly.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.DescribeImageIdeogramV3Response>> CreateImageDescribeIdeogram3AsResponseAsync(

            global::Ideogram.V2.ImageDescribePostDescribeImageIdeogramV3Request request,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image with Ideogram's 3.0<br/>
        /// image captioner (a fine-tune of the Qwen2-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the description<br/>
        /// is returned directly.
        /// </summary>
        /// <param name="image">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.DescribeImageIdeogramV3Response> CreateImageDescribeIdeogram3Async(
            byte[] image,
            string imagename,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image with Ideogram's 3.0<br/>
        /// image captioner (a fine-tune of the Qwen2-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the description<br/>
        /// is returned directly.
        /// </summary>
        /// <param name="image">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.DescribeImageIdeogramV3Response> CreateImageDescribeIdeogram3Async(
            global::System.IO.Stream image,
            string imagename,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image with Ideogram's 3.0<br/>
        /// image captioner (a fine-tune of the Qwen2-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the description<br/>
        /// is returned directly.
        /// </summary>
        /// <param name="image">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.DescribeImageIdeogramV3Response>> CreateImageDescribeIdeogram3AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}