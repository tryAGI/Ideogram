
#nullable enable

namespace Ideogram.V2
{
    public sealed partial class IdeogramV2Client
    {
        /// <inheritdoc cref="IdeogramV2Client(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::Ideogram.V2.EndPointAuthorization}?, bool)"/>

        public IdeogramV2Client(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Ideogram.V2.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);

    }
}