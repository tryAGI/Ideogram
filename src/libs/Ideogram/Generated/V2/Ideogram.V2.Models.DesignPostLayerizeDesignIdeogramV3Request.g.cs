
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DesignPostLayerizeDesignIdeogramV3Request
    {
        /// <summary>
        /// The source image to layerize (max 50MB). Common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// The source image to layerize (max 50MB). Common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Candidate font files to make available for text style matching. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB each, maximum 5 files). Multipart requests only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_candidate_files")]
        public global::System.Collections.Generic.IList<byte[]>? FontCandidateFiles { get; set; }

        /// <summary>
        /// When false (the default), the request waits until layerization is complete and returns the result in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignPostLayerizeDesignIdeogramV3Request" /> class.
        /// </summary>
        /// <param name="image">
        /// The source image to layerize (max 50MB). Common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="imagename">
        /// The source image to layerize (max 50MB). Common image formats such as JPEG, PNG, and WEBP are supported. Multipart requests only.
        /// </param>
        /// <param name="prompt">
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.
        /// </param>
        /// <param name="fontCandidateFiles">
        /// Candidate font files to make available for text style matching. Supported formats .ttf, .otf, .woff, .woff2 (max 5MB each, maximum 5 files). Multipart requests only.
        /// </param>
        /// <param name="async">
        /// When false (the default), the request waits until layerization is complete and returns the result in `data`. When true, the request returns as soon as it is accepted; poll `GET /v2/generations/{generation_id}` with the returned `generation_id` for the result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DesignPostLayerizeDesignIdeogramV3Request(
            byte[] image,
            string imagename,
            string? prompt,
            int? seed,
            global::System.Collections.Generic.IList<byte[]>? fontCandidateFiles,
            bool? async,
            string? webhookUrl)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
            this.Prompt = prompt;
            this.Seed = seed;
            this.FontCandidateFiles = fontCandidateFiles;
            this.Async = async;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DesignPostLayerizeDesignIdeogramV3Request" /> class.
        /// </summary>
        public DesignPostLayerizeDesignIdeogramV3Request()
        {
        }

    }
}