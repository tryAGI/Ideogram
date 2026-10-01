#nullable enable

namespace Ideogram
{
    public partial interface IImageDescribeClient
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeImageIdeogramV3Response> PostDescribeImageIdeogramV3Async(

            global::Ideogram.DescribeImageIdeogramV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
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
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.DescribeImageIdeogramV3Response>> PostDescribeImageIdeogramV3AsResponseAsync(

            global::Ideogram.DescribeImageIdeogramV3Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image with Ideogram's 3.0<br/>
        /// image captioner (a fine-tune of the Qwen2-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the description<br/>
        /// is returned directly.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max 10MB). JPEG, PNG, and WebP are supported. Multipart requests only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeImageIdeogramV3Response> PostDescribeImageIdeogramV3Async(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}