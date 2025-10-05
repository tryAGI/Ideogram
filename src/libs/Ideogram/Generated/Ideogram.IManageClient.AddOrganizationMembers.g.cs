#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Add members to a specific organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.OrganizationMemberOperationResponse> AddOrganizationMembersAsync(
            string organizationId,
            global::Ideogram.AddOrganizationMembersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add members to a specific organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="members">
        /// List of organization members to add
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.OrganizationMemberOperationResponse> AddOrganizationMembersAsync(
            string organizationId,
            global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember> members,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}