#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve members of a specific organization<br/>
        /// Returns both active members and pending invites for the organization. A pending invite is identified by a non-null invite_status (e.g. PENDING); active members have a null invite_status.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetOrganizationMembersResponse> GetOrganizationMembersAsync(
            string organizationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve members of a specific organization<br/>
        /// Returns both active members and pending invites for the organization. A pending invite is identified by a non-null invite_status (e.g. PENDING); active members have a null invite_status.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.GetOrganizationMembersResponse>> GetOrganizationMembersAsResponseAsync(
            string organizationId,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}