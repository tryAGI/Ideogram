
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// This is the API definition for Ideogram AI.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IIdeogramApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Ideogram.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// All things related to generating content.
        /// </summary>
        public GenerateClient Generate { get; }

        /// <summary>
        /// Content related to managing API account and API access
        /// </summary>
        public ManageClient Manage { get; }

        /// <summary>
        /// Operations related to understanding visual content
        /// </summary>
        public VisionClient Vision { get; }

        /// <summary>
        /// Operations and endpoints designed for doing internal testing. Not intended to be called outside a test environment.
        /// </summary>
        public InternalTestingClient InternalTesting { get; }

    }
}