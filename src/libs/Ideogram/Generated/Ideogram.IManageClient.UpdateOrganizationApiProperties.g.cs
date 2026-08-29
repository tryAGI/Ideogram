#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Update a single field on an organization's API properties.<br/>
        /// Lets an organization owner toggle API-only settings such as<br/>
        /// copyright_detection_enabled. Updates only the fields explicitly present<br/>
        /// in the request body; absent fields are left unchanged.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.UpdateOrganizationApiPropertiesResponse> UpdateOrganizationApiPropertiesAsync(
            string organizationId,

            global::Ideogram.UpdateOrganizationApiPropertiesRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a single field on an organization's API properties.<br/>
        /// Lets an organization owner toggle API-only settings such as<br/>
        /// copyright_detection_enabled. Updates only the fields explicitly present<br/>
        /// in the request body; absent fields are left unchanged.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.AutoSDKHttpResponse<global::Ideogram.UpdateOrganizationApiPropertiesResponse>> UpdateOrganizationApiPropertiesAsResponseAsync(
            string organizationId,

            global::Ideogram.UpdateOrganizationApiPropertiesRequest request,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a single field on an organization's API properties.<br/>
        /// Lets an organization owner toggle API-only settings such as<br/>
        /// copyright_detection_enabled. Updates only the fields explicitly present<br/>
        /// in the request body; absent fields are left unchanged.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="copyrightDetectionEnabled">
        /// Toggle post-generation Hive likeness + logo detection for this organization. See ApiProfile.copyright_detection_enabled for behavior.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.UpdateOrganizationApiPropertiesResponse> UpdateOrganizationApiPropertiesAsync(
            string organizationId,
            bool? copyrightDetectionEnabled = default,
            global::Ideogram.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}