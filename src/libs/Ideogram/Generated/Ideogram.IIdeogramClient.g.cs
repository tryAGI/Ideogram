
#nullable enable

namespace Ideogram
{
    /// <summary>
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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Ideogram.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        ///
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        ///
        /// </summary>
        public AutoModelClient AutoModel { get; }

        /// <summary>
        ///
        /// </summary>
        public DesignClient Design { get; }

        /// <summary>
        ///
        /// </summary>
        public EditWorkflowClient EditWorkflow { get; }

        /// <summary>
        ///
        /// </summary>
        public GenerationsClient Generations { get; }

        /// <summary>
        ///
        /// </summary>
        public ImageDescribeClient ImageDescribe { get; }

        /// <summary>
        ///
        /// </summary>
        public ImagesGenerateClient ImagesGenerate { get; }

        /// <summary>
        ///
        /// </summary>
        public ImagesInpaintClient ImagesInpaint { get; }

        /// <summary>
        ///
        /// </summary>
        public ImagesPreciseEditClient ImagesPreciseEdit { get; }

        /// <summary>
        ///
        /// </summary>
        public ImagesRemixClient ImagesRemix { get; }

        /// <summary>
        ///
        /// </summary>
        public ImagesUpscaleClient ImagesUpscale { get; }

        /// <summary>
        ///
        /// </summary>
        public ObjectRemovalClient ObjectRemoval { get; }

        /// <summary>
        ///
        /// </summary>
        public ReframeClient Reframe { get; }

        /// <summary>
        ///
        /// </summary>
        public ToolClient Tool { get; }

        /// <summary>
        ///
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        ///
        /// </summary>
        public VideoEditClient VideoEdit { get; }

        /// <summary>
        ///
        /// </summary>
        public VideoGenerateClient VideoGenerate { get; }

    }
}