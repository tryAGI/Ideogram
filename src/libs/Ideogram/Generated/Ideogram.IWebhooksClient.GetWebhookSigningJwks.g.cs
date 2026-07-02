#nullable enable

namespace Ideogram
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get the public keys used to verify webhook signatures<br/>
        /// Returns the set of Ed25519 public keys Ideogram uses to sign outbound<br/>
        /// webhook payloads. Customers verify incoming webhooks by recomputing the<br/>
        /// canonical signed message (`request_id\nuser_id\ntimestamp\nsha256_hex(body)`)<br/>
        /// and checking the `X-Ideogram-Webhook-Signature` header against any key<br/>
        /// in this document.<br/>
        /// The document includes the current signing key plus any keys recently<br/>
        /// rotated out, so signatures already in flight remain verifiable across<br/>
        /// rotations. Cache for up to 24 hours; refresh sooner if a signature<br/>
        /// fails to verify against the cached set.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.WebhookSigningJwks> GetWebhookSigningJwksAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the public keys used to verify webhook signatures<br/>
        /// Returns the set of Ed25519 public keys Ideogram uses to sign outbound<br/>
        /// webhook payloads. Customers verify incoming webhooks by recomputing the<br/>
        /// canonical signed message (`request_id\nuser_id\ntimestamp\nsha256_hex(body)`)<br/>
        /// and checking the `X-Ideogram-Webhook-Signature` header against any key<br/>
        /// in this document.<br/>
        /// The document includes the current signing key plus any keys recently<br/>
        /// rotated out, so signatures already in flight remain verifiable across<br/>
        /// rotations. Cache for up to 24 hours; refresh sooner if a signature<br/>
        /// fails to verify against the cached set.<br/>
        /// This endpoint is public and unauthenticated — no API key is required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.WebhookSigningJwks>> GetWebhookSigningJwksAsResponseAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}