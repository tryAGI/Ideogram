#nullable enable

namespace Ideogram
{
    public partial interface IProvenanceClient
    {
        /// <summary>
        /// Check whether content was created by Ideogram<br/>
        /// Checks image content for an Ideogram provenance manifest (C2PA Content<br/>
        /// Credentials) and returns the disclosure it carries: the provider name,<br/>
        /// the generating system and its version, the creation time, and the<br/>
        /// content's unique identifier.<br/>
        /// Upload the image to verify as the `content` part.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.<br/>
        /// Submitted content is analyzed in memory and never stored.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ProvenanceVerifyResponse> PostProvenanceVerifyAsync(

            global::Ideogram.ProvenanceVerifyRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether content was created by Ideogram<br/>
        /// Checks image content for an Ideogram provenance manifest (C2PA Content<br/>
        /// Credentials) and returns the disclosure it carries: the provider name,<br/>
        /// the generating system and its version, the creation time, and the<br/>
        /// content's unique identifier.<br/>
        /// Upload the image to verify as the `content` part.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.<br/>
        /// Submitted content is analyzed in memory and never stored.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ProvenanceVerifyResponse>> PostProvenanceVerifyAsResponseAsync(

            global::Ideogram.ProvenanceVerifyRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether content was created by Ideogram<br/>
        /// Checks image content for an Ideogram provenance manifest (C2PA Content<br/>
        /// Credentials) and returns the disclosure it carries: the provider name,<br/>
        /// the generating system and its version, the creation time, and the<br/>
        /// content's unique identifier.<br/>
        /// Upload the image to verify as the `content` part.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.<br/>
        /// Submitted content is analyzed in memory and never stored.
        /// </summary>
        /// <param name="content">
        /// The image file to verify.
        /// </param>
        /// <param name="contentname">
        /// The image file to verify.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ProvenanceVerifyResponse> PostProvenanceVerifyAsync(
            byte[] content,
            string contentname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check whether content was created by Ideogram<br/>
        /// Checks image content for an Ideogram provenance manifest (C2PA Content<br/>
        /// Credentials) and returns the disclosure it carries: the provider name,<br/>
        /// the generating system and its version, the creation time, and the<br/>
        /// content's unique identifier.<br/>
        /// Upload the image to verify as the `content` part.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.<br/>
        /// Submitted content is analyzed in memory and never stored.
        /// </summary>
        /// <param name="content">
        /// The image file to verify.
        /// </param>
        /// <param name="contentname">
        /// The image file to verify.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ProvenanceVerifyResponse> PostProvenanceVerifyAsync(
            global::System.IO.Stream content,
            string contentname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check whether content was created by Ideogram<br/>
        /// Checks image content for an Ideogram provenance manifest (C2PA Content<br/>
        /// Credentials) and returns the disclosure it carries: the provider name,<br/>
        /// the generating system and its version, the creation time, and the<br/>
        /// content's unique identifier.<br/>
        /// Upload the image to verify as the `content` part.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.<br/>
        /// Submitted content is analyzed in memory and never stored.
        /// </summary>
        /// <param name="content">
        /// The image file to verify.
        /// </param>
        /// <param name="contentname">
        /// The image file to verify.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ProvenanceVerifyResponse>> PostProvenanceVerifyAsResponseAsync(
            global::System.IO.Stream content,
            string contentname,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}