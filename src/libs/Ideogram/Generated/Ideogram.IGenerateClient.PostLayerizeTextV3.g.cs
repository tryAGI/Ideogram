#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Layerize Text<br/>
        /// Analyzes an image to detect text regions, then returns each detected text block with its position, content, font information, and styling.<br/>
        /// The response includes a text-erased base image (background with all text removed) and a flat list of detected text blocks.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeTextResponse> PostLayerizeTextV3Async(

            global::Ideogram.LayerizeTextRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Layerize Text<br/>
        /// Analyzes an image to detect text regions, then returns each detected text block with its position, content, font information, and styling.<br/>
        /// The response includes a text-erased base image (background with all text removed) and a flat list of detected text blocks.<br/>
        /// Supported image formats include JPEG, PNG, and WebP (max size 10MB).<br/>
        /// Image links are available for a limited period of time; if you would like to keep the image, you must download it.
        /// </summary>
        /// <param name="image">
        /// The image to analyze for text detection. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </param>
        /// <param name="imagename">
        /// The image to analyze for text detection. The image should be in JPEG, PNG, or WebP format (max size 10MB).
        /// </param>
        /// <param name="prompt">
        /// An optional text description of the image. If not provided, a description will be auto-generated from the image.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.LayerizeTextResponse> PostLayerizeTextV3Async(
            byte[] image,
            string imagename,
            string? prompt = default,
            int? seed = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}