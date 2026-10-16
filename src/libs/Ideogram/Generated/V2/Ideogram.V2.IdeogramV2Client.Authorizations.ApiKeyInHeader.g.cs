
#nullable enable

namespace Ideogram.V2
{
    public sealed partial class IdeogramV2Client
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "Api-Key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Ideogram.V2.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyApiKey",
                Location = "Header",
                Name = "Api-Key",
                Value = apiKey,
            });
        }
    }
}