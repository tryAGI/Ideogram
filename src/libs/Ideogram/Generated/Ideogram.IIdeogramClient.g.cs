
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// This is the API definition for Ideogram AI.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IIdeogramClient : global::System.IDisposable
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
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Operations related to managing datasets
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// All things related to generating content.
        /// </summary>
        public GenerateClient Generate { get; }

        /// <summary>
        /// Operations and endpoints designed for doing internal testing. Not intended to be called outside a test environment.
        /// </summary>
        public InternalTestingClient InternalTesting { get; }

        /// <summary>
        /// Content related to managing API account and API access
        /// </summary>
        public ManageClient Manage { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt { get; }

        /// <summary>
        /// Operations related to understanding visual content
        /// </summary>
        public VisionClient Vision { get; }

    }
}