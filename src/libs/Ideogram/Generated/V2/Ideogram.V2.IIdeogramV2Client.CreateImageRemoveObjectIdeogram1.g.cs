#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemoveObjectFromV2AssetsResponse> CreateImageRemoveObjectIdeogram1Async(

            global::Ideogram.V2.ObjectRemovalPostRemoveObjectFromV2AssetsRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.RemoveObjectFromV2AssetsResponse>> CreateImageRemoveObjectIdeogram1AsResponseAsync(

            global::Ideogram.V2.ObjectRemovalPostRemoveObjectFromV2AssetsRequest request,
            bool? dryRun = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemoveObjectFromV2AssetsResponse> CreateImageRemoveObjectIdeogram1Async(
            byte[] image,
            string imagename,
            byte[] mask,
            string maskname,
            bool? dryRun = default,
            int? seed = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.RemoveObjectFromV2AssetsResponse> CreateImageRemoveObjectIdeogram1Async(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            bool? dryRun = default,
            int? seed = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove an object<br/>
        /// Remove a masked object from an image. Upload the source `image` and a<br/>
        /// `mask` of the same size using `multipart/form-data`. Returns a<br/>
        /// `generation_id`; poll `GET /v2/generations/{generation_id}` for the<br/>
        /// result.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: false
        /// </param>
        /// <param name="image">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to remove an object from. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="mask">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="maskname">
        /// A black-and-white mask the same size as the image; white (&gt;= 128) marks the region to remove. JPEG, PNG, or WEBP, up to 50MB. Multipart requests only.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.RemoveObjectFromV2AssetsResponse>> CreateImageRemoveObjectIdeogram1AsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::System.IO.Stream mask,
            string maskname,
            bool? dryRun = default,
            int? seed = default,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}