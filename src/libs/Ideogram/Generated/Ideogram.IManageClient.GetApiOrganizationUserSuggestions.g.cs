#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Get search results for user handles with suggestions for a particular organization.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userHandlePrefix"></param>
        /// <param name="maxItems">
        /// Default Value: 3
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetApiOrganizationUserSuggestionsResponse> GetApiOrganizationUserSuggestionsAsync(
            string organizationId,
            string? userHandlePrefix = default,
            int? maxItems = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}