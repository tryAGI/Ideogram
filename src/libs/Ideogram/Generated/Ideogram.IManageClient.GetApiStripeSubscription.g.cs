#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve data relevant to connecting to Stripe.
        /// </summary>
        /// <param name="isBusiness"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ManageApiStripeSubscriptionResponse> GetApiStripeSubscriptionAsync(
            bool? isBusiness = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}