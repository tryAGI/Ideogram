#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Promote members to OWNER role in a specific organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.OrganizationMemberOperationResponse> PromoteOrganizationMembersAsync(
            string organizationId,
            global::Ideogram.PromoteOrganizationMembersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Promote members to OWNER role in a specific organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="members">
        /// List of organization members to promote to OWNER role
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.OrganizationMemberOperationResponse> PromoteOrganizationMembersAsync(
            string organizationId,
            global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember> members,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}