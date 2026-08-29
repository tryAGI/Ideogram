#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Lifetime credit totals for the API user's account.<br/>
        /// Returns the lifetime credit KPIs (consumed, expired, issued) used to<br/>
        /// render the API credit dashboard strip. All values default to $0 when<br/>
        /// Metronome is unavailable so the FE can always render.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ManageApiCreditSummaryResponse> GetApiCreditSummaryAsync(
            string organizationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lifetime credit totals for the API user's account.<br/>
        /// Returns the lifetime credit KPIs (consumed, expired, issued) used to<br/>
        /// render the API credit dashboard strip. All values default to $0 when<br/>
        /// Metronome is unavailable so the FE can always render.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.ManageApiCreditSummaryResponse>> GetApiCreditSummaryAsResponseAsync(
            string organizationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}