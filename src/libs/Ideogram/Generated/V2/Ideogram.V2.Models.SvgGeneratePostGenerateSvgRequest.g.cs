
#nullable enable

namespace Ideogram.V2
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SvgGeneratePostGenerateSvgRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Existing uploaded or generated image references. Takes priority over images when both are supplied. The first image is the primary source; any others are additional references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_asset_identifiers")]
        public global::System.Collections.Generic.IList<global::Ideogram.V2.AssetIdentifier>? ImageAssetIdentifiers { get; set; }

        /// <summary>
        /// Source images to transform, supplied as multipart file uploads. The first image is the primary source; any others are additional references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<byte[]>? Images { get; set; }

        /// <summary>
        /// Supported output aspect ratios. The operation defines whether `auto`<br/>
        /// preserves the source shape or selects a shape from the prompt.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.IdeogramV4AspectRatioJsonConverter))]
        public global::Ideogram.V2.IdeogramV4AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: medium
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ideogram.V2.JsonConverters.V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQualityJsonConverter))]
        public global::Ideogram.V2.V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality? Quality { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

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
        /// Initializes a new instance of the <see cref="SvgGeneratePostGenerateSvgRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="imageAssetIdentifiers">
        /// Existing uploaded or generated image references. Takes priority over images when both are supplied. The first image is the primary source; any others are additional references.
        /// </param>
        /// <param name="images">
        /// Source images to transform, supplied as multipart file uploads. The first image is the primary source; any others are additional references.
        /// </param>
        /// <param name="aspectRatio">
        /// Supported output aspect ratios. The operation defines whether `auto`<br/>
        /// preserves the source shape or selects a shape from the prompt.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="quality">
        /// Default Value: medium
        /// </param>
        /// <param name="numImages">
        /// Default Value: 1
        /// </param>
        /// <param name="seed"></param>
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
        /// private and loopback hosts and the cloud metadata service are rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SvgGeneratePostGenerateSvgRequest(
            string prompt,
            global::System.Collections.Generic.IList<global::Ideogram.V2.AssetIdentifier>? imageAssetIdentifiers,
            global::System.Collections.Generic.IList<byte[]>? images,
            global::Ideogram.V2.IdeogramV4AspectRatio? aspectRatio,
            global::Ideogram.V2.V2SvgGenerateIdeogramVector1PostRequestBodyContentMultipartFormDataSchemaQuality? quality,
            int? numImages,
            int? seed,
            bool? @private,
            string? targetCollectionId,
            string? webhookUrl)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ImageAssetIdentifiers = imageAssetIdentifiers;
            this.Images = images;
            this.AspectRatio = aspectRatio;
            this.Quality = quality;
            this.NumImages = numImages;
            this.Seed = seed;
            this.Private = @private;
            this.TargetCollectionId = targetCollectionId;
            this.WebhookUrl = webhookUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgGeneratePostGenerateSvgRequest" /> class.
        /// </summary>
        public SvgGeneratePostGenerateSvgRequest()
        {
        }

    }
}