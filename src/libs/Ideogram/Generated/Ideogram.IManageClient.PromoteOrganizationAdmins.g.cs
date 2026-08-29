#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Promote members to ADMIN role in a TEAM_API or ENTERPRISE_API organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.OrganizationMemberOperationResponse> PromoteOrganizationAdminsAsync(
            string organizationId,

            global::Ideogram.PromoteOrganizationAdminsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote members to ADMIN role in a TEAM_API or ENTERPRISE_API organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.OrganizationMemberOperationResponse>> PromoteOrganizationAdminsAsResponseAsync(
            string organizationId,

            global::Ideogram.PromoteOrganizationAdminsRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Promote members to ADMIN role in a TEAM_API or ENTERPRISE_API organization
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="members">
        /// List of organization members to promote to ADMIN role<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.OrganizationMemberOperationResponse> PromoteOrganizationAdminsAsync(
            string organizationId,
            global::System.Collections.Generic.IList<global::Ideogram.LiteOrganizationMember> members,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}