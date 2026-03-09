
#nullable enable

namespace Ideogram
{
    public sealed partial class IdeogramClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Ideogram.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "Api-Key",
                Value = apiKey,
            });
        }
    }
}