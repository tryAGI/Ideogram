#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Reactivates a subscription by attempting to re-enable Metronome billing.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostApiReactivateResponse> ReactivateSubscriptionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}