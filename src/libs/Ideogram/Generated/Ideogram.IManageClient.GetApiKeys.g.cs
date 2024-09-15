#nullable enable

namespace Ideogram
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Retrieve current API keys and their respective data.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ideogram.GetApiKeysResponse> GetApiKeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}