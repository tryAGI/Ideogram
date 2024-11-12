#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Update API subscription settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostApiSubscriptionResponse> PostApiSubscriptionAsync(
            global::Ideogram.PostApiSubscriptionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update API subscription settings
        /// </summary>
        /// <param name="rechargeSettings">
        /// The current recharge settings for the API subscription.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostApiSubscriptionResponse> PostApiSubscriptionAsync(
            global::Ideogram.RechargeSettings? rechargeSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}