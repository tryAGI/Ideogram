
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
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Ideogram.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Model-agnostic endpoints where the server selects the model for each<br/>
        /// request. Requests are JSON and return a generation id that can be<br/>
        /// polled via `GET /v1/generations/{generation_id}`.
        /// </summary>
        public AutoModelClient AutoModel { get; }

        /// <summary>
        ///
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// Operations related to managing datasets.
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// Asynchronous image-editing workflows that return results through generation polling.
        /// </summary>
        public EditWorkflowClient EditWorkflow { get; }

        /// <summary>
        /// All things related to generating content.
        /// </summary>
        public GenerateClient Generate { get; }

        /// <summary>
        /// Edit existing images from a plain-language instruction. Requests supply<br/>
        /// sources by `AssetIdentifier` reference or as uploaded bytes and return a<br/>
        /// generation id that can be polled via `GET /v1/generations/{generation_id}`.
        /// </summary>
        public ImagesEditClient ImagesEdit { get; }

        /// <summary>
        /// Generate images with a specific model contract. Requests are JSON<br/>
        /// (Ideogram 3.0 also accepts multipart for style reference bytes) and<br/>
        /// return a generation id that can be polled via<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        public ImagesGenerateClient ImagesGenerate { get; }

        /// <summary>
        /// Repaint a masked region of an image with a specific model contract.<br/>
        /// Requests supply the source image and mask by `AssetIdentifier`<br/>
        /// reference or as uploaded bytes and return a generation id that can be<br/>
        /// polled via `GET /v1/generations/{generation_id}`.
        /// </summary>
        public ImagesInpaintClient ImagesInpaint { get; }

        /// <summary>
        /// Transform an existing image with a specific model contract, guided by<br/>
        /// a prompt. Requests supply the source by `AssetIdentifier` reference or<br/>
        /// as uploaded bytes, and return a generation id that can be polled via<br/>
        /// `GET /v1/generations/{generation_id}`.
        /// </summary>
        public ImagesRemixClient ImagesRemix { get; }

        /// <summary>
        ///
        /// </summary>
        public ImagesUpscaleClient ImagesUpscale { get; }

        /// <summary>
        /// Operations and endpoints designed for doing internal testing. Not intended to be called outside a test environment.
        /// </summary>
        public InternalTestingClient InternalTesting { get; }

        /// <summary>
        /// Content related to managing API account and API access.
        /// </summary>
        public ManageClient Manage { get; }

        /// <summary>
        /// Operations related to publishing mini-apps into the catalog.
        /// </summary>
        public MiniAppsClient MiniApps { get; }

        /// <summary>
        /// Operations related to managing custom models.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// Remove unwanted objects from existing image assets. Requests use<br/>
        /// `AssetIdentifier` references and return a generation id that can be<br/>
        /// polled via `GET /v1/generations/{generation_id}`.
        /// </summary>
        public ObjectRemovalClient ObjectRemoval { get; }

        /// <summary>
        ///
        /// </summary>
        public PromptClient Prompt { get; }

        /// <summary>
        ///
        /// </summary>
        public ProvenanceClient Provenance { get; }

        /// <summary>
        /// Outcome-focused image tools with implementation details managed by Ideogram.
        /// </summary>
        public ToolClient Tool { get; }

        /// <summary>
        ///
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        ///
        /// </summary>
        public VideoGenerateClient VideoGenerate { get; }

        /// <summary>
        /// Operations related to understanding visual content.
        /// </summary>
        public VisionClient Vision { get; }

        /// <summary>
        /// Endpoints related to webhook delivery and verification. The JWKS<br/>
        /// endpoint publishes the Ed25519 public keys customers use to verify<br/>
        /// that an inbound webhook genuinely originated from Ideogram.
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}