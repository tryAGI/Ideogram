#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Deactivate an API key for a specific organization
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ideogram.ApiException"></exception>
        global::System.Threading.Tasks.Task DeactivateOrganizationApiKeyAsync(
            string apiKeyId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}