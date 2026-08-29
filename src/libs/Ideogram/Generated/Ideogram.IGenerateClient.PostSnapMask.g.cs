#nullable enable

namespace Ideogram
{
    public partial interface IGenerateClient
    {
        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> PostSnapMaskAsync(

            global::Ideogram.SnapMaskRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> PostSnapMaskAsStreamAsync(

            global::Ideogram.SnapMaskRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<byte[]>> PostSnapMaskAsResponseAsync(

            global::Ideogram.SnapMaskRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="image">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> PostSnapMaskAsync(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="image">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> PostSnapMaskAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="image">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> PostSnapMaskAsStreamAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Snap a hand-drawn mask to the selected object<br/>
        /// Refine a hand-drawn binary mask to the object it marks. Supply the source image and a mask with the same dimensions; white (&gt;= 128) marks the object. The response is a binary PNG mask with white pixels marking the snapped object.
        /// </summary>
        /// <param name="image">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="imagename">
        /// The source image containing the object (max size 25MB); only JPEG, WebP and PNG formats are supported at this time.
        /// </param>
        /// <param name="mask">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="maskname">
        /// A hand-drawn binary mask the same size as the image; white (&gt;= 128) marks the object to snap. Only JPEG, WebP and PNG formats are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<byte[]>> PostSnapMaskAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}