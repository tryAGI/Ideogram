
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// This is the API definition for Ideogram AI.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class IdeogramApi : global::Ideogram.IIdeogramApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::Ideogram.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Ideogram.SourceGenerationContext.Default;


        /// <summary>
        /// All things related to generating content.
        /// </summary>
        public GenerateClient Generate => new GenerateClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Content related to managing API account and API access
        /// </summary>
        public ManageClient Manage => new ManageClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Operations related to understanding visual content
        /// </summary>
        public VisionClient Vision => new VisionClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the IdeogramApi.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public IdeogramApi(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Ideogram.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Ideogram.EndPointAuthorization>();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}