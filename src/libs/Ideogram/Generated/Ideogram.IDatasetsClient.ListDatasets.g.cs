#nullable enable

namespace Ideogram
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List datasets<br/>
        /// Lists all datasets for the authenticated user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ListDatasetsResponse> ListDatasetsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}