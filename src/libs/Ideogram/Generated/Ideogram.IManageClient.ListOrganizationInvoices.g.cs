#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve invoices for a specific organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.ListOrganizationInvoicesResponse> ListOrganizationInvoicesAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}