#nullable enable

namespace Ideogram
{
    public partial interface IImageDescribeClient
    {
        /// <summary>
        /// Describe with Ideogram 3.0<br/>
        /// Generate a natural-language description of an image using Ideogram's<br/>
        /// 3.0-generation image captioner (a fine-tune of the Qwen2-VL<br/>
        /// vision-language model).<br/>
        /// Supply the source either as an `image_asset_identifier` reference (an<br/>
        /// image already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only). Provide exactly one of the two forms; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
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
        /// Generate a natural-language description of an image using Ideogram's<br/>
        /// 3.0-generation image captioner (a fine-tune of the Qwen2-VL<br/>
        /// vision-language model).<br/>
        /// Supply the source either as an `image_asset_identifier` reference (an<br/>
        /// image already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only). Provide exactly one of the two forms; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
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
        /// Generate a natural-language description of an image using Ideogram's<br/>
        /// 3.0-generation image captioner (a fine-tune of the Qwen2-VL<br/>
        /// vision-language model).<br/>
        /// Supply the source either as an `image_asset_identifier` reference (an<br/>
        /// image already stored with Ideogram) or as raw `image` bytes (multipart<br/>
        /// requests only). Provide exactly one of the two forms; supplying both,<br/>
        /// or neither, is rejected with a 400.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="image">
        /// The image to describe (max size 10MB), as raw bytes; only JPEG, PNG, and WebP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
        /// </param>
        /// <param name="imagename">
        /// The image to describe (max size 10MB), as raw bytes; only JPEG, PNG, and WebP formats are supported. Multipart requests only. Provide exactly one of `image_asset_identifier` or `image`.
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