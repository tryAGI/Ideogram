#nullable enable

namespace Ideogram
{
    public partial interface IAssetReferenceUsageClient
    {
        /// <summary>
        /// Rank edit reference assets used by organization requests<br/>
        /// Counts completed requests made by the authenticated organization that used each existing asset as an edit input during the UTC date range. Direct file uploads without saved asset identifiers are excluded. Results are independent of current asset ownership, collection membership, and sharing. Returning an identifier does not grant access to its image. Tracking begins when enabled; earlier history is not included. Returns 50 assets per page by default, up to 100 with limit. Rankings may change between pages when daily counts are updated; cursors do not pin a historical snapshot.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="collectionIds"></param>
        /// <param name="includeCollections">
        /// Default Value: false
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AssetReferenceUsageResponse> GetAssetReferenceUsageAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? collectionIds = default,
            bool? includeCollections = default,
            string? cursor = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rank edit reference assets used by organization requests<br/>
        /// Counts completed requests made by the authenticated organization that used each existing asset as an edit input during the UTC date range. Direct file uploads without saved asset identifiers are excluded. Results are independent of current asset ownership, collection membership, and sharing. Returning an identifier does not grant access to its image. Tracking begins when enabled; earlier history is not included. Returns 50 assets per page by default, up to 100 with limit. Rankings may change between pages when daily counts are updated; cursors do not pin a historical snapshot.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="collectionIds"></param>
        /// <param name="includeCollections">
        /// Default Value: false
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.AssetReferenceUsageResponse>> GetAssetReferenceUsageAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? collectionIds = default,
            bool? includeCollections = default,
            string? cursor = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}