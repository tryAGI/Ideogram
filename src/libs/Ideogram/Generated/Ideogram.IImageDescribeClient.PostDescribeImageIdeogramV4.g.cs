#nullable enable

namespace Ideogram
{
    public partial interface IImageDescribeClient
    {
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image using Ideogram's 4.0-generation image captioner (a<br/>
        /// fine-tune of the Qwen3-VL vision-language model) and return a<br/>
        /// structured `V4JsonPrompt`. The<br/>
        /// returned `json_prompt` is a working JSON prompt that can be passed<br/>
        /// directly as `json_prompt` to the `/v1/ideogram-v4/generate` family of<br/>
        /// endpoints.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeImageIdeogramV4Response> PostDescribeImageIdeogramV4Async(

            global::Ideogram.DescribeImageIdeogramV4Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image using Ideogram's 4.0-generation image captioner (a<br/>
        /// fine-tune of the Qwen3-VL vision-language model) and return a<br/>
        /// structured `V4JsonPrompt`. The<br/>
        /// returned `json_prompt` is a working JSON prompt that can be passed<br/>
        /// directly as `json_prompt` to the `/v1/ideogram-v4/generate` family of<br/>
        /// endpoints.<br/>
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
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.DescribeImageIdeogramV4Response>> PostDescribeImageIdeogramV4AsResponseAsync(

            global::Ideogram.DescribeImageIdeogramV4Request request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image using Ideogram's 4.0-generation image captioner (a<br/>
        /// fine-tune of the Qwen3-VL vision-language model) and return a<br/>
        /// structured `V4JsonPrompt`. The<br/>
        /// returned `json_prompt` is a working JSON prompt that can be passed<br/>
        /// directly as `json_prompt` to the `/v1/ideogram-v4/generate` family of<br/>
        /// endpoints.<br/>
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
        /// <param name="includeBbox">
        /// Whether to include bounding boxes on the subjects and texts of the returned `json_prompt`. Defaults to true so the prompt preserves the spatial layout of the described image.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// Whether to include a free-form style description on the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// Whether to include the captioner's free-form tags on the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeImageIdeogramV4Response> PostDescribeImageIdeogramV4Async(
            global::Ideogram.AssetIdentifier? imageAssetIdentifier = default,
            byte[]? image = default,
            string? imagename = default,
            bool? includeBbox = default,
            bool? includeStyleDescriptions = default,
            bool? includeTags = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}