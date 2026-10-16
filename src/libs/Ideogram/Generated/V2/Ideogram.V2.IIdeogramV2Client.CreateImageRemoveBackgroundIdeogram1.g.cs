#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Remove background<br/>
        /// Remove the background from an image and return the foreground as a<br/>
        /// transparent PNG. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns the result directly by default; set `async` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemoveBackgroundV2Response> CreateImageRemoveBackgroundIdeogram1Async(

            global::Ideogram.V2.ToolRemoveBackgroundRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove background<br/>
        /// Remove the background from an image and return the foreground as a<br/>
        /// transparent PNG. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns the result directly by default; set `async` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.RemoveBackgroundV2Response>> CreateImageRemoveBackgroundIdeogram1AsResponseAsync(

            global::Ideogram.V2.ToolRemoveBackgroundRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove background<br/>
        /// Remove the background from an image and return the foreground as a<br/>
        /// transparent PNG. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns the result directly by default; set `async` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemoveBackgroundV2Response> CreateImageRemoveBackgroundIdeogram1Async(
            byte[] image,
            string imagename,
            bool? dryRun = default,
            bool? @private = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove background<br/>
        /// Remove the background from an image and return the foreground as a<br/>
        /// transparent PNG. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns the result directly by default; set `async` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemoveBackgroundV2Response> CreateImageRemoveBackgroundIdeogram1Async(
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            bool? @private = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove background<br/>
        /// Remove the background from an image and return the foreground as a<br/>
        /// transparent PNG. Upload the source `image` using `multipart/form-data`.<br/>
        /// Returns the result directly by default; set `async` to get a<br/>
        /// `generation_id` and poll `GET /v2/generations/{generation_id}`.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image. JPEG, PNG, or WebP, up to 25MB. Multipart requests only.
        /// </param>
        /// <param name="private">
        /// Whether to keep the result out of the public gallery. When omitted,<br/>
        /// defaults to your plan's setting, or public if your plan has none.<br/>
        /// Enterprise generations are always private.
        /// </param>
        /// <param name="async">
        /// When false (the default), wait for and return the foreground image. When true, return as soon as the request is accepted; poll `GET /v2/generations/{generation_id}` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.RemoveBackgroundV2Response>> CreateImageRemoveBackgroundIdeogram1AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            bool? dryRun = default,
            bool? @private = default,
            bool? async = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}