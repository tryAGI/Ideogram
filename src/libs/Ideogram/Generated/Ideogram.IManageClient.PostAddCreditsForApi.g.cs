#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Add credits to an API user's account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostAddCreditsResponse> PostAddCreditsForApiAsync(
            global::Ideogram.PostAddCreditsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add credits to an API user's account.
        /// </summary>
        /// <param name="amount">
        /// Represents a price.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.PostAddCreditsResponse> PostAddCreditsForApiAsync(
            global::Ideogram.Price amount,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}