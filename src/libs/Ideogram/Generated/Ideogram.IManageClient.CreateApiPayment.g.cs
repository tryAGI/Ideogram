#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Create a payment setup session for inline card collection.<br/>
        /// Returns a client_secret for the org's payment customer so the inline payment<br/>
        /// modal can save a card without leaving the app.<br/>
        /// Soft-deprecated: the inline Elements flow was removed in the Stripe.js<br/>
        /// eager-bundle incident (2026-05-20). New clients should use the<br/>
        /// stripe_payment_setup_url field on ManageApiStripeSubscriptionResponse, which<br/>
        /// returns a hosted Stripe Checkout URL instead. This endpoint will be formally<br/>
        /// deprecated and then removed once no callers reference it.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ManageApiPaymentResponse> CreateApiPaymentAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a payment setup session for inline card collection.<br/>
        /// Returns a client_secret for the org's payment customer so the inline payment<br/>
        /// modal can save a card without leaving the app.<br/>
        /// Soft-deprecated: the inline Elements flow was removed in the Stripe.js<br/>
        /// eager-bundle incident (2026-05-20). New clients should use the<br/>
        /// stripe_payment_setup_url field on ManageApiStripeSubscriptionResponse, which<br/>
        /// returns a hosted Stripe Checkout URL instead. This endpoint will be formally<br/>
        /// deprecated and then removed once no callers reference it.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ManageApiPaymentResponse>> CreateApiPaymentAsResponseAsync(
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}