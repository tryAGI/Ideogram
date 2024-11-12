#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve the latest terms of service for API usage.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetApiTermsResponse> GetApiTermsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}