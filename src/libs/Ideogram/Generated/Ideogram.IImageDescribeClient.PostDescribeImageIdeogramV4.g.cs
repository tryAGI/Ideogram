#nullable enable

namespace Ideogram
{
    public partial interface IImageDescribeClient
    {
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image as a structured `V4JsonPrompt` with Ideogram's 4.0<br/>
        /// image captioner (a fine-tune of the Qwen3-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the<br/>
        /// `json_prompt` is returned directly and can be passed to the<br/>
        /// `/v1/ideogram-v4/generate` endpoints.
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
        /// Describe an image as a structured `V4JsonPrompt` with Ideogram's 4.0<br/>
        /// image captioner (a fine-tune of the Qwen3-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the<br/>
        /// `json_prompt` is returned directly and can be passed to the<br/>
        /// `/v1/ideogram-v4/generate` endpoints.
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
        /// Describe an image as a structured `V4JsonPrompt` with Ideogram's 4.0<br/>
        /// image captioner (a fine-tune of the Qwen3-VL vision-language model).<br/>
        /// Upload the image as `image` using `multipart/form-data`; the<br/>
        /// `json_prompt` is returned directly and can be passed to the<br/>
        /// `/v1/ideogram-v4/generate` endpoints.
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
        /// <param name="includeBbox">
        /// Whether to include bounding boxes for the subjects and text in the returned `json_prompt`. Defaults to true, so the prompt preserves the layout of the described image.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// Whether to include a free-form style description in the returned `json_prompt`. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// Whether to include free-form tags in the returned `json_prompt`. Defaults to false.<br/>
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