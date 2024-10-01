
#nullable enable

namespace Ideogram
{
    public sealed partial class IdeogramApi
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Ideogram.EndPointAuthorization
            {
                Name = "Api-Key",
                Value = apiKey,
            };
        }
    }
}