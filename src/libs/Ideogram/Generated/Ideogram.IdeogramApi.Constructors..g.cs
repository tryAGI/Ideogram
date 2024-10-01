
#nullable enable

namespace Ideogram
{
    public sealed partial class IdeogramApi
    {
        /// <inheritdoc cref="IdeogramApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Ideogram.EndPointAuthorization?)"/>
        public IdeogramApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Ideogram.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}