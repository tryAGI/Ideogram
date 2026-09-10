#nullable enable

namespace Ideogram
{
    public partial interface IAccountClient
    {
        /// <summary>
        /// Retrieve your organization's API usage and spend over time<br/>
        /// Returns your organization's billed API usage as dense time buckets of<br/>
        /// line items. Every line item carries the billed dollar amount; products<br/>
        /// billed per item also carry `billed_units` (unit, quantity, and unit<br/>
        /// price, where `quantity × unit_price = cost_total`). Usage-priced<br/>
        /// products (billed by metered provider usage) report `cost_total` only.<br/>
        /// Buckets cover the requested range completely — a bucket with no line<br/>
        /// items means no billed usage in that window. Line items are unique per<br/>
        /// bucket on (`product`, `dimensions`, `api_key.id`, unit price). Usage<br/>
        /// billed without an API key (requests authenticated as a user session)<br/>
        /// is included with `api_key` absent, so totals always reconcile with<br/>
        /// your invoices.<br/>
        /// `product` and `endpoint` are stable identifiers safe to aggregate on;<br/>
        /// `description` is display text and may be reworded at any time.<br/>
        /// Usage data may lag live traffic by a few minutes, and responses may be<br/>
        /// cached briefly, so this endpoint is for reporting rather than<br/>
        /// real-time monitoring.<br/>
        /// Requires an API key whose owner is an organization admin. Keys owned<br/>
        /// by other members receive a 404.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="sources">
        /// Default Value: [api, app]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetAccountUsageResponse> GetAccountUsageAsync(
            global::System.DateTime startTime,
            global::System.DateTime? endTime = default,
            global::Ideogram.GetAccountUsageBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::Ideogram.GetAccountUsageSource>? sources = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve your organization's API usage and spend over time<br/>
        /// Returns your organization's billed API usage as dense time buckets of<br/>
        /// line items. Every line item carries the billed dollar amount; products<br/>
        /// billed per item also carry `billed_units` (unit, quantity, and unit<br/>
        /// price, where `quantity × unit_price = cost_total`). Usage-priced<br/>
        /// products (billed by metered provider usage) report `cost_total` only.<br/>
        /// Buckets cover the requested range completely — a bucket with no line<br/>
        /// items means no billed usage in that window. Line items are unique per<br/>
        /// bucket on (`product`, `dimensions`, `api_key.id`, unit price). Usage<br/>
        /// billed without an API key (requests authenticated as a user session)<br/>
        /// is included with `api_key` absent, so totals always reconcile with<br/>
        /// your invoices.<br/>
        /// `product` and `endpoint` are stable identifiers safe to aggregate on;<br/>
        /// `description` is display text and may be reworded at any time.<br/>
        /// Usage data may lag live traffic by a few minutes, and responses may be<br/>
        /// cached briefly, so this endpoint is for reporting rather than<br/>
        /// real-time monitoring.<br/>
        /// Requires an API key whose owner is an organization admin. Keys owned<br/>
        /// by other members receive a 404.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="sources">
        /// Default Value: [api, app]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GetAccountUsageResponse>> GetAccountUsageAsResponseAsync(
            global::System.DateTime startTime,
            global::System.DateTime? endTime = default,
            global::Ideogram.GetAccountUsageBucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::Ideogram.GetAccountUsageSource>? sources = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}