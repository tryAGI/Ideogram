#nullable enable

namespace Ideogram
{
    public partial interface IVisionClient
    {
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image with Ideogram 4.0 and return a structured<br/>
        /// `V4JsonPrompt`. The returned `json_prompt` is a working JSON prompt<br/>
        /// that can be passed directly as `json_prompt` to the<br/>
        /// `/v1/ideogram-v4/generate` family of endpoints.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponseV4> PostDescribeV4Async(

            global::Ideogram.DescribeRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image with Ideogram 4.0 and return a structured<br/>
        /// `V4JsonPrompt`. The returned `json_prompt` is a working JSON prompt<br/>
        /// that can be passed directly as `json_prompt` to the<br/>
        /// `/v1/ideogram-v4/generate` family of endpoints.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.DescribeResponseV4>> PostDescribeV4AsResponseAsync(

            global::Ideogram.DescribeRequestV4 request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image with Ideogram 4.0 and return a structured<br/>
        /// `V4JsonPrompt`. The returned `json_prompt` is a working JSON prompt<br/>
        /// that can be passed directly as `json_prompt` to the<br/>
        /// `/v1/ideogram-v4/generate` family of endpoints.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="includeBbox">
        /// When true (default), the response preserves bounding boxes on each<br/>
        /// element so the prompt can be pasted into `/v1/ideogram-v4/generate`<br/>
        /// as `json_prompt` and reproduce the source layout. Set to false to<br/>
        /// drop bounding boxes and let the sampler place elements freely.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// When false (default), the response omits `json_prompt.style_description`<br/>
        /// to match the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's source-image style<br/>
        /// description in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// When false (default), the response omits `json_prompt.tags` to match<br/>
        /// the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's free-form tags on the<br/>
        /// response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponseV4> PostDescribeV4Async(
            byte[] imageFile,
            string imageFilename,
            bool? includeBbox = default,
            bool? includeStyleDescriptions = default,
            bool? includeTags = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image with Ideogram 4.0 and return a structured<br/>
        /// `V4JsonPrompt`. The returned `json_prompt` is a working JSON prompt<br/>
        /// that can be passed directly as `json_prompt` to the<br/>
        /// `/v1/ideogram-v4/generate` family of endpoints.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="includeBbox">
        /// When true (default), the response preserves bounding boxes on each<br/>
        /// element so the prompt can be pasted into `/v1/ideogram-v4/generate`<br/>
        /// as `json_prompt` and reproduce the source layout. Set to false to<br/>
        /// drop bounding boxes and let the sampler place elements freely.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// When false (default), the response omits `json_prompt.style_description`<br/>
        /// to match the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's source-image style<br/>
        /// description in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// When false (default), the response omits `json_prompt.tags` to match<br/>
        /// the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's free-form tags on the<br/>
        /// response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.DescribeResponseV4> PostDescribeV4Async(
            global::System.IO.Stream imageFile,
            string imageFilename,
            bool? includeBbox = default,
            bool? includeStyleDescriptions = default,
            bool? includeTags = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Describe with Ideogram 4.0<br/>
        /// Describe an image with Ideogram 4.0 and return a structured<br/>
        /// `V4JsonPrompt`. The returned `json_prompt` is a working JSON prompt<br/>
        /// that can be passed directly as `json_prompt` to the<br/>
        /// `/v1/ideogram-v4/generate` family of endpoints.<br/>
        /// Supported image formats include JPEG, PNG, and WebP.
        /// </summary>
        /// <param name="imageFile">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imageFilename">
        /// An image binary (max size 10MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="includeBbox">
        /// When true (default), the response preserves bounding boxes on each<br/>
        /// element so the prompt can be pasted into `/v1/ideogram-v4/generate`<br/>
        /// as `json_prompt` and reproduce the source layout. Set to false to<br/>
        /// drop bounding boxes and let the sampler place elements freely.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeStyleDescriptions">
        /// When false (default), the response omits `json_prompt.style_description`<br/>
        /// to match the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's source-image style<br/>
        /// description in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTags">
        /// When false (default), the response omits `json_prompt.tags` to match<br/>
        /// the contract used by `/v1/ideogram-v4/generate`'s `json_prompt`<br/>
        /// input. Set to true to surface the captioner's free-form tags on the<br/>
        /// response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.DescribeResponseV4>> PostDescribeV4AsResponseAsync(
            global::System.IO.Stream imageFile,
            string imageFilename,
            bool? includeBbox = default,
            bool? includeStyleDescriptions = default,
            bool? includeTags = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}