#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// Download Layerize HTML<br/>
        /// Return a standalone HTML document built from the current editable layers.<br/>
        /// Images and fonts are embedded in the response. Use `layerize_id` from a<br/>
        /// completed Layerize result. Uploaded fonts supplied through the API may<br/>
        /// expire, so this request can stop succeeding after their cache lifetime.
        /// </summary>
        /// <param name="layerizeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetDesignHtmlByLayerizeIdAsync(
            string layerizeId,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Layerize HTML<br/>
        /// Return a standalone HTML document built from the current editable layers.<br/>
        /// Images and fonts are embedded in the response. Use `layerize_id` from a<br/>
        /// completed Layerize result. Uploaded fonts supplied through the API may<br/>
        /// expire, so this request can stop succeeding after their cache lifetime.
        /// </summary>
        /// <param name="layerizeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetDesignHtmlByLayerizeIdAsStreamAsync(
            string layerizeId,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Layerize HTML<br/>
        /// Return a standalone HTML document built from the current editable layers.<br/>
        /// Images and fonts are embedded in the response. Use `layerize_id` from a<br/>
        /// completed Layerize result. Uploaded fonts supplied through the API may<br/>
        /// expire, so this request can stop succeeding after their cache lifetime.
        /// </summary>
        /// <param name="layerizeId"></param>
        /// <returns>The response metadata and an unbuffered body stream. The caller must dispose Body to release the HTTP response.</returns>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::System.IO.Stream>> GetDesignHtmlByLayerizeIdAsStreamAsResponseAsync(
            string layerizeId,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download Layerize HTML<br/>
        /// Return a standalone HTML document built from the current editable layers.<br/>
        /// Images and fonts are embedded in the response. Use `layerize_id` from a<br/>
        /// completed Layerize result. Uploaded fonts supplied through the API may<br/>
        /// expire, so this request can stop succeeding after their cache lifetime.
        /// </summary>
        /// <param name="layerizeId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<byte[]>> GetDesignHtmlByLayerizeIdAsResponseAsync(
            string layerizeId,
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}