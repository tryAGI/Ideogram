#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Update API subscription settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostApiSubscriptionResponse> PostApiSubscriptionAsync(

            global::Ideogram.PostApiSubscriptionRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update API subscription settings
        /// </summary>
        /// <param name="rechargeSettings">
        /// The current recharge settings for the API subscription.<br/>
        /// Example: {"minimum_balance_threshold":{"amount":1050,"currency_code":"USD"},"top_up_balance":{"amount":1050,"currency_code":"USD"}}
        /// </param>
        /// <param name="isActive">
        /// Whether to enable or disable auto recharge.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostApiSubscriptionResponse> PostApiSubscriptionAsync(
            global::Ideogram.RechargeSettings? rechargeSettings = default,
            bool? isActive = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}