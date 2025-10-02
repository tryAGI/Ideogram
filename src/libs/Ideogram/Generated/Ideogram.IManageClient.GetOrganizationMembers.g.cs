#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve members of a specific organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetOrganizationMembersResponse> GetOrganizationMembersAsync(
            string organizationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}