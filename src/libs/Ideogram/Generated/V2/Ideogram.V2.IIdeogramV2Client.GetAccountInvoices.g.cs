#nullable enable

namespace Ideogram.V2
{
    public partial interface IIdeogramV2Client
    {
        /// <summary>
        /// List invoices<br/>
        /// Returns your organization's invoices with their line items — the<br/>
        /// billing record your usage reports reconcile against. Amounts are<br/>
        /// decimal strings in the invoice's currency.<br/>
        /// Requires an API key whose owner is an organization admin. Keys owned<br/>
        /// by other members receive a 404.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.ListAccountInvoicesResponse> GetAccountInvoicesAsync(
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List invoices<br/>
        /// Returns your organization's invoices with their line items — the<br/>
        /// billing record your usage reports reconcile against. Amounts are<br/>
        /// decimal strings in the invoice's currency.<br/>
        /// Requires an API key whose owner is an organization admin. Keys owned<br/>
        /// by other members receive a 404.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.V2.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.V2.AutoSDKHttpResponse<global::Ideogram.V2.ListAccountInvoicesResponse>> GetAccountInvoicesAsResponseAsync(
            global::Ideogram.V2.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}