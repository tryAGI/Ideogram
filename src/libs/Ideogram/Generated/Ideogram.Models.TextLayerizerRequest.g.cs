
#nullable enable

namespace Ideogram
{
    /// <summary>
    /// A request to layerize the text in one image. Provide exactly one of<br/>
    /// `image` or `image_asset_identifier`.
    /// </summary>
    public sealed partial class TextLayerizerRequest
    {
        /// <summary>
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public byte[]? Image { get; set; }

        /// <summary>
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        public string? Imagename { get; set; }

        /// <summary>
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </summary>
        /// <example>{"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifier")]
        public global::Ideogram.AssetIdentifier? ImageAssetIdentifier { get; set; }

        /// <summary>
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </summary>
        /// <example>12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Candidate font files to make available for text style matching and to embed in the standalone HTML page. Supported formats .ttf, .otf, .woff, .woff2 (max 5 MB each, at most 5 files). Multipart only. You are responsible for holding the rights to embed and redistribute the fonts you upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("font_candidate_files")]
        public global::System.Collections.Generic.IList<byte[]>? FontCandidateFiles { get; set; }

        /// <summary>
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// URL-safe base64 ID of a writable destination collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_collection_id")]
        public string? TargetCollectionId { get; set; }

        /// <summary>
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </summary>
        /// <example>https://api.example.com/webhooks/ideogram</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayerizerRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </param>
        /// <param name="imagename">
        /// JPEG, PNG or WEBP source; at most 50 MB. Multipart only.
        /// </param>
        /// <param name="imageAssetIdentifier">
        /// An identifier for an ideogram asset.<br/>
        /// Example: {"asset_type":"RESPONSE","asset_id":"7uS_VESkRI6O3-sVgHQp_A"}
        /// </param>
        /// <param name="prompt">
        /// A description of the image, used to guide text detection. When omitted, detection runs on the image alone.
        /// </param>
        /// <param name="seed">
        /// Random seed. Set for reproducible generation.<br/>
        /// Example: 12345
        /// </param>
        /// <param name="fontCandidateFiles">
        /// Candidate font files to make available for text style matching and to embed in the standalone HTML page. Supported formats .ttf, .otf, .woff, .woff2 (max 5 MB each, at most 5 files). Multipart only. You are responsible for holding the rights to embed and redistribute the fonts you upload.
        /// </param>
        /// <param name="private">
        /// Outputs are private by default. Enterprise outputs are always private.
        /// </param>
        /// <param name="targetCollectionId">
        /// URL-safe base64 ID of a writable destination collection.
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL that Ideogram delivers the generated result to. Ideogram sends a<br/>
        /// JSON POST to this URL once all images for the request have finished<br/>
        /// generating. The body mirrors the synchronous generate response:<br/>
        /// `request_id`, `created`, and a `data` array<br/>
        /// containing every generated image (`url`, `prompt`, `resolution`, `seed`,<br/>
        /// `is_image_safe`). Each delivery is signed with Ed25519 and verifiable<br/>
        /// against the public keys at `https://api.ideogram.ai/v1/.well-known/jwks.json`. Must be HTTPS;<br/>
        /// private and loopback hosts and the cloud metadata service are rejected.<br/>
        /// Example: https://api.example.com/webhooks/ideogram
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextLayerizerRequest(
            byte[]? image,
            string? imagename,
            global::Ideogram.AssetIdentifier? imageAssetIdentifier,
            string? prompt,
            int? seed,
            global::System.Collections.Generic.IList<byte[]>? fontCandidateFiles,
            bool? @private,
            string? targetCollectionId,
            string? webhookUrl)
        {
            this.Image = image;
            this.Imagename = imagename;
            this.ImageAssetIdentifier = imageAssetIdentifier;
            this.Prompt = prompt;
            this.Seed = seed;
            this.FontCandidateFiles = fontCandidateFiles;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextLayerizerRequest" /> class.
        /// </summary>
        public TextLayerizerRequest()
        {
        }

    }
}